<template>

<div class="wrapper" v-attributes="'wrapper'">
  <input class="form-control" :id="getFieldID(schema)" type="file" :name="schema.inputName" @change="onChange" :accept="schema.accept" :multiple="schema.multiple" :placeholder="schema.placeholder" :readonly="schema.readonly" :required="schema.required" :disabled="disabled" v-attributes="'input'">
</div>
</template>

<script>
import abstractField from "../abstractField";
import { isFunction } from "lodash";

export default {
	name: "fieldUpload",
	mixins: [abstractField],
	methods: {
		onChange($event){
			if (isFunction(this.schema.onChanged)) {
				// Schema has defined onChange method.
				this.schema.onChanged.call(this, this.model, this.schema, $event, this);
			}
		}
	}
};
</script>

<style lang="scss">
.vue-form-generator .field-input {
	.wrapper {
		width: 100%;
	}
	.helper {
		margin: auto 0.5em;
	}
}
</style>
