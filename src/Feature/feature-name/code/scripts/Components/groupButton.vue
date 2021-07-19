<template>
  <div class="btn-group">
    <div v-for="x in btnList">
      <custom-button :btn-text="x.buttonText" css-class="cssClass"></custom-button>
    </div>
  </div>
</template>
<script>
import customButton from './button.vue'
export default {
  name: 'group-button',
  component: {
    customButton
  },
  props: {
    btnList: {
      type: Array,
      required: true
    }
  }
};

</script>