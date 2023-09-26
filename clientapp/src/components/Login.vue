<template>
  <v-container class="fill-height">
    <v-responsive class="align-center text-center fill-height">
      <v-row class="d-flex align-center justify-center">
        <v-col>
          <h2 class="text-h2">Login</h2>
        </v-col>
      </v-row>
      <v-row class="d-flex align-center justify-center">
        <v-col>
          <v-text-field label="Username" v-model="User.Username" variant="solo-filled"></v-text-field>
        </v-col>
      </v-row>
      <v-row class="d-flex align-center justify-center">
        <v-col>
          <v-text-field type="password" label="Password" v-model="User.Password" variant="solo-filled"></v-text-field>
        </v-col>
      </v-row>
      <v-row class="d-flex align-center justify-center" style="padding-bottom: 5px;">
        <v-col>
          <v-btn v-on:click="loginClicked">Login</v-btn>
        </v-col>
        <v-col>
          <a href="/register">Register</a>
        </v-col>
      </v-row>
    </v-responsive>
  </v-container>
</template>

<script setup>
//

</script>

<script>
import HttpClient from "@/modules/HttpClient";
import Toast from "@/modules/Toast"
import state from "@/modules/state";

export default {
  mounted(){
    console.log("on login")
  },
  data() {
    return {
      User: {
        Username: "",
        Password: ""
      }
    }
  },
  methods: {
    loginClicked (){
      HttpClient.Post("User/signIn", this.User, (response) => {  
        if(response.isSuccess){
          console.log("user", response.data)
          Toast.Success(response.message)
          state.User = { username: this.User.Username, id: response.data.id }
          console.log(state.User)
        }else{
          Toast.Error(response.message);
        }
      })
    }
  }
}
</script>