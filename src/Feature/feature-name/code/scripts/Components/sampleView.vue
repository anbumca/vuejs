<template>
  <div>
    <div v-for="data in datas"> 
      <alert :message="data.message" :css-class="data.className"></alert>
    </div>
  </div>
</template>
<script>
import alert from './alert.vue'
export default {
  name: 'sampleView',
  component: {
    alert
  },
  props: {
    datas: {
      type: Array,
      required: true
    }
  }
};

</script>