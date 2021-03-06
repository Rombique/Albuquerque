import Vue from 'vue'
import App from './App.vue'
import VueRouter from 'vue-router'
import 'siimple'
import Home from '@/views/Home'
import Vuex from 'vuex'
import axios from 'axios'

Vue.use(Vuex)

const baseUrl = 'https://localhost:5001/api/issues'

const store = new Vuex.Store({
  state: {
    notifications: [{ created: Date.now(), msg: 'Lorem ipsum' }, { created: Date.now(), msg: 'Test' }, { created: Date.now(), msg: 'Test' }],
    issues: [],
    searchResults: [],
    isSearch: false,
    number: '',
    currentTab: 'dashboard',
    isLoading: false
  },
  actions: {
    getAllIssues: function () {
      this.commit('setIsLoading', true);
      axios.get(baseUrl)
          .then(res => this.commit('setIssues', res.data.$values))
          .catch(console.log);
    },
    getRangeIssues: function (state, req) {
      this.commit('setIsLoading', true);
      axios.get(baseUrl, {
        params: { 
          from: req.from,
          to: req.to
        }}).then(res => this.commit('setIssues', res.data.$values))
          .catch(console.log);
    },
    getIssuesByNumber: function (state, req) {
      this.commit('setIsLoading', true);
      axios.get(baseUrl + '/find', {
        params: {
          number: req.number
        }
      }).then(res => this.commit('setSearchResults', res.data.$values))
          .catch(console.log);
    },
    createIssue: function (state, req) {
      axios.post(baseUrl, {
          number: state.state.number,
          deadline: req.deadline,
          comments: req.comments
        }
      ).then(res => {
        this.commit('addIssue', res.data);
        this.commit('setCurrentTab', 'dashboard');
        this.commit('setIsSearch', false);
      })
          .catch(console.log);
    }
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
    },
    setIssues(state, issues) {
      state.issues = [];
      state.isLoading = false;
      state.issues = issues;
    },
    addIssue(state, issue) {
      state.issues.push(issue);
    },
    setSearchResults(state, issues) {
      state.searchResults = [];
      state.isLoading = false;
      state.searchResults = issues;
    },
    clearSearchResults(state) {
      state.searchResults = [];
    },
    setCurrentTab(state, tab) {
      state.currentTab = tab;
    },
    setIsLoading(state) {
      state.isLoading = true;
    },
    setIsSearch(state, value) {
      state.isSearch = value;
    },
    setNumber(state, value) {
      state.number = value;
    }
  }
})

const router = new VueRouter({
  mode: 'history',
  base: __dirname,
  routes:[
    { path: '/', name: 'Home', component: Home }
  ]
});

Vue.use(VueRouter)

Vue.config.productionTip = false

new Vue({
  router,
  store,
  render: h => h(App),
}).$mount('#app')
