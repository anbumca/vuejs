const forEach = require('lodash').forEach;
// const req = require('babel-plugin-require-context-hook/register')();

// const fieldComponents = {};
// const requireContext = require('require-context');
// const fs = require('fs');
// const path = require('path');
 /*
const coreFields = require.context('../fields/core', false, /^\.\/field([\w-_]+)\.vue$/);

forEach(coreFields.keys(), (key) => {
  const compName = key.replace(/^\.\//, '').replace(/\.vue/, '');
  fieldComponents[compName] = coreFields(key).default;
}); */
if (typeof require.context === 'undefined') {
  const fs = require('fs');
  const path = require('path');
  require.context = (base = '../fields/core', scanSubDirectories = false, regularExpression = /^\.\/field([\w-_]+)\.vue$/) => {
    const files = {};

    function readDirectory(directory) {
      fs.readdirSync(directory).forEach((file) => {
        debugger;
        const fullPath = path.resolve(directory, file);
        if (fs.statSync(fullPath).isDirectory()) {
          if (scanSubDirectories) readDirectory(fullPath);
          return;
        }

        if (!regularExpression.test(fullPath)) return;

        files[fullPath] = true;
      });
    }

    readDirectory(path.resolve(__dirname, base));

    function Module(file) {
      return require(file);
    }

    Module.keys = () => Object.keys(files);
    console.log(Module);
    return Module;
  };
}
if (process.env.FULL_BUNDLE) {
  if (typeof require.context === 'undefined') {
    const fs = require('fs');
    const path = require('path');
    require.context = (base = '../fields/optional', scanSubDirectories = false, regularExpression = /^\.\/field([\w-_]+)\.vue$/) => {
      const files = {};

      function readDirectory(directory) {
        fs.readdirSync(directory).forEach((file) => {
          const fullPath = path.resolve(directory, file);
          if (fs.statSync(fullPath).isDirectory()) {
            if (scanSubDirectories) readDirectory(fullPath);
            return;
          }

          if (!regularExpression.test(fullPath)) return;

          files[fullPath] = true;
        });
      }

      readDirectory(path.resolve(__dirname, base));

      function Module(file) {
        return require(file);
      }

      Module.keys = () => Object.keys(files);

      return Module;
    };
  }
}


  /* const optionalFields = require.context('../fields/optional', false, /^\.\/field([\w-_]+)\.vue$/);

  forEach(optionalFields.keys(), (key) => {
    const compName = key.replace(/^\.\//, '').replace(/\.vue/, '');
    fieldComponents[compName] = optionalFields(key).default;
  });
}

module.exports = fieldComponents; */
