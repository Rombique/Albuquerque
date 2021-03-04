<template>
  <div class="container">
    <div class="pure-g">
      <div class="pure-u-1-8"></div>
      <div class="pure-u-3-4">
        <form class="pure-form">
          <fieldset>
            <label>
              <input class="search" type="text"/>
            </label>
          </fieldset>
        </form>
      </div>
      <div class="pure-u-1-8"></div>
    </div>
  </div>
</template>

<script>
export default {
  name: "Search"
}
</script>

<style scoped>
.container {
  padding-top: 5%;
}
.search {
  width: 100%;
}
</style>