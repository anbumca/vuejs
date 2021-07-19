const production = require('gulp-environments').production
const glob = require('glob')
const es = require('event-stream')
const sass = require('gulp-sass')
const concat = require('gulp-concat')
const cleanCSS = require('gulp-clean-css')
const postcss = require('gulp-postcss')
const autoprefixer = require('autoprefixer')
const config = require('../config.js')()

module.exports = function (gulp) {
  return function () {
    return glob(`${config.directories.featureDirectory}**/entry.scss`, (err, files) => {
      const tasks = files.map((entry) => {
        return gulp.src([`${config.directories.featureDirectory}**/*.scss`, entry])
          // .pipe(sourcemaps.init())  Currently an error in the gulp-sourcemaps plugin... Enable once fixed
          .pipe(sass().on('error', sass.logError))
          .pipe(concat(config.bundle.cssBundleName))
          .pipe(postcss([
            autoprefixer({ browsers: config.autoPrefixerBrowsers })
          ]))
          .pipe(production(cleanCSS()))
          // .pipe(sourcemaps.write('./'))
          .pipe(gulp.dest(config.directories.buildDirectory))
      })
      if (err) {
        console.log(err)
      }
      // create a merged stream
      return es.merge.apply(null, tasks)
    })
  }
}
