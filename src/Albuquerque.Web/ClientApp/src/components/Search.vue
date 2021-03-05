<template>
  <div class="siimple-grid-row siimple--mt-2">
    <div class="siimple-grid-col siimple-grid-col--12">
      <input v-model="text" v-on:change="search" class="siimple-input search" type="text"/>
    </div>
  </div>
</template>

<script>
export default {
  name: 'Search',
  data: function () {
    return {
      text: '',
    }
  },
  methods: {
    search: function () {
      if (this.text === '') {
        this.$store.commit('setIsSearch', false);
      } else {
        this.$store.dispatch('getIssuesByNumber', { number: this.text });
        this.$store.commit('setIsSearch', true);
      }
    }
  },
}
</script>

<style scoped>
.search {
  width: 100%;
}
</style>