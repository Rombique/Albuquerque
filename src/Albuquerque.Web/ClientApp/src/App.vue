<template>
  <div class="siimple-content siimple-content--extra-large">
    <div class="siimple-grid">
      <Search/>
      <MainButtons/>
      <Table/>
    </div>
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
