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
      <v-col>
        <v-responsive class="align-center text-center fill-height">
          <div style="width: 800px;"><canvas id="chartCanvas"></canvas></div>
        </v-responsive>
      </v-col>
      <v-col>
        <v-responsive class="align-center text-center fill-height">
          <v-data-table v-model:items-per-page="itemsPerPage" :headers="headers" :items="currentSets" item-value="name"
            class="elevation-1" id="setTable" hidden></v-data-table>
        </v-responsive>
      </v-col>
    </v-row>

  </v-container>
</template>

<script setup>
//
import HttpClient from '@/modules/HttpClient';
import Toast from '@/modules/Toast';
import state from '@/modules/state';
import Chart from 'chart.js/auto';
import { VDataTable } from 'vuetify/labs/VDataTable';


</script>

<script>
export default {
  mounted() {
    HttpClient.Get('exercise', (response) => {
      if (!response.isSuccess) {
        Toast.Error(response.message)
        return;
      }
      this.exercises = response.data
      this.getSets();
    })

  },
  data() {
    return {
      sets: [],
      currentSets: [],
      categories: [],
      exercises: [],
      currentChart: {},
      itemsPerPage: 10,
      headers: [
        { title: 'Exercise', align: 'start', sortable: true, key: 'exercise.name' },
        { title: 'Weight (lbs)', align: 'end', key: 'weight' },
        { title: 'Repetitions', align: 'end', key: 'repetitions' },
        { title: 'One Rep Max', align: 'center', key: 'oneRepMax' },
        { title: 'Date', align: 'end', key: 'date' },
      ],
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
        console.log(this.sets)
        this.currentSets = [...this.sets.filter(x => x.exerciseId == exerciseId)]
        console.log("curr sets", this.currentSets)
        document.getElementById("setTable").hidden = false;
      } else {
        document.getElementById("setTable").hidden = true;
        let chartStatus = Chart.getChart("chartCanvas");
        if (chartStatus != undefined) {
          chartStatus.destroy();
        }
      }
    },
    drawGraph(exerciseId) {
      var filterSets = [...this.sets.filter(x => x.exerciseId == exerciseId)]
      if (!filterSets || filterSets.length < 2) {
        Toast.Warning("Not enough data to draw graph for exercise")
        return;
      }
      let exerciseName = filterSets[0].exercise.name
      let chartStatus = Chart.getChart("chartCanvas");
      if (chartStatus != undefined) {
        chartStatus.destroy();
      }
      this.currentChart = new Chart(
        document.getElementById('chartCanvas'),
        {
          type: 'line',
          data: {
            labels: filterSets.map(row => new Date(row.dateTyped).toString().split("GMT")[0].substring(4, 15)),
            datasets: [
              {
                label: exerciseName,
                data: filterSets.map(row => row.oneRepMax)
              }
            ]
          },
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
        this.sets.forEach(element => {
          element.dateTyped = Date.parse(element.date)
        });
        console.log("sets", this.sets)
      })
    }
  }
}
</script>