const gulp = require('gulp')
const msbuild = require('gulp-msbuild')
const debug = require('gulp-debug')
const foreach = require('gulp-foreach')
const rename = require('gulp-rename')
const newer = require('gulp-newer')
const config = require('../config.js')()
const yargs = require('yargs').argv

module.exports.config = config

var publishStream = function (stream, dest) {
  var targets = ['Build']

  return stream
  .pipe(debug({ title: 'Building project:' }))
  .pipe(msbuild({
    targets: targets,
    configuration: config.buildConfiguration,
    logCommand: false,
    verbosity: 'minimal',
    stdout: true,
    errorOnFail: true,
    maxcpucount: 0,
    toolsVersion: 14.0,
    properties: {
      DeployOnBuild: 'true',
      DeployDefaultTarget: 'WebPublish',
      WebPublishMethod: 'FileSystem',
      DeleteExistingFiles: 'false',
      publishUrl: dest,
      _FindDependencies: 'false'
    }
  }))
}

var publishProject = function (location, dest) {
  dest = dest || config.websiteRoot

  console.log('publish to ' + dest + ' folder')
  return gulp.src(['./src/' + location + '/code/*.csproj'])
  .pipe(foreach(function (stream, file) {
    return publishStream(stream, dest)
  }))
}

var publishProjects = function (location, dest) {
  dest = dest || config.websiteRoot

  console.log('publish to ' + dest + ' folder')
  return gulp.src([location + '/**/code/*.csproj'])
  .pipe(foreach(function (stream, file) {
    return publishStream(stream, dest)
  }))
}

gulp.task('Build-Solution', function () {
  var targets = ['Build']
  if (config.runCleanBuilds) {
    targets = ['Clean', 'Build']
  }
  var solution = './' + config.solutionName + '.sln'
  return gulp.src(solution)
  .pipe(msbuild({
    targets: targets,
    configuration: config.buildConfiguration,
    logCommand: false,
    verbosity: 'minimal',
    stdout: true,
    errorOnFail: true,
    maxcpucount: 0,
    toolsVersion: 14.0
  }))
})

gulp.task('Publish-Foundation-Projects', function () {
  return publishProjects('./src/Foundation')
})

gulp.task('Publish-Feature-Projects', function () {
  return publishProjects('./src/Feature')
})

gulp.task('Publish-Project-Projects', function () {
  return publishProjects('./src/Project')
})

gulp.task('Publish-Project', function () {
  if (yargs && yargs.m && typeof (yargs.m) === 'string') {
    return publishProject(yargs.m)
  } else {
    throw new Error('error')
  }
})

gulp.task('Publish-All-Views', function () {
  var root = './src'
  var roots = [root + '/**/Views', '!' + root + '/**/obj/**/Views']
  var files = '/**/*.cshtml'
  var destination = config.websiteRoot + '\\Views'
  return gulp.src(roots, { base: root }).pipe(
    foreach(function (stream, file) {
      console.log('Publishing from ' + file.path)
      gulp.src(file.path + files, { base: file.path })
        .pipe(newer(destination))
        .pipe(debug({ title: 'Copying ' }))
        .pipe(gulp.dest(destination))
      return stream
    })
  )
})

gulp.task('Publish-All-Configs', function () {
  var root = './src'
  var roots = [root + '/**/App_Config', '!' + root + '/**/obj/**/App_Config']
  var files = '/**/*.config'
  var destination = config.websiteRoot + '\\App_Config'
  return gulp.src(roots, { base: root }).pipe(
    foreach(function (stream, file) {
      console.log('Publishing from ' + file.path)
      gulp.src(file.path + files, { base: file.path })
        .pipe(newer(destination))
        .pipe(debug({ title: 'Copying ' }))
        .pipe(gulp.dest(destination))
      return stream
    })
  )
})
