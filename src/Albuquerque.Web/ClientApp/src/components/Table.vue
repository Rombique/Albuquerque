<template>
  <div class="table">
    <div class="pure-g">
      <div class="pure-u-1-8"></div>
      <div class="pure-u-3-4">
        <table class="pure-table">
          <thead>
          <tr>
            <th>#</th>
            <th>NUMBER</th>
            <th>WARNING_STATE</th>
            <th>DATE_CREATED</th>
            <th>DATE_DEADLINE</th>
            <th>IS_DONE</th>
            <th>PLUS_TIME</th>
          </tr>
          </thead>
          <tbody>
          <tr class="pure-table-odd">
            <td>1</td>
            <td>123
            </td>
            <td><div class="rounded red"></div></td>
            <td>2009</td>
            <td>Accord</td>
            <td>2009</td>
            <td><a class="pure-button pure-button-primary width25" href="#">+2</a></td>
          </tr>
          <tr>
            <td>2</td>
            <td>Toyota</td>
            <td><div class="rounded green"></div></td>
            <td>2012</td>
            <td>Accord</td>
            <td>2009</td>
            <td><a class="pure-button pure-button-primary width25" href="#">+2</a></td>
          </tr>
          <tr class="pure-table-odd">
            <td>3</td>
            <td>Hyundai</td>
            <td><div class="rounded orange"></div></td>
            <td>2010</td>
            <td>Accord</td>
            <td>2009</td>
            <td><a class="pure-button pure-button-primary width25" href="#">+2</a></td>
          </tr>
          <tr>
            <td>4</td>
            <td>Ford</td>
            <td>Focus</td>
            <td>2008</td>
            <td>Accord</td>
            <td>2009</td>
            <td><a class="pure-button pure-button-primary width25" href="#">+2</a></td>
          </tr>
          <tr class="pure-table-odd">
            <td>5</td>
            <td>Nissan</td>
            <td>Sentra</td>
            <td>2011</td>
            <td>Accord</td>
            <td>2009</td>
            <td><a class="pure-button pure-button-primary width25" href="#">+2</a></td>
          </tr>
          <tr>
            <td>6</td>
            <td>BMW</td>
            <td>M3</td>
            <td>2009</td>
            <td>Accord</td>
            <td>2009</td>
            <td><a class="pure-button pure-button-primary width25" href="#">+2</a></td>
          </tr>
          <tr class="pure-table-odd">
            <td>7</td>
            <td>Honda</td>
            <td>Civic</td>
            <td>2010</td>
            <td>Accord</td>
            <td>2009</td>
            <td><a class="pure-button pure-button-primary width25" href="#">+2</a></td>
          </tr>
          <tr>
            <td>8</td>
            <td>Kia</td>
            <td>Soul</td>
            <td>2010</td>
            <td>Accord</td>
            <td>2009</td>
            <td><a class="pure-button pure-button-primary width25" href="#">+2</a></td>
          </tr>
          </tbody>
        </table>
      </div>
      <div class="pure-u-1-8"></div>
    </div>
  </div>
</template>

<script>
export default {
  name: "Table"
}
</script>

<style scoped>
.table {
  padding-top: 5%;
}

table {
  width: 100%;
}

.rounded {
  width: 5px;
  height: 5px;
  border: 5px solid;
  border-radius: 100px;
  margin: auto;
}

.red {
  color: red;
  background-color: red;
}

.orange {
  color: orange;
  background-color: orange;
}

.green {
  color: green;
  background-color: green;
}
</style>