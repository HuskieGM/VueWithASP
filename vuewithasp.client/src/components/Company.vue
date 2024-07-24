<template>
    <div>
        <h1>公司資料</h1>
        <table>
            <thead>
                <tr>
                    <th>公司代號</th>
                    <th>公司名稱</th>
                    <!-- 其他欄位 -->
                </tr>
            </thead>
            <tbody>
                <tr v-for="company in companies" :key="company.companyId">
                    <td>{{ company.companyCode }}</td>
                    <td>{{ company.companyName }}</td>
                    <!-- 其他欄位 -->
                </tr>
            </tbody>
        </table>
        <form @submit.prevent="addCompany">
            <label>
                公司代號:
                <input v-model="newCompany.companyCode" required />
            </label>
            <label>
                公司名稱:
                <input v-model="newCompany.companyName" required />
            </label>
            <!-- 其他欄位 -->
            <button type="submit">新增公司</button>
        </form>
    </div>
</template>

<script>
    import { getCompanies, insertCompany } from '../services/CompanyService';

    export default {
        data() {
            return {
                companies: [],
                newCompany: {
                    exportDate: '',
                    dataMonth: '',
                    companyCode: '',
                    companyName: '',
                    industryCategory: '',
                    revenueCurrentMonth: 0,
                    revenueLastMonth: 0,
                    revenueSameMonthLastYear: 0,
                    revenueChangeLastMonthPercent: 0,
                    revenueChangeSameMonthLastYearPercent: 0,
                    accumulatedRevenueCurrentMonth: 0,
                    accumulatedRevenueLastYear: 0,
                    accumulatedRevenueChangePercent: 0,
                    remarks: ''
                }
            };
        },
        mounted() {
            this.loadCompanies();
        },
        methods: {
            async loadCompanies() {
                try {
                    const response = await getCompanies();
                    this.companies = response.data;
                } catch (error) {
                    console.error('Error loading companies:', error);
                }
            },
            async addCompany() {
                try {
                    await insertCompany(this.newCompany);
                    this.loadCompanies(); // 重新加載公司資料
                    this.resetForm(); // 重置表單
                } catch (error) {
                    console.error('Error adding company:', error);
                }
            },
            resetForm() {
                this.newCompany = {
                    exportDate: '',
                    dataMonth: '',
                    companyCode: '',
                    companyName: '',
                    industryCategory: '',
                    revenueCurrentMonth: 0,
                    revenueLastMonth: 0,
                    revenueSameMonthLastYear: 0,
                    revenueChangeLastMonthPercent: 0,
                    revenueChangeSameMonthLastYearPercent: 0,
                    accumulatedRevenueCurrentMonth: 0,
                    accumulatedRevenueLastYear: 0,
                    accumulatedRevenueChangePercent: 0,
                    remarks: ''
                };
            }
        }
    };
</script>

<style scoped>
    /* 添加一些樣式 */
    table {
        width: 100%;
        border-collapse: collapse;
    }

    table, th, td {
        border: 1px solid black;
    }

    th, td {
        padding: 8px;
        text-align: left;
    }
</style>
