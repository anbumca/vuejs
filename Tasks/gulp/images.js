const production = require('gulp-environments').production;

const glob = require('glob');
const es = require('event-stream');
const imagemin = require('gulp-imagemin');

const config = require('./../config')();


module.exports = function (gulp) {
  return function () {
    /**
     * Find all images folders
     */
    return glob(`${config.directories.featureDirectory}**/code/**/Images`, (err, files) => {
      /**
       * map the folders to tasks
       */
      const tasks = files.map((imagesDirectoryPath) => {
        /**
         * get the current project name
         */
        
        /**
         * minify the images and copy them to the build directory
         */
        return gulp.src(`${imagesDirectoryPath}/**/*`)
          .pipe(production(imagemin()))
          .pipe(gulp.dest(`${config.directories.buildDirectory }/Images`));
      });

      // create a merged stream
      return es.merge.apply(null, tasks);
    });
  };
};
