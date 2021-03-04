<template>
  <div>
    <Search/>
    <MainButtons/>
    <Table/>
  </div>
</template>

<script>
import Search from "@/components/Search"
import MainButtons from "@/components/MainButtons";
import Table from "@/components/Table";

export default {
  name: 'App',
  components: {
    Table,
    MainButtons,
    Search
  }
}
</script>

<style>
</style>
