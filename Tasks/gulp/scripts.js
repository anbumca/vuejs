/**
 * Created by christophe.gaon on 30/01/2017.
 */


// Config that can be loaded externally, similar
// to [gulp-starter](https://github.com/greypants/gulp-starter)
// Gulp + Browserify recipe
// ------------------------
// Includes react JSX, coffeescript, uglify & sourcemaps
// Supports multiple input & output files

const gulp = require('gulp')
const browserify = require('browserify')
const globby = require('globby')
const source = require('vinyl-source-stream')
const buffer = require('vinyl-buffer')
const uglify = require('gulp-uglify')
const exorcist = require('exorcist')
const production = require('gulp-environments').production
const es = require('event-stream')

const config = require('./../config') ()

let FeaturesFondationsSrc
let FeaturesFondationsAdminSrc

/**
 * On get Error on promess of this task
 * @param err
 */
const onError = (err) => {
  console.error('onError', err)
};

/**
 * on getting the paths of all code in project level
 * @param paths
 */
const onGetProjectcode = (files) => {
  const tasks = files.map((entry) => {
    let destFile = config.bundle.jsBundleName
    let entries = [...FeaturesFondationsSrc, entry]
    if (entry.indexOf('admin') > -1) {
      destFile = config.bundle.adminBundleName
      entries = [...FeaturesFondationsAdminSrc, entry]
    }    
    const themeDir = config.directories.buildDirectory
    return browserify({
      entries,
      ignore: '!**/*.spec.js',
      debug: true,
    })     
    .transform('babelify')
    .bundle()
    .pipe(exorcist(`${themeDir}/${config.bundle.jsMapName}`))
    .pipe(source(destFile))
    .pipe(production(buffer()))
    .pipe(production(uglify()))
    .pipe(gulp.dest(themeDir))
  })

  // create a merged stream
  return es.merge.apply(null, tasks)
};

/**
 * on get the paths of all code in feature and foundation level
 * @param paths
 */
const onGetFondationFeatureCode = (paths) => {
  FeaturesFondationsSrc = paths
  return globby([`${config.directories.featureDirectory}**/*/entry.js`])
    .then(onGetProjectcode, onError)
};

const onGetFondationFeatureAdminCode = (paths) => {
  FeaturesFondationsAdminSrc = paths
  return globby([
    `${config.directories.featureDirectory}**/*/Rating-admin-bundle.js`,
  ])
    .then(onGetProjectcode, onError)
};

module.exports = function (gulp) {
  return function () {
    const web = globby([
      `${config.directories.foundationDirectory}**/entry.js`,
      `${config.directories.featureDirectory}**/entry.js`
    ])
      .then(onGetFondationFeatureCode, onError);

    const admin = globby([
      `${config.directories.foundationDirectory}**/Rating-admin-bundle.js`,
      `${config.directories.featureDirectory}**/Rating-admin-bundle.js`
    ])
      .then(onGetFondationFeatureAdminCode, onError);

    return Promise.all([web, admin]);
  };
}
