<template>
  <v-layout>
    <v-navigation-drawer expand-on-hover rail>
      <v-list>
        <v-list-item id="user-card" prepend-avatar="./assets/boardpic.png" v-bind:title="this.state.User?.username"
          v-bind:subtitle="this.state.User?.email"></v-list-item>
      </v-list>

      <v-divider></v-divider>

      <v-list density="compact" nav>
        <v-list-item prepend-icon="mdi-home-outline" title="Home" value="home" v-on:click="goHome"></v-list-item>
        <v-list-item prepend-icon="mdi-dumbbell" title="Workout" value="workout" v-on:click="goWorkout"></v-list-item>
        <v-list-item prepend-icon="mdi-poll" title="Analytics" value="analytics"></v-list-item>
      </v-list>
    </v-navigation-drawer>

    <v-main>
      <router-view />
      <div id="snackbar"></div>
    </v-main>
  </v-layout>
</template>

<script setup>
import state from './modules/state';
import router from './router';

//

</script>

<script>
export default {
  data(){
    return{
      state
    }
    
  },
  methods: {
    goHome() {
      router.push('/')
    },
    goWorkout() {
      router.push('/workout')
    }
  }
}

</script>

<style>
#snackbar {
  visibility: hidden;
  /* Hidden by default. Visible on click */
  min-width: 250px;
  /* Set a default minimum width */
  margin-left: -125px;
  /* Divide value of min-width by 2 */
  background-color: #333;
  /* Black background color */
  color: #fff;
  /* White text color */
  text-align: center;
  /* Centered text */
  border-radius: 2px;
  /* Rounded borders */
  padding: 16px;
  /* Padding */
  position: fixed;
  /* Sit on top of the screen */
  z-index: 1;
  /* Add a z-index if needed */
  left: 50%;
  /* Center the snackbar */
  bottom: 30px;
  /* 30px from the bottom */
}

/* Show the snackbar when clicking on a button (class added with JavaScript) */
#snackbar.show {
  visibility: visible;
  /* Show the snackbar */
  /* Add animation: Take 0.5 seconds to fade in and out the snackbar.
  However, delay the fade out process for 2.5 seconds */
  -webkit-animation: fadein 0.5s, fadeout 0.5s 2.5s;
  animation: fadein 0.5s, fadeout 0.5s 2.5s;
}

/* Animations to fade the snackbar in and out */
@-webkit-keyframes fadein {
  from {
    bottom: 0;
    opacity: 0;
  }

  to {
    bottom: 30px;
    opacity: 1;
  }
}

@keyframes fadein {
  from {
    bottom: 0;
    opacity: 0;
  }

  to {
    bottom: 30px;
    opacity: 1;
  }
}

@-webkit-keyframes fadeout {
  from {
    bottom: 30px;
    opacity: 1;
  }

  to {
    bottom: 0;
    opacity: 0;
  }
}

@keyframes fadeout {
  from {
    bottom: 30px;
    opacity: 1;
  }

  to {
    bottom: 0;
    opacity: 0;
  }
}
</style>
