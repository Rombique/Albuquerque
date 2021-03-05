import Vue from 'vue'
import App from './App.vue'
import VueRouter from 'vue-router'
import 'siimple'
import Home from '@/views/Home'
import Create from '@/views/Create'

const router = new VueRouter({
  mode: 'history',
  base: __dirname,
  routes:[
    { path: '/', name: 'Home', component: Home },
    { path: '/create', name: 'Create', component: Create },
  ]
});

Vue.use(VueRouter)

Vue.config.productionTip = false

new Vue({
  router,
  render: h => h(App),
}).$mount('#app')
