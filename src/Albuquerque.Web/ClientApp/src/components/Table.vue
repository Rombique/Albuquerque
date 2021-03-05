<template>
  <div class="siimple-grid-row siimple--mt-2">
    <div class="siimple-grid-col siimple-grid-col--6">
      <div class="siimple-table">
        <div class="siimple-table-header">
          <div class="siimple-table-row">
            <div class="siimple-table-cell">#</div>
            <div class="siimple-table-cell">NUMBER</div>
            <div class="siimple-table-cell">DATE_CREATED</div>
            <div class="siimple-table-cell">DATE_DEADLINE</div>
            <div class="siimple-table-cell">IS_DONE</div>
            <div class="siimple-table-cell">PLUS_TIME</div>
          </div>
        </div>
        <div class="siimple-table-body">
          <div class="siimple-table-row siimple-table-row--success">
            <div class="siimple-table-cell">1</div>
            <div class="siimple-table-cell">123</div>
            <div class="siimple-table-cell">15.12.2020</div>
            <div class="siimple-table-cell">15.12.2021</div>
            <div class="siimple-table-cell">ДА</div>
            <div class="siimple-table-cell"><button v-on:click="isSmile = !isSmile" class="siimple-btn siimple-btn--primary">+2</button></div>
          </div>
          <div class="siimple-table-row siimple-table-row--warning">
            <div class="siimple-table-cell">1</div>
            <div class="siimple-table-cell">123</div>
            <div class="siimple-table-cell">15.12.2020</div>
            <div class="siimple-table-cell">15.12.2021</div>
            <div class="siimple-table-cell">ДА</div>
            <div class="siimple-table-cell"><button class="siimple-btn siimple-btn--primary">+2</button></div>
          </div>
          <div class="siimple-table-row siimple-table-row--error">
            <div class="siimple-table-cell">1</div>
            <div class="siimple-table-cell">123</div>
            <div class="siimple-table-cell">15.12.2020</div>
            <div class="siimple-table-cell">15.12.2021</div>
            <div class="siimple-table-cell">ДА</div>
            <div class="siimple-table-cell"><button class="siimple-btn siimple-btn--primary">+2</button></div>
          </div>
          <div class="siimple-table-row siimple-table-row--warning">
            <div class="siimple-table-cell">1</div>
            <div class="siimple-table-cell">123</div>
            <div class="siimple-table-cell">15.12.2020</div>
            <div class="siimple-table-cell">15.12.2021</div>
            <div class="siimple-table-cell">ДА</div>
            <div class="siimple-table-cell"><button class="siimple-btn siimple-btn--primary">+2</button></div>
          </div>
        </div>
      </div>
    </div>
    <div class="siimple-grid-col siimple-grid-col--6">
      <div class="siimple-alert siimple-alert--primary">
        Lorem ipsum dolor sit amet, consectetur adipiscing elit...
      </div>
      <div class="siimple-alert siimple-alert--success">
        Lorem ipsum dolor sit amet, consectetur adipiscing elit...
      </div>
    </div>
    <transition name="bounce">
      <img v-show="isSmile" class="smile" src="@/assets/smile.jpg"/>
    </transition>
  </div>
</template>

<script>
export default {
  name: "Table",
  data: function() {
    return {
      isSmile: false
    }
  },
  computed: {
    
  }
}
</script>

<style scoped>
.bounce-enter-active {
  animation: bounce-in .5s;
}
.bounce-leave-active {
  animation: bounce-in .5s reverse;
}
@keyframes bounce-in {
  0% {
    transform: scale(0);
  }
  50% {
    transform: scale(1.5);
  }
  100% {
    transform: scale(1);
  }
}

.smile {
  position: absolute;
  width: 256px;
  height: 256px;
  right: 50px;
  bottom: 50px;
}
</style>