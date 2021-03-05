import Vue from 'vue'
import App from './App.vue'
import VueRouter from 'vue-router'
import 'siimple'
import Home from '@/views/Home'
import Create from '@/views/Create'
import Vuex from 'vuex'

Vue.use(Vuex)

const store = new Vuex.Store({
  state: {
    notifications: [{ created: Date.now(), msg: 'Lorem ipsum' }, { created: Date.now(), msg: 'Test' }, { created: Date.now(), msg: 'Test' }]
  },
  mutations: {
    addNotification (state, msg) {
      const notification = {
        created: Date.now(),
        msg: msg,
      }
      state.notifications.push(notification);
    },
    removeNotification(state, created) {
      state.notifications = state.notifications.filter(p => p.created !== created);
    }
  },
  computed: {
    notifications() {
      return this.state.notification;
    }
  }
})

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
  store,
  render: h => h(App),
}).$mount('#app')
