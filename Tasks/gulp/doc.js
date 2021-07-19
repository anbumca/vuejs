// Config that can be loaded externally, similar
// to [gulp-starter](https://github.com/greypants/gulp-starter)
// Gulp + Browserify recipe
// ------------------------
// Includes react JSX, coffeescript, uglify & sourcemaps
// Supports multiple input & output files

// const gulp = require('gulp')
const exec = require('child_process').exec
module.exports = function (gulp) {
  exec('npm run doc')
}
