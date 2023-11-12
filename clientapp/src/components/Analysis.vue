<template>
  <v-container style="margin-top:10px">
    <v-row justify="center">
      <v-col-auto>
        <h3 class="text-h2 ">Analysis of your workouts</h3>
      </v-col-auto>
    </v-row>

    <v-row justify="center">

      <v-col>
        <v-select label="Exercise" style="max-width: 25%;" :items="exercises" item-value="id" item-title="name" clearable
          @update:model-value="exerciseChange"></v-select>
      </v-col>
    </v-row>
    <v-row>
      <v-responsive class="align-center text-center fill-height">
        <div style="width: 800px;"><canvas id="chartCanvas"></canvas></div>
      </v-responsive>
    </v-row>

  </v-container>
</template>

<script setup>
//
import HttpClient from '@/modules/HttpClient';
import Toast from '@/modules/Toast';
import state from '@/modules/state';
import Chart from 'chart.js/auto'


</script>

<script>
export default {
  mounted() {
    this.getExercises();
    this.getSets()
  },
  data() {
    return {
      sets: [],
      categories: [],
      exercises: [],
      currentChart: {}
    }
  },
  methods: {
    getExercises() {
      HttpClient.Get('exercise', (response) => {
        if (!response.isSuccess) {
          Toast.Error(response.message)
          return;
        }
        this.exercises = response.data
      })
    },
    exerciseChange(exerciseId) {
      if (exerciseId) {
        this.drawGraph(exerciseId)
      }
    },
    drawGraph(exerciseId) {
      var filterSets = [...this.sets.filter(x => x.exerciseId == exerciseId)]
      console.log("filtersets", filterSets)
      console.log("sets", this.sets)
      if (!filterSets || filterSets.length < 2) {
        Toast.Warning("Not enough data to draw graph for exercise")
        return;
      }
      let exerciseName = filterSets[0].exercise.name
      let chartStatus = Chart.getChart("chartCanvas"); // <canvas> id
      if (chartStatus != undefined) {
        chartStatus.destroy();
      }
      this.currentChart = new Chart(
        document.getElementById('chartCanvas'),
        {
          type: 'line',
          data: {
            labels: filterSets.map(row => row.date),
            datasets: [
              {
                label: exerciseName,
                data: filterSets.map(row => row.oneRepMax)
              }
            ]
          }
        }
      );
    },
    getSets() {
      HttpClient.Get("set/user/" + state.User.id, (response) => {
        if (!response.isSuccess) {
          Toast.Error(response.message)
          return
        }
        this.sets = response.data
      })
    }
  },

}
</script>