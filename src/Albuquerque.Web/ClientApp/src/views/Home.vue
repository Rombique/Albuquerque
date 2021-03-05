<template>
  <div id="home">
    <Search/>
    <MainButtons/>
    <Table/>
  </div>
</template>

<script>
import Table from "@/components/Table"
import MainButtons from "@/components/MainButtons"
import Search from "@/components/Search"

export default {
  name: "Home",
  components: {
    Table,
    MainButtons,
    Search
  }
}
</script>

<style scoped>

</style>