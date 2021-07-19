<template>
  <div>
    <button type="button" class="btn" :class="cssClass">{{btnText}}</button>
  </div>
</template>
<script>
export default {
  name: 'custom-button',
  props: {
    btnText: {
      type: String,
      required: true
    },
    cssClass: {
      type: String,
      default: ''
    }
  },
  data() {
    return {
      messages: this.message
    }
  }
};

</script>