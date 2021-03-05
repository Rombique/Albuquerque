<template>
  <div id="home">
    <template v-if="currentTab == 'dashboard'">
      <MainButtons/>
      <Table/>
    </template>
    <template v-else>
      asdsad
    </template>
  </div>
</template>

<script>
import Table from '@/components/Table'
import MainButtons from '@/components/MainButtons'

export default {
  name: 'Home',
  data: function() {
    return {
      isDashboard: true
    }
  },
  components: {
    Table,
    MainButtons
  },
  computed: {
    currentTab: function () {
      return this.$store.state.currentTab;
    },
    isLoading: function () {
      return this.$store.state.isLoading;
    }
  }
}
</script>

<style scoped>

</style>