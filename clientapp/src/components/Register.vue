<template>
  <v-form ref="form">
    <v-container class="fill-height">
      <v-responsive class="align-center text-center fill-height">
        <v-row class="d-flex align-center justify-center">
          <v-col>
            <h2 class="text-h2">Create Account</h2>
          </v-col>
        </v-row>
        <v-row class="d-flex align-center justify-center">
          <v-col>
            <v-text-field label="Username" v-model="User.Username" variant="solo-filled" :rules="nameRules"
              required></v-text-field>
          </v-col>
        </v-row>
        <v-row class="d-flex align-center justify-center">
          <v-col>
            <v-text-field label="Email" v-model="User.Email" variant="solo-filled" :rules="emailRules"></v-text-field>
          </v-col>
        </v-row>
        <v-row class="d-flex align-center justify-center">
          <v-col>
            <v-text-field type="password" label="Password" v-model="User.Password" variant="solo-filled"
              :rules="passwordRules" required></v-text-field>
          </v-col>
        </v-row>
        <v-row class="d-flex align-center justify-center">
          <v-col>
            <v-text-field type="password" label="Confirm Password" v-model="confirmPassword" variant="solo-filled"
              :rules="passwordRules" required>
            </v-text-field>
          </v-col>
        </v-row>
        <v-row class="d-flex align-center justify-center" style="padding-bottom: 5px;">
          <v-col>
            <v-btn v-on:click="createClicked">Create Account</v-btn>
          </v-col>
        </v-row>
      </v-responsive>
    </v-container>
  </v-form>
</template>

<script setup>
//

</script>

<script>
import HttpClient from "@/modules/HttpClient";
import Toast from "@/modules/Toast"
import router from "@/router";

export default {
  mounted() {
    console.log("on login")
  },
  data() {
    return {
      User: {
        Username: "",
        Email: "",
        Password: ""
      },
      confirmPassword: "",
      nameRules: [
        value => {
          if (value) return true

          return 'Username is required.'
        },
        value => {
          if (value?.length >= 8 && value?.length <= 32) return true

          return 'Username must be between 8 and 32 characters.'
        },
      ],
      emailRules: [
        value => {
          if (/.+@.+\..+/.test(value) || value?.length == 0) return true

          return 'Email must be valid.'
        },
      ],
      passwordRules: [
        value => {
          if (value) return true
          return 'Password is required.'
        },
        value => {
          if (value?.length >= 8 && value?.length <= 32) return true

          return 'Password must be between 8 and 32 characters.'
        }
      ]
    }
  },
  methods: {
    async createClicked() {
      var form = await this.$refs.form.validate()
      var validFlag = true
      if (!form.valid) {
        validFlag = false
      }
      else if (this.User.Password !== this.confirmPassword) {
        Toast.Error("Passwords must match");
        validFlag = false
      }

      if (validFlag) {
        HttpClient.Post('User', this.User, (response) => {
          if (!response.isSuccess) {
            Toast.Error(response.message)
            return;
          }
          Toast.Success(response.message)
          router.push('/')
        });
      }
    }
  }
}
</script>