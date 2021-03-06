<template>
  <div class="siimple-grid-row siimple--mt-1">
    <div class="siimple-grid-col siimple-grid-col--4">
      <div class="siimple-form">
        <div class="siimple-form-title">Создание новой заявки</div>
        <div class="siimple-form-field">
          <div class="siimple-form-field-label">Номер заявки</div>
          <input v-model="number" type="text" class="siimple-input siimple-input--fluid" readonly="readonly">
        </div>
        <div class="siimple-form-field">
          <div class="siimple-form-field-label">Deadline</div>
          <input v-model="deadline" type="datetime-local" class="siimple-input siimple-input--fluid">
        </div>
        <div class="siimple-form-field">
          <div class="siimple-form-field-label">Комментарий</div>
          <textarea v-model="comments" class="siimple-textarea siimple-textarea--fluid" rows="5"></textarea>
        </div>
        <div class="siimple-form-field">
          <div class="siimple-btn siimple-btn--blue" v-on:click="create">Создать</div>
        </div>
        </div>
    </div>
  </div>
</template>

<script>
export default {
  name: 'CreateIssue',
  data: function () {
    return {
      deadline: '',
      comments: ''
    }
  },
  methods: {
    create: function () {
      this.$store.dispatch('createIssue', { deadline: this.deadline, comments: this.comments });
    }
  },
  computed: {
    number: function () {
      return this.$store.state.number;
    }
  }
}
</script>

<style scoped>

</style>