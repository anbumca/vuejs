<template>
  <div class="static-class-name rfp-mctb">
    <div>{{title}}</div>
    <div>{{data}}</div>
  </div>
</template>
<script>
export default {
  name: 'sampleComponent',
  props: {
    data: {
      type: String,
      required: false
    },
    title: {
      type: String,
      required: false
    }
  },
  data() {
    return {
      datas: []
    };
  }
};

</script>