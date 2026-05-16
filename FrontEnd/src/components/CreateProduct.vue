<template>
<div class="form-container">
    <form @submit.prevent="saveProduct">
        <div class="form-group">
          <label for="name">Product Name:</label>
          <input type="text" required id="name" v-model="formData.name" />
        </div>
        <div class="form-group">
          <label for="price">Price:</label>
          <input type="number" id="price" v-model="formData.price"/>
        </div>

        <div class="form-group">
          <label for="description">Description:</label>
          <textarea 
          id="description"
          v-model="formData.description" 
          rows="5" 
          required
        ></textarea>
        </div>

        <div class="actions">
          <button type="submit" class="btn-save">Save</button>
        </div>
      </form>
</div>
    
</template>

<script>
import axios from 'axios'

export default {
  name: 'CreateProduct',
  data(){
    return{
        formData:{
            name:'',
            price:'',
            description:''
        }
    }
  },

  methods:{
    saveProduct(){
      axios.post('https://localhost:44338/api/Product',this.formData)
     
    }
  }
  
}
</script>

<style scoped>
.form-container {
  max-width: 400px;
  margin: 2rem auto;
  padding: 20px;
  border-radius: 8px;
  background-color: #f9f9f9;
  box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
}

.form-group {
  margin-bottom: 15px;
}

label {
  display: block;
  margin-bottom: 5px;
  font-weight: bold;
}

input,
textarea {
  width: 100%;
  padding: 12px;
  border: 1px solid #cccccc;
  border-radius: 6px;
  box-sizing: border-box; /* Ensures padding doesn't affect width */
  font-family: inherit;
  transition: border-color 0.3s ease;
}

.submit-btn {
  width: 100%;
  padding: 10px;
  background-color: #42b883; /* Vue brand green */
  color: white;
  border: none;
  border-radius: 4px;
  cursor: pointer;
}
</style>
