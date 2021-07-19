<template>
  <div class="container">
    <h2>{{headerText}}</h2>          
    <img :src="imageUrl" class="img-thumbnail" alt="Cinque Terre" width="304" height="236"> 
  </div>
</template>
<script>
export default {
  props: {
    headerText: {
      type: String,
      default: 'header'
    },
    imageUrl: {
      type: String,
      required: true
    }
  }
};

</script>