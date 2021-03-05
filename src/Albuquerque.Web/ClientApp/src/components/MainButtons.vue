<template>
  <div class="siimple-grid-row siimple--mt-1">
    <div class="siimple-grid-col siimple-grid-col--6">
      <a class="siimple-btn siimple-btn--primary right-margin" href="#">Все</a>
      <a class="siimple-btn siimple-btn--primary right-margin" href="#">Сегодня</a>
      <a class="siimple-btn siimple-btn--primary" href="#">Завтра</a>
    </div>
    <div class="siimple-grid-col siimple-grid-col--6 range-bar">
      <input type="date" class="siimple-input right-margin" />
      <input type="date" class="siimple-input right-margin" />
      <button class="siimple-btn siimple-btn--primary">Диапазон</button>
    </div>
  </div>
</template>

<script>
export default {
  name: "MainButtons"
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