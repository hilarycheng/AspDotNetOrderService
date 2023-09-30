const { defineConfig } = require('@vue/cli-service')
module.exports = defineConfig({
  transpileDependencies: true,
  devServer: {
    proxy: {
      '^/Order': {
        target: 'http://localhost:5180',
        changeOrigin: true
      }
    }
  }
})
