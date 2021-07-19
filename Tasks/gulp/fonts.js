const glob = require('glob');
const es = require('event-stream');

const config = require('./../config')();


module.exports = function (gulp) {
  return function () {
    /**
     * Find all font directories
     */
    return glob(`${config.directories.featureDirectory}**/code/**/Fonts`, (err, files) => {
      /**
       * Map all font directories to tasks
       */
      const tasks = files.map((fontsDirectoryPath) => {
        /**
         * Get the current project name
         */
        

        /**
         * Copy the fonts from the /src directory to the project folder
         */
        return gulp.src(`${fontsDirectoryPath}**/*`)
          .pipe(gulp.dest(config.directories.buildDirectory));
      });

      // create a merged stream
      return es.merge.apply(null, tasks);
    });
  };
};
