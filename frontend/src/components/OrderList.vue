<template>
  <div>
    <el-table stripe :data="orderList" style="margin-bottom: 20px;">
      <el-table-column prop="orderCode" label="Order Code"></el-table-column>
      <el-table-column prop="tradeOrderCode" label="Transaction Code"></el-table-column>
      <el-table-column prop="quantity" label="Quantity"></el-table-column>
      <el-table-column prop="deliverQuantity" label="Deliver Quantity"></el-table-column>
      <el-table-column prop="payWay" label="Payment Method"></el-table-column>
      <el-table-column prop="createTime" label="Order Create Time">
        <template slot-scope="slot">
          <div>{{ convertDate(slot.row.createTime) }}</div>
        </template>
      </el-table-column>
      <el-table-column prop="paidTime" label="Payment Time">
        <template slot-scope="slot">
          <div>{{ convertDate(slot.row.paidTime) }}</div>
        </template>
      </el-table-column>
    </el-table>
    <el-pagination 
    @current-change="handleCurrentChange"
    background 
    layout="prev, pager, next" 
    :total="totalRecords">
</el-pagination>

  </div>
</template>

<script>
import axios from 'axios'
import dayjs from 'dayjs'

export default {
  name: 'OrderList',
  data() {
    return {
      currentPage: 0,
      totalRecords: 0,
      orderList: []
    }
  },
  mounted: function() {
    this.loadData()
  },
  methods: {
    convertDate(createTime) {
      return dayjs(createTime).local().format('YYYY-MMM-DD HH:mm:ss')
    },
    handleCurrentChange(page) {
      this.currentPage = page - 1
      this.loadData()
    },
    loadData() {
      axios.get('/Order/' + this.currentPage).then(response => {
        this.totalRecords = response.data.totalRecords
        this.orderList = response.data.records
      }).catch(error => {
        console.log(error)
      })
    }
  }
}
</script>
