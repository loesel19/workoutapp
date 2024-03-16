<template>
  <v-container style="margin-top:10px">
    <v-row justify="center">
      <v-col-auto>
        <h3 class="text-h2 ">Analysis of your workouts</h3>
      </v-col-auto>
    </v-row>
    <v-row>
      <v-col style="max-width: 30%; margin-top: 5%">
        <v-row>
          <v-select label="Exercise" :items="exercises" item-value="id" v-model:model-value=exerciseId item-title="name" clearable
            @update:model-value="exerciseChange"></v-select>
        </v-row>
        <v-row>
          <div id="dtpStartDate" hidden>
            <v-date-picker title="" header="Start Date" input-mode="keyboard" hide-actions="false" v-model="startDate"
              required :rules="dateRules" @update:model-value="dateChanged"></v-date-picker>
          </div>
        </v-row>
        <v-row>
          <div id="dtpEndDate" hidden>
            <v-date-picker title="" header="End Date" input-mode="keyboard" hide-actions="false" v-model="endDate"
              required  @update:model-value="dateChanged"></v-date-picker>
          </div>
        </v-row>
      </v-col>
      <v-col>
        <v-responsive class="align-center text-center fill-height">
          <div style="width: 800px;"><canvas id="chartCanvas"></canvas></div>
        </v-responsive>
      </v-col>
      <v-col>
        <v-responsive class="align-center text-center fill-height">
          <v-data-table v-model:items-per-page="itemsPerPage" :headers="headers" :items="displaySets" item-value="name"
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
import { VDatePicker } from "vuetify/labs/VDatePicker"

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
      displaySets: [],
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
      startDate: "",
      endDate: "",
      exerciseId: ""
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
      console.log("exercise change")
      if (exerciseId) {
        document.getElementById("setTable").hidden = false;
        document.getElementById("dtpStartDate").hidden = false;
        document.getElementById("dtpEndDate").hidden = false;
        this.drawGraph(exerciseId)
      } else {
        document.getElementById("setTable").hidden = true;
        document.getElementById("dtpStartDate").hidden = true;
        document.getElementById("dtpEndDate").hidden = true;
        let chartStatus = Chart.getChart("chartCanvas");
        if (chartStatus != undefined) {
          chartStatus.destroy();
        }
      }
    },
    drawGraph(exerciseId) {
      console.log("original", this.sets)
      var startDate = this.startDate && this.startDate != "" ? this.startDate : new Date(0);
      var endDate = this.endDate && this.endDate != "" ? this.endDate : new Date();
      console.log("start: " + startDate.toString() + ", end: " + endDate.toString())
      var filterSets = this.sets.filter(x => x.exerciseId == exerciseId && x.dateTyped >= startDate && x.dateTyped <= endDate)
      console.log("draw sets", filterSets)
      this.displaySets = filterSets;
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
      console.log("get sets")
      HttpClient.Get("set/user/" + state.User.id, (response) => {
        if (!response.isSuccess) {
          Toast.Error(response.message)
          return
        }
        this.sets = response.data
        this.sets.forEach(element => {
          element.dateTyped = Date.parse(element.date)
        });
        this.sets.forEach(element => {
          element.date = element.date.replace("T", " ")
        })
      })
    },
    dateChanged() {
      console.log("date Changed")
      this.drawGraph(this.exerciseId);
    }
  }
}
</script>