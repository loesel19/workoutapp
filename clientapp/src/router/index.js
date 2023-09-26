// Composables
import state from '@/modules/state'
import { createRouter, createWebHistory } from 'vue-router'

const routes = [
  {
    path: '/',
    component: () => import('@/components/HomePage.vue')
  },
  {
    path: '/workout',
    component: () => import('@/components/Workout.vue')

  },
  {
    name: 'login',
    path: '/login',
    component: () => import('@/components/Login.vue')
  },
  {
    name: 'register',
    path: '/register',
    component: () => import('@/components/Register.vue')
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes,
})

// router.beforeEach((to, from, next) => {
//   if (to.name === 'login') {
//     return;
//   }
//   if (!state.User?.Username) {
//     //next({ name: 'login' })
//   }

// })

export default router
