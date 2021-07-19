<template>
  <div>
    <div class="form-group">
      <label>{{nameLabel}}:</label>
      <input type="text" class="form-control" v-model="form.name">
    </div>
    <div class="form-group">
      <label>{{PasswordLabel}}:</label>
      <input type="password" class="form-control" v-model="form.password">
    </div>
    <div @click="submitData()">
      <custom-button btn-text="sample btn" css-class="btn-default"></custom-button>
    </div>
    {{displayData}}
  </div>
</template>
<script>
import customButton from './button.vue'
export default {
  name: 'custom-form-group',
  component: {
    customButton
  },
  props: {
    nameLabel: {
      type: String,
      required: true
    },
    PasswordLabel: {
      type: String,
      required: true
    }
  },
  data() {
    return {
      form: {
        name: '',
        password: ''
      },
      displayData: {}
    }
  },
  methods: {
    submitData() {
      this.displayData = this.form;
    }
  }
};

</script>