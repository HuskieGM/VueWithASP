<script setup>
    import { RouterLink, RouterView } from 'vue-router';
</script>

<template>
    <header>
        <img alt="Vue logo" class="logo" src="./assets/logo.svg" width="125" height="125" />
        <nav>
            <RouterLink to="/">Home</RouterLink>
            <RouterLink to="/welcome">Welcome</RouterLink>
            <RouterLink to="/company">Company</RouterLink>
        </nav>
    </header>

    <main>
        <RouterView />
    </main>
</template>

<style scoped>
    header {
        line-height: 1.5;
    }

    .logo {
        display: block;
        margin: 0 auto 2rem;
    }

    nav {
        display: flex;
        justify-content: center;
        gap: 1rem;
        margin-bottom: 2rem;
    }

    @media (min-width: 1024px) {
        header {
            display: flex;
            place-items: center;
            padding-right: calc(var(--section-gap) / 2);
        }

        .logo {
            margin: 0 2rem 0 0;
        }

        header nav {
            display: flex;
            place-items: flex-start;
            flex-wrap: wrap;
        }
    }
</style>
