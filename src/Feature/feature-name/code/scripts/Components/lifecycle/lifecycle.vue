<template>
  <div id='div1' v-bind:title="div_title">
    {{title}}
    {{hello_message}}
  </div>
</template>
<script>
export default {
  name: 'lifecycle',
  props: {
    title: {
      type: String,
      required: false
    }
  },
  data() {
    return {
      hello_message: "Hello, there welcome to VueJS world",
      div_title: "This is my intro div"
    };
  },
  methods: {
    getdatas() {
      console.log('sample function');
    }
  },
  beforeCreate() { 
    console.log('Before Create');
  },
  created() { 
    console.log('Created');
  },
  beforeMount() { 
    console.log('Before Mount');
  },
  mounted() { 
    console.log('Mounted');
  },
  beforeUpdate() { 
    console.log('Before Update');
  },
  updated() { 
    console.log('Updated');
  },
  beforeDestroy() { 
    console.log('Before Destroy');
  },
  destroyed() { 
    console.log('Destroyed');
  }
};

</script>