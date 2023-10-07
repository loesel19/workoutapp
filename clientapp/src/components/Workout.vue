<template>
  <v-container style="margin-top:10px">
    <v-row justify="center">
      <v-col-auto>
        <h3 class="text-h2 ">Track your progress with this data table</h3>
      </v-col-auto>
    </v-row>
    <v-row>
      <v-col>
        <v-select label="Category" style="max-width: 50%;" :items="categories" item-value="id" item-title="name" clearable @update:model-value="newSetCategoryChange"></v-select>
      </v-col>
      <v-col>
        <v-select label="Exercise" style="max-width: 50%;" :items="exercises" item-value="id" item-title="name" clearable @update:model-value="exerciseChange"></v-select>
      </v-col>
      <v-col cols="auto">
        <v-btn @click="setDialog = true;" style="height: 55px;"><span class="mdi mdi-plus">Add New Set</span></v-btn>
      </v-col>
      <v-col-auto>
        <v-sheet class="pa-2 ma-2">
        </v-sheet>
      </v-col-auto>
    </v-row>
    <v-row>
      <v-responsive class="align-center text-center fill-height">
        <v-data-table v-model:items-per-page="itemsPerPage" :headers="headers" :items="sets" item-value="name"
          class="elevation-1"></v-data-table>
      </v-responsive>
    </v-row>
  </v-container>

  <v-dialog transition="dialog-top-transition" v-model="setDialog" persistent width="auto">
    <template v-slot:default="setDialog">
      <v-form ref="setForm">
        <v-card min-width="400px" min-height="300px">
          <v-toolbar title="Add New Set"></v-toolbar>
          <v-card>
            <v-container>
              <v-row>
                <v-col>
                  <v-select label="Category" @update:model-value="newSetCategoryChange" :items="categories" item-title="name"
                    item-value="id"></v-select>
                </v-col>
                <v-col>
                  <div style="display: flex; justify-content:flex-start;">
                    <v-select label="Exercise Name" :items="exercises" item-title="name" item-value="id"
                      v-model="set.exerciseId" required :rules="exerciseRules"></v-select>
                    <v-btn style="height: 55px;" @click="exerciseDialog = true"><span class="mdi mdi-plus"></span></v-btn>
                  </div>
                </v-col>
              </v-row>
              <v-row>
                <v-col>
                  <v-text-field type="number" label="Weight(lbs)" v-model="set.weight" required
                    :rules="weightRules"></v-text-field>
                </v-col>
                <v-col>
                  <v-text-field type="number" label="Repetitions" v-model="set.repetitions" required
                    :rules="repRules"></v-text-field>
                </v-col>
              </v-row>
              <v-row>
                <v-col>
                  <v-date-picker title="" header="Enter Date" input-mode="keyboard" hide-actions="true" v-model="set.date"
                    required :rules="dateRules"></v-date-picker>
                </v-col>
              </v-row>
            </v-container>
          </v-card>
          <v-card-actions class="justify-end">
            <v-btn variant="text" @click="this.setDialog = false">Close</v-btn>
            <v-btn variant="text" @click="addSetClicked()" ref="addSetButton" :disabled="addSetDisabled">Add</v-btn>
          </v-card-actions>
        </v-card>
      </v-form>
    </template>
  </v-dialog>
  <v-dialog v-model="exerciseDialog" persistent width="auto">
    <v-card min-width="400px" min-height="300px">
      <v-toolbar title="Add New Exercise"></v-toolbar>
      <v-container>
        <v-row>
          <v-col>
            <v-select label="Category" :items="categories" item-title="name" item-value="id" clearable
              v-model="newExercise.categoryId"></v-select>
          </v-col>
          <v-col>
            <v-text-field label="Exercise Name" clearable v-model="newExercise.name"></v-text-field>
          </v-col>
        </v-row>
      </v-container>
      <v-card-actions class="justify-end">
        <v-btn variant="text" @click="exerciseDialog = false">Close</v-btn>
        <v-btn variant="text" @click="addExerciseClick" ref="addExerciseButton">Add</v-btn>
      </v-card-actions>
    </v-card>
  </v-dialog>
</template>

<script setup>
//
import HttpClient from '@/modules/HttpClient';
import Toast from '@/modules/Toast';
import state from '@/modules/state';
import { VDataTable } from 'vuetify/labs/VDataTable';
import { VDatePicker } from "vuetify/labs/VDatePicker"


