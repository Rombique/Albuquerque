<template>
  <div class="notification siimple-grid-col siimple-grid-col--12">
    <div class="siimple-alert siimple-alert--error">
      <div class="siimple-alert-close" v-on:click="close()"></div>
        {{value.msg}}
    </div>
  </div>
</template>

<script>
export default {
  props: ["value"],
  name: "Notification",
  methods: {
    close: function()  {
      this.$store.commit('removeNotification', this.value.created);
    }
  }
}
</script>

<style scoped>

</style>