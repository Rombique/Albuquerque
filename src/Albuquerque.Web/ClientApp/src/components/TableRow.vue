<template>
  <div class="siimple-table-row" :class="getRowClass">
    <div class="siimple-table-cell">{{index}}</div>
    <div class="siimple-table-cell">{{item.number}}</div>
    <div class="siimple-table-cell">{{item.created}}</div>
    <div class="siimple-table-cell">{{item.deadline}}</div>
    <div class="siimple-table-cell">{{item.is_done ? 'Да' : 'Нет'}}</div>
    <div class="siimple-table-cell">{{item.comments}}</div>
    <div class="siimple-table-cell"><input class="siimple-input hours" value="2" type="number"/><button class="siimple-btn siimple-btn--primary">+</button></div>
  </div>
</template>

<script>
export default {
  props: {
    index: Number,
    item: Object,
  },
  computed: {
    getRowClass: function () {
      const dict = {
        0: 'success',
        1: 'warning',
        2: 'error'
      }
      return 'siimple-table-row--' + dict[this.item.type];
    }
  },
  name: "TableRow"
}
</script>

<style scoped>
.hours {
  width: 50px;
}

button {
  margin-left: 5px;
}
</style>