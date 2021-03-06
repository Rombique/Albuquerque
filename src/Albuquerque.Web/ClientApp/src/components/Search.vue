<template>
  <div class="siimple-grid-row siimple--mt-2">
    <div class="siimple-grid-col siimple-grid-col--12">
      <input v-model="text" v-on:keyup.enter="create" v-on:click="inputClass = ''" class="siimple-input search" :class="inputClass" placeholder="SD1234567890" type="text"/>
    </div>
  </div>
</template>

<script>
export default {
  name: 'Search',
  data: function () {
    return {
      text: '',
      inputClass: '',
    }
  },
  watch: {
    text: function (val) {
      if (val === '') {
        this.$store.commit('setIsSearch', false);
        this.inputClass = '';
      } else if (val.toUpperCase().startsWith('SD') && val.length > 2 || val.toUpperCase().startsWith('C') && val.length > 1) {
        this.$store.dispatch('getIssuesByNumber', { number: val });
        this.$store.commit('setIsSearch', true);
        this.inputClass = '';
      } else {
        this.inputClass = 'error';
      }
    }
  },
  methods: {
    create: function () {
      if (this.text.toUpperCase().startsWith('SD') && this.text.length === 12 || this.text.toUpperCase().startsWith('C') && this.text.length ==- 11) {
        this.inputClass = '';
        this.$store.commit('setCurrentTab', 'create');
      } else {
        this.inputClass = 'error';
        this.$store.commit('setCurrentTab', 'dashboard');
      }
    }
  }
}
</script>

<style scoped>
.search {
  width: 100%;
}
.error {
  background-color: lightpink;
}
</style>