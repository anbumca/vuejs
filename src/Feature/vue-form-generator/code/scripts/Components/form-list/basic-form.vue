<template>
	<div class="container" id="app">
    <div class="panel panel-default">
      <div class="panel-heading">Form</div>
      <div class="panel-body">
        <form-generator :schema="schema" :model="model" :options="formOptions"></form-generator>
      </div>
    </div> 

    <div class="panel panel-default">
      <div class="panel-heading">Model</div>
      <div class="panel-body">
        <pre v-if="model" v-html="prettyJSON(model)"></pre>
      </div>
    </div>

  </div>
</template>

<script>

export default {
	methods: {
		prettyJSON: function(json) {
			if (json) {
				json = JSON.stringify(json, undefined, 4);
				json = json.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
				return json.replace(/("(\\u[a-zA-Z0-9]{4}|\\[^u]|[^\\"])*"(\s*:)?|\b(true|false|null)\b|-?\d+(?:\.\d*)?(?:[eE][+\-]?\d+)?)/g, function (match) {
					var cls = "number";
					if (/^"/.test(match)) {
						if (/:$/.test(match)) {
							cls = "key";
						} else {
							cls = "string";
						}
					} else if (/true|false/.test(match)) {
						cls = "boolean";
					} else if (/null/.test(match)) {
						cls = "null";
					}
					return "<span class=\"" + cls + "\">" + match + "</span>";
				});
			}
		}
	},
  data() {
    return {
      
		model: {
			id: 1,
			name: "karthikeyan",
			password: "Photon@123",
			skills: [
				"Javascript",
				"VueJS"
			],
			email: "karthikeyan.mn@photon.in",
			status: true
		},
		schema: {
			fields: [
				{
					type: "input",
					inputType: "text",
					label: "ID",
					model: "id",
					readonly: true,
					featured: false,
					disabled: true
				},
				{
					type: "input",
					inputType: "text",
					label: "Name",
					model: "name",
					readonly: false,
					featured: true,
					required: true,
					disabled: false,
					placeholder: "User's name"
				},
				{
					type: "input",
					inputType: "password",
					label: "Password",
					model: "password",
					min: 6,
					required: true,
					hint: "Minimum 6 characters"
				},	
				{
					type: "input",
					inputType: "email",
					label: "E-mail",
					model: "email",
					placeholder: "User's e-mail address"
				},					
				{
					type: "checklist",
					label: "Skills",
					model: "skills",
					required: true,
					values: [
						"HTML5",
						"Javascript",
						"CSS3",
						"CoffeeScript",
						"AngularJS",
						"ReactJS",
						"VueJS"
					]
				},
				{
					type: "checkbox",
					label: "Status",
					model: "status",
					multi: true,
					readonly: false,
					featured: false,
					disabled: false,
					default: true
				}			
			]
		},

		formOptions: {
			validateAfterLoad: true,
			validateAfterChanged: true
		}
    }
  }
};
</script>

<style lang="scss">
@import url(http://fonts.googleapis.com/css?family=Open+Sans:400,300,600,700|Open+Sans+Condensed:300&subset=latin,latin-ext);
html {
	font-family: "Open Sans";
	font-size: 14px;
}

* {
	-moz-box-sizing: border-box;
	-webkit-box-sizing: border-box;
	box-sizing: border-box;
}

pre {
	overflow: auto;

	.string {
		color: #885800;
	}
	.number {
		color: blue;
	}
	.boolean {
		color: magenta;
	}
	.null {
		color: red;
	}
	.key {
		color: green;
	}
}

.control-buttons {
	button {
		margin: 0.2em 0.3em;
		padding: 6px 20px;
		position: relative;

		i {
			margin-right: 0.3em;
		}
	}

	i.fa.fa-warning {
		position: absolute;
		top: 0px;
		right: 0px;
		color: Orange;
	}
}

.errors {
	.alert {
		padding: 4px;
		width: 80%;
		margin: 5px auto;
	}
}

fieldset.vue-form-generator {
	.form-group.half-width {
		width: 50%;
	}

	.half-width + .half-width {
		&:not(.first) {
			padding-left: 0.5rem;
		}
	}
}

</style>
