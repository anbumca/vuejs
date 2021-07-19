<template>
  <div class="container">         
    <table class="table">
      <thead>
        <tr>
          <th>{{postId}}</th>
          <th>{{title}}</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="x in datas">
          <td>{{x.id}}</td>
          <td>{{x.title}}</td>
        </tr>
      </tbody>
    </table>
  </div>
</template>
<script>
export default {
  name: 'custom-list',
  props: {
    postId: {
      type: String,
      required: true
    },
    title: {
      type: String,
      required: true
    }
  },
  data() {
    return {
      datas: []
    }
  },
  methods: {
    getdatas() {
      fetch('https://jsonplaceholder.typicode.com/posts')
      .then(response => response.json())
      .then(json => this.datas = json)
    }
  },
  created() {
    this.getdatas();
  }
};

</script>