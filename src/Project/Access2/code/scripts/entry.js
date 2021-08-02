import Vue from 'vue';
import 'es6-promise/auto';
import 'idempotent-babel-polyfill';
import Vuelidate from 'vuelidate';

import sampleComponent from './Components/sampleComponent/sampleComponent.vue';
import sampleForm from './Components/sampleComponent/sample-form.vue';
import hello from './Components/unit-test-sample/unit-test-sample.vue'

Vue.component('sample-component', sampleComponent);
Vue.component('sample-form', sampleForm);
Vue.component('hello', hello);

Vue.use(Vuelidate);

window.eventBus = new Vue();

new Vue({
  el: '#app'
});
