
module.exports = function () {
  let instanceRoot = '';
  let config = {
    websiteRoot: instanceRoot + '\\Website',
    sitecoreLibraries: instanceRoot + '\\Website\\bin',
    licensePath: instanceRoot + '\\Data\\license.xml',
    solutionName: 'wsfdemo',
    buildConfiguration: 'Debug',
    runCleanBuilds: false,
    directories: {
      src: './src/',
      featureDirectory: './src/Feature/',
      projectDirectory: './src/Project/',
      buildDirectory: './build'
    },
    currentWebsite: 'wsfdemo',
    autoPrefixerBrowsers: ['last 2 versions', 'ie >= 10', 'Safari >= 9', 'iOS >= 8'],
    bundle: {
      cssBundleName: 'bundle.css',
      jsBundleName: 'bundle.js',
      jsMapName: 'bundle.map.js',
      adminBundleName: 'admin-bundle.js'
    }
  };
  return config;
};
