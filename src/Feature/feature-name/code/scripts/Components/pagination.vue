<template>        
  <ul class="pagination">
    <li v-for="x in paginationDatas">{{x}}</li>
  </ul>
</template>
<script>
export default {
  name: 'custom-pagination',
  data() {
    return {
      paginationDatas: [1,2,3,4,5,6,7,8,9]
    }
  }
};

</script>