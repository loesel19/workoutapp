<template>
  <v-container class="" style="margin-top:10px">
    <v-row justify="center">
      <v-col-auto>
        <h3 class="text-h2 ">Track your progress with this data table</h3>
      </v-col-auto>
    </v-row>
    <v-row justify="end">
      <v-col-auto justify="end">
        <v-sheet class="pa-2 ma-2">
          <v-col cols="auto">
            <v-dialog transition="dialog-top-transition" width="auto">
              <template v-slot:activator="{ props }">
                <v-btn v-bind="props"><span class="mdi mdi-plus">Add New Set</span></v-btn>
              </template>
              <template v-slot:default="{ isActive }">
                <v-card min-width="400px" min-height="300px">
                  <v-toolbar title="Add New Set"></v-toolbar>
                  <v-card>
                    <v-container>
                      <v-row>
                        <v-col>
                          <v-select label="Category" :items="['Push', 'Pull', 'Legs']"></v-select>
                        </v-col>
                        <v-col>
                          <v-text-field label="Exercise Name"></v-text-field>
                        </v-col>
                      </v-row>
                      <v-row>
                        <v-col>
                          <v-text-field type="number" label="Weight(lbs)"></v-text-field>
                        </v-col>
                        <v-col>
                          <v-text-field type="number" label="Repetitions"></v-text-field>
                        </v-col>
                      </v-row>
                      <v-row>
                        <v-col>
                          <v-date-picker title="" header="Enter Date" input-mode="keyboard" hide-actions="true"></v-date-picker>
                        </v-col>
                      </v-row>
                    </v-container>

                  </v-card>
                  <v-card-actions class="justify-end">
                    <v-btn variant="text" @click="isActive.value = false">Close</v-btn>
                  </v-card-actions>
                </v-card>
              </template>
            </v-dialog>
          </v-col>
        </v-sheet>
      </v-col-auto>
      <v-col-auto>
        <v-sheet class="pa-2 ma-2">

        </v-sheet>
      </v-col-auto>
    </v-row>
    <v-row>
      <v-responsive class="align-center text-center fill-height">

        <v-data-table v-model:items-per-page="itemsPerPage" :headers="headers" :items="items" item-value="name"
          class="elevation-1"></v-data-table>

      </v-responsive>
    </v-row>
  </v-container>
</template>

<script setup>
//
import { VDataTable } from 'vuetify/labs/VDataTable';
import { VDatePicker} from "vuetify/labs/VDatePicker"
import axios from "axios";
</script>

<script>
export default {
  mounted(){
     axios({
      method: 'get',
      url: 'https://localhost:7248/set/1',
      
     })
     .then(function(response){
      console.log(response)
     })
  },
  data() {
    return {
      itemsPerPage: 5,
      headers: [
        {
          title: 'Exercise',
          align: 'start',
          sortable: true,
          key: 'exercise',
        },
        { title: 'Weight (lbs)', align: 'end', key: 'weight' },
        { title: 'Repetitions', align: 'end', key: 'reps' },
        { title: 'Date', align: 'end', key: 'date' },
      ],
      items: [
        {
          exercise: 'Bench',
          weight: 165,
          reps: 6,
          date: '2023-08-01'
        },
        {
          exercise: 'Bench',
          weight: 175,
          reps: 5,
          date: '2023-08-01'
        },
        {
          exercise: 'Bench',
          weight: 185,
          reps: 3,
          date: '2023-08-01'
        },
        {
          exercise: 'Chest Flys',
          weight: 50,
          reps: 10,
          date: '2023-08-01'
        },
        {
          exercise: 'Chest Flys',
          weight: 60,
          reps: 8,
          date: '2023-08-01'
        },
        {
          exercise: 'Chest Flys',
          weight: 60,
          reps: 8,
          date: '2023-08-01'
        },
        {
          exercise: 'Tricep Extentions',
          weight: 100,
          reps: 14,
          date: '2023-08-01'
        },
        {
          exercise: 'Tricep Extentions',
          weight: 110,
          reps: 12,
          date: '2023-08-01'
        },
        {
          exercise: 'Tricep Extentions',
          weight: 120,
          reps: 12,
          date: '2023-08-01'
        },
        {
          exercise: 'Pulldown',
          weight: 120,
          reps: 12,
          date: '2023-08-04'
        },
        {
          exercise: 'Pulldown',
          weight: 160,
          reps: 10,
          date: '2023-08-04'
        },
        {
          exercise: 'Pulldown',
          weight: 180,
          reps: 7,
          date: '2023-08-04'
        },
        {
          exercise: 'Pullback',
          weight: 140,
          reps: 12,
          date: '2023-08-04'
        },
        {
          exercise: 'Pullback',
          weight: 160,
          reps: 10,
          date: '2023-08-04'
        },
        {
          exercise: 'Pullback',
          weight: 170,
          reps: 6,
          date: '2023-08-04'
        },
      ],
    }
  },
}
</script>