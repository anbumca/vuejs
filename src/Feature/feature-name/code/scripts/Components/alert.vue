<template>
  <div>
    <strong>
      <p class="alert" :class="cssClass" v-html="messages"></p>
    </strong>
  </div>
</template>
<script>
export default {
  name: 'alert',
  props: {
    message: {
      type: String,
      required: true
    },
    cssClass: {
      type: String,
      default: 'alert-success'
    }
  },
  data() {
    return {
      messages: this.message
    }
  }
};

</script>