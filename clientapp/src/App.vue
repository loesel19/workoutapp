<template>
  
    <v-layout>
      <v-navigation-drawer
        expand-on-hover
        rail
      >
        <v-list>
          <v-list-item
            prepend-avatar="./assets/boardpic.png"
            title="John Doe"
            subtitle="whoisjohndoe@gmail.com"
          ></v-list-item>
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
      </v-main>
    </v-layout>
    
  
  
</template>

<script setup>
import router from './router';

  //
  function goHome() {
    router.push('/')
  }
  function goWorkout() {
    router.push('/workout')
  }
</script>
