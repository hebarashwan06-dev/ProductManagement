<template>
   
    <div class="list-section">
      <h2>Product List</h2>
      
      <table>
        <thead>
          <tr>
            <th>Name</th>
            <th>Price</th>
            <th>Description</th>
            <th>Actions</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="product in products" :key="product.id">
            <td>{{ product.name }}</td>
            <td>{{ product.price }}</td>
            <td>${{ product.description}}</td>
            <td class="actions">
              <button @click="editProduct(product.id)" class="btn-edit">Edit</button>
              <button @click="deleteProduct(product.id)" class="btn-delete">Delete</button>
            </td>
          </tr>
        </tbody>
      </table>
      
    </div>
 
</template>


<script>
import axios from 'axios'
export default {
  name: 'ProductList',
  created(){
    this.getProducts()
  },
  data(){
    return {
      products:[],
      product:{
        id:"",
        name:"",
        description:"",
        price:0
      }
    }
  },

  methods:{
    getProducts(){
      axios.get('https://localhost:44338/api/Product')
        .then((response)=>{
          this.products=response.data
        })
     },


    deleteProduct(id){
      axios.delete('https://localhost:44338/api/Product/'+id)
        .then(()=>{
          this.getProducts();
        })
      },

    editProduct(id){
      axios.get('https://localhost:44338/api/Product/'+id)
        .then((response)=>{
          this.product=response.data
        })
       
    }
  }
  
}
</script>

<style scoped>

table {
  width: 100%;
  border-collapse: collapse;
}
th, td {
  border: 1px solid #ddd;
  padding: 8px;
  text-align: left;
}
th {
  background-color: #f4f4f4;
}

</style>
