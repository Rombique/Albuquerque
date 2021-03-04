<template>
  <div class="buttons">
    <div class="pure-g">
      <div class="pure-u-1-8"></div>
      <div class="pure-u-3-4">
        <div class="pure-u-1-2">
          <button class="button-large pure-button pure-button-primary right-margin" href="#">Все</button>
          <button class="pure-button pure-button-primary button-large right-margin" href="#">Сегодня</button>
          <button class="pure-button pure-button-primary button-large" href="#">Завтра</button>
        </div>
        <div class="pure-u-1-2">
          <form class="pure-form right-bar">
            <label>
              <input class="right-margin" type="date" placeholder="" />
            </label>
            <label>
              <input class="right-margin" type="date" placeholder="" />
            </label>
            <button type="submit" class="pure-button pure-button-primary button-large">Диапазон</button>
          </form>
        </div>
        
      </div>
      <div class="pure-u-1-8"></div>
    </div>
  </div>
</template>

<script>
export default {
  name: "MainButtons"
}
</script>

<style scoped>
.buttons {
  padding-top: 20px;
}

.button-large {
  font-size: 110% !important;
}

.right-bar {
  float: right;
}

.right-margin {
  margin-right: 5px;
}
</style>