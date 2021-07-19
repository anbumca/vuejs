import Vue from 'vue';
import 'es6-promise/auto';
import 'idempotent-babel-polyfill';

import sampleComponent from './Components/sampleComponent/sampleComponent.vue';
import viewDataComponent from './Components/sampleComponent/viewDatas.vue';
import lifecycle from './Components/lifecycle/lifecycle.vue';
import alert from './Components/alert.vue';
import sampleView from './Components/sampleView.vue';
import btn from './Components/button.vue';
import dropdown from './Components/dropdown.vue';
import formGroup from './Components/formGroup.vue';
import groupButton from './Components/groupButton.vue';
import image from './Components/image.vue';
import list from './Components/list.vue';
import pagination from './Components/pagination.vue';

Vue.component(sampleComponent.name, sampleComponent);
Vue.component(viewDataComponent.componentName, viewDataComponent);
Vue.component(lifecycle.name, lifecycle);
Vue.component(alert.name, alert);
Vue.component(sampleView.name, sampleView);
Vue.component(btn.name, btn);
Vue.component(dropdown.name, dropdown);
Vue.component(formGroup.name, formGroup);
Vue.component(groupButton.name, groupButton);
Vue.component('custom-image', image);
Vue.component('custom-list', list);
Vue.component('custom-pagination', pagination);

window.eventBus = new Vue();

new Vue({
  el: '#app'
});
