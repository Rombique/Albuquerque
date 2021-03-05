<template>
  <div class="siimple-grid-row siimple--mt-2">
    <div class="siimple-grid-col siimple-grid-col--12">
      <div class="siimple-table">
        <div class="siimple-table-header">
          <div class="siimple-table-row">
            <div class="siimple-table-cell siimple-table-cell--1">#</div>
            <div class="siimple-table-cell">Номер</div>
            <div class="siimple-table-cell">Создан</div>
            <div class="siimple-table-cell">Deadline</div>
            <div class="siimple-table-cell">Исполнен</div>
            <div class="siimple-table-cell">Комментарий</div>
            <div class="siimple-table-cell"></div>
          </div>
        </div>
        <div class="siimple-table-body">
          <TableRow v-for="(item, index) in issues" :item="item" :key="index"/>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import TableRow from '@/components/TableRow'

export default {
  name: "Table",
  components: {TableRow},
  data: function() {
    return {
      item: {
        number: '123123',
        created: '15-12-1990',
        deadline: '12-12-2021',
        is_done: 1,
        type: 0
      }
    }
  },
  computed: {
    issues: function () {
      return this.$store.state.issues;
    }
  },
  created() {
  }
}
</script>

<style scoped>

</style>