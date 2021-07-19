// / <binding />
const gulp = require('gulp');
const watch = require('gulp-watch');
const runSequence = require('run-sequence');
const config = require('./Tasks/config.js')();
const nugetRestore = require('gulp-nuget-restore');
const requireDir = require('require-dir');
const plugins = require('gulp-load-plugins')();

requireDir('./Tasks/gulp');

function getTask(task) {
  return require('./Tasks/gulp/' + task)(gulp, plugins);
}

gulp.task('scripts', getTask('scripts'));
gulp.task('eslint', getTask('eslint'));
gulp.task('styles', getTask('styles'));
gulp.task('fractal', getTask('fractal'));
gulp.task('js-Doc', getTask('doc'));
gulp.task('fonts', getTask('fonts'));
gulp.task('images', getTask('images'));
gulp.task('icons', getTask('icons'));

gulp.task('build', ['scripts', 'styles', 'images', 'eslint']);

/** Default tasks */
gulp.task('watch', () => {
  gulp.watch([`${config.directories.featureDirectory}**/*.js`], ['scripts']);
  gulp.watch([`${config.directories.featureDirectory}**/*.vue`], ['scripts']);
  gulp.watch([`${config.directories.featureDirectory}**/*.scss`], ['styles']);
});

gulp.task('develop', () => {
  runSequence('fractal', 'watch', 'scripts', 'styles');
});
