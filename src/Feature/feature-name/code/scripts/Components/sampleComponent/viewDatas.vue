<template>
  <div class="static-class-name rfp-mctb">
    {{ datas }}
  </div>
</template>
<script>
export default {
  componentName: 'view-data-component',
  data() {
    return {
      datas: []
    };
  },
  created() {
    window.eventBus.$on('listdatas', (val) => {
      this.datas = val
    });
  }
};

</script>