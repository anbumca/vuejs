<template>
  <div class="dropdown">
    <button class="btn btn-primary dropdown-toggle" @click="enableDisable" type="button" data-toggle="dropdown">{{btnText}}
    <span class="caret"></span></button>
    <ul v-if="dropdownProperty">
      <li v-for="x in datas"><a :href="x.urls">{{x.displayMessage}}</a></li>
    </ul>
  </div>
</template>
<script>
export default {
  name: 'custom-dropdown',
  props: {
    btnText: {
      type: String,
      required: true
    },
    datas: {
      type: Array,
      required: true
    }
  },
  data() {
    return {
      dropdownProperty: false
    }
  },
  methods: {
    enableDisable() {
      if(this.dropdownProperty) {
        this.dropdownProperty = false;
      } else {
        this.dropdownProperty = true;
      }
    }
  }
};

</script>