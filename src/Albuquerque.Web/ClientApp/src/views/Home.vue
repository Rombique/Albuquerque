<template>
  <div id="home">
    <MainButtons/>
    <Table/>
  </div>
</template>

<script>
import Table from '@/components/Table'
import MainButtons from '@/components/MainButtons'

export default {
  name: 'Home',
  components: {
    Table,
    MainButtons
  }
}
</script>

<style scoped>

</style>