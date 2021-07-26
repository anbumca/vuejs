import Vue from 'vue';
import 'es6-promise/auto';
import 'idempotent-babel-polyfill';

import sampleComponent from './Components/sampleComponent/sampleComponent.vue';
import hello from './Components/unit-test-sample/unit-test-sample.vue'

Vue.component('sample-component', sampleComponent);
Vue.component('hello', hello);

window.eventBus = new Vue();

new Vue({
  el: '#app'
});