</script>

<script>
export default {
  mounted() {
    HttpClient.Get("Category", (response) => {
      if (!response.isSuccess) {
        Toast.Error(response.message)
        return;
      }
      this.categories = response.data
      this.getExercises();
      this.getSets();
    });
    
  },
  data() {
    return {
      categories: [],
      exercises: [],
      sets: [],
      originalSets: [],
      exerciseDialog: false,
      setDialog: false,
      set: { date: new Date(), exerciseId: null, repetitions: 0, weight: 0, userId: -1 },
      newExercise: { categoryId: null, name: "" },
      itemsPerPage: 5,
      weightRules: [
        value => {
          if (value && value >= 0) return true

          return 'Weight must be greater than or equal to 0.'
        },
      ],
      repRules: [
        value => {
          if (value && value > 0) return true

          return 'Repitions must be greater than 0.'
        },
      ],
      exerciseRules: [
        value => {
          if (value && value > 0) return true

          return 'Must select an exercise.'
        },
      ],
      dateRules: [
        value => {
          if (value) return true

          return 'Must enter a date.'
        }
      ],
      addSetDisabled: false,
      headers: [
        { title: 'Exercise', align: 'start', sortable: true, key: 'exercise.name' },
        { title: 'Weight (lbs)', align: 'end', key: 'weight' },
        { title: 'Repetitions', align: 'end', key: 'repetitions' },
        { title: 'Date', align: 'end', key: 'date' },
      ],
    }
  },
  methods: {
    newSetCategoryChange(args) {
      this.getExercises(args)
      this.set.exerciseId = null;
    },
    exerciseChange(args){
      if(args){
        this.sets = [...this.originalSets.filter(x => x.exerciseId == args)]
      }else{
        this.sets = [...this.originalSets]
      }
      
    },
    getExercises(categoryId) {
      if (categoryId) {
        HttpClient.Get("exercise/category/" + categoryId, (response) => {
          if (!response.isSuccess) {
            Toast.Error(response.message)
            return;
          }
          this.exercises = response.data;
          console.log("sets for category", [...this.originalSets.filter(x => x.exercise.categoryId == categoryId)])
          this.sets = [...this.originalSets.filter(x => x.exercise.categoryId == categoryId)]
          return;
        })
      }
      HttpClient.Get("exercise", (response) => {
        if (!response.isSuccess) {
          Toast.Error(response.message)
          return;
        }
        this.exercises = response.data
        this.sets = [...this.originalSets]
        return;
      })
    },
    addExerciseClick() {
      if (!this.newExercise.categoryId || !this.newExercise.categoryId > 0) {
        Toast.Warning("Must select a category for new exercise")
        return false;
      }
      if (!this.newExercise.name.length > 0) {
        Toast.Warning("Must provide name for new exercise")
        return false;
      }
      console.log("new exer", this.newExercise)
      HttpClient.Post("exercise", this.newExercise, (response) => {
        if (!response.isSuccess) {
          Toast.Error(response.message)
          return
        }
        Toast.Success(response.message)
        this.getExercises()
        this.set.exerciseId = null
        this.newExercise.categoryId = null
        this.newExercise.name = null
      });
    },
    async addSetClicked() {
      this.addSetDisabled = true
      var form = await this.$refs.setForm.validate()

      if (!form.valid) {
        Toast.Warning("Please ensure that all data is input correctly")
        this.addSetDisabled = false;
        return;
      }
      if (state.User?.id) {
        this.set.userId = state.User.id;
        this.set.addedBy = state.User.id;
      }
      HttpClient.Post("Set", this.set, (response) => {
        if (!response.isSuccess) {
          Toast.Error(response.message)
          this.addSetDisabled = false
          return;
        }
        console.log(response)
        this.addSetDisabled = false
        this.set = { date: new Date(), exerciseId: null, repetitions: 0, weight: 0, userId: -1 }
        Toast.Success(response.message)
        this.setDialog = false
        this.getSets()
        return;
      });


    },
    getSets() {
      HttpClient.Get("set/user/" + state.User.id, (response) => {
        if (!response.isSuccess) {
          Toast.Error(response.message)
          return
        }
        this.sets = response.data
        this.originalSets = [...response.data]
        console.log("sets", response)
      })
    }
  }
}
</script>