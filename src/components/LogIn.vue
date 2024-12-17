<template>
    <h2>Login</h2>
    <el-input v-model="email" placeholder="Email" />
    <el-input v-model="password" placeholder="Please input" />
    <el-button v-on:click="login" type="primary">Primary</el-button>
    
</template>

<script lang="js">
    import { defineComponent } from 'vue';
    import axios from 'axios'

    export default defineComponent({
        data() {
            return {
                loading: false,
                post: null,
                email:null,
                password:null,
            };
        },
        created() {
            // fetch the data when the view is created and the data is
            // already being observed
            
        },
        watch: {
            // call again the method if the route changes
            '$route': 'fetchData'
        },
        methods: {
            login() {
                let self = this;
                axios.post('Customers/login', {
                    email: this.email,
                    password: this.password
                  })
                    .then(function (response) {
                        if (response.status == 200) {
                            self.$router.push('/dashboard');
                        }
                   
                  })
                  .catch(function (error) {
                    console.log(error);
                  });

            },
           
        },
    });
</script>