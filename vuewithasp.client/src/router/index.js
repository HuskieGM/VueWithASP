import { createRouter, createWebHistory } from 'vue-router';
import HelloWorld from '../components/HelloWorld.vue';
import TheWelcome from '../components/TheWelcome.vue';
import Company from '../components/Company.vue';

const routes = [
    {
        path: '/',
        name: 'Home',
        component: HelloWorld
    },
    {
        path: '/welcome',
        name: 'Welcome',
        component: TheWelcome
    },
    {
        path: '/company',
        name: 'Company',
        component: Company
    }
];

const router = createRouter({
    history: createWebHistory(),
    routes
});

export default router;
