<template>
  <div class="siimple-content siimple-content--extra-large">
    <div class="siimple-grid">
      <Search/>
      <router-view></router-view>
      <div id="notifications">
        <Notification v-for="item in notifications" :key="item.id" :value="item"/>
      </div>
      {{notifications}}
      <button v-on:click="add()">ADD</button>
    </div>
  </div>
</template>

<script>

import Search from '@/components/Search'
import Notification from "@/components/Notification";
export default {
  name: 'App',
  data: function() {
    return {
    }
  },
  components: {
    Notification,
    Search
  },
  computed: {
    notifications: function () {
      return this.$store.state.notifications;
    }
  },
  methods: {
    add: function() {
      this.$store.commit('addNotification',  Date.now())
    }
  },
  created() {

  }
}
</script>

<style>

#notifications {
  position: absolute;
  right: 20px;
  bottom: 10px;
  max-width: 200px;
  min-width: 200px;
}
</style>
