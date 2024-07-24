import axios from 'axios';

const API_URL_GET = 'https://localhost:7060/api/company/GetCompanies'; // 查詢 API 地址
const API_URL_INSERT = 'https://localhost:7060/api/company/InsertCompany'; // 新增 API 地址

export const getCompanies = () => {
    return axios.post(API_URL_GET); // 使用 POST 方法調用查詢 API
};

export const insertCompany = (company) => {
    return axios.post(API_URL_INSERT, company); // 使用 POST 方法調用新增 API
};
