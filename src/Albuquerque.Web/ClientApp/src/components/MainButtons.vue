<template>
  <div class="siimple-grid-row siimple--mt-1">
    <div class="siimple-grid-col siimple-grid-col--6">
      <a class="siimple-btn siimple-btn--primary right-margin" v-on:click="getAll" href="#">Все</a>
      <a class="siimple-btn siimple-btn--primary right-margin" v-on:click="getToday" href="#">Сегодня</a>
      <a class="siimple-btn siimple-btn--primary" v-on:click="getTomorrow" href="#">Завтра</a>
    </div>
    <div class="siimple-grid-col siimple-grid-col--6 range-bar">
      <input v-model="from" type="datetime-local" class="siimple-input right-margin" />
      <input v-model="to" type="datetime-local" class="siimple-input right-margin" />
      <button class="siimple-btn siimple-btn--primary" v-on:click="getRange">Диапазон</button>
    </div>
  </div>
</template>

<script>
export default {
  name: 'MainButtons',
  data() {
    return {
      from: '',
      to: ''
    }
  },
  methods: {
    getAll() {
      this.$store.dispatch('getAllIssues');
    },
    getToday() {
      let first = new Date();
      first.setHours(0, 0 ,0 ,0);
      let last = new Date();
      last.setHours(23, 59 ,59 ,999);
      this.$store.dispatch('getRangeIssues', { from: first, to: last });
    },
    getTomorrow() {
      const today = new Date();
      let first = new Date(today);
      first.setDate(first.getDate() + 1)
      first.setHours(0, 0 ,0 ,0);
      let last = new Date(today);
      last.setDate(last.getDate() + 1);
      last.setHours(23, 59 ,59 ,999);
      this.$store.dispatch('getRangeIssues', { from: first, to: last });
    },
    getRange() {
      this.$store.dispatch('getRangeIssues', { from: new Date(this.from), to: new Date(this.to) });
    }
  },
}
</script>

<style scoped>
.range-bar {
  text-align: right;
}
.right-margin {
  margin-right: 5px;
}
</style>