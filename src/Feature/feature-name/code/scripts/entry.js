import Vue from 'vue';
import 'es6-promise/auto';
import 'idempotent-babel-polyfill';

import sampleComponent from './Components/sampleComponent/sampleComponent.vue';

Vue.component('sample-component', sampleComponent);

window.eventBus = new Vue();

new Vue({
  el: '#app'
});
