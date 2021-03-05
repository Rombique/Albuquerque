<template>
  <div class="siimple-table-row" :class="getRowClass">
    <div class="siimple-table-cell siimple-table-cell--1">{{item.$id - 1}}</div>
    <div class="siimple-table-cell siimple-table-cell--1">{{item.number}}</div>
    <div class="siimple-table-cell siimple-table-cell--2">{{dateFromObjectId}}</div>
    <div class="siimple-table-cell siimple-table-cell--2">{{new Date(item.deadline).toLocaleString()}}</div>
    <div class="siimple-table-cell siimple-table-cell--1">{{item.is_done ? 'Да' : 'Нет'}}</div>
    <div class="siimple-table-cell siimple-table-cell--3">{{item.comments}}</div>
    <div class="siimple-table-cell siimple-table-cell--1"><input class="siimple-input hours" value="2" type="number"/><button class="siimple-btn siimple-btn--primary">+</button></div>
  </div>
</template>

<script>
import { dateFromObjectId } from '@/helpers';

export default {
  props: {
    index: Number,
    item: Object,
  },
  methods: {
  },
  computed: {
    getRowClass: function () {
      const diff = (new Date(this.item.deadline) - Date.now()) / (1000 * 60);
      let type = '';
      if (diff > 180)
        type = 'success'
      else if (diff > 20)
        type = 'warning'
      else
        type = 'error'
      return 'siimple-table-row--' + type;
    },
    dateFromObjectId: function () {
      return dateFromObjectId(this.item.id).toLocaleString();
    }
  },
  name: 'TableRow'
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