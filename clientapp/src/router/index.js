// Composables
import Toast from '@/modules/Toast'
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

router.beforeEach((to, from, next) => {
  if (to.name === 'login' || to.name === 'register') {
    next()
    return;
  }
  if (!state.User?.username) {
    Toast.Warning("No user signed in.")
    next({ name: 'login'})
  }else{
    next()
  }

})

export default router
