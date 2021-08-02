import Vue from 'vue';
import 'es6-promise/auto';
import 'idempotent-babel-polyfill';

import formGenerator from './Components/form-generator/formGenerator.vue';
import basicformGenerator from './components/form-list/basic-form.vue';

Vue.component('form-generator', formGenerator);
Vue.component('basic-form-generator', basicformGenerator);

window.eventBus = new Vue();
