import axios from 'axios';

const API_URL = 'https://localhost:5173/api/company'; // �ھڧA��API�a�}

export const getCompanies = () => {
    return axios.get(API_URL);
};

export const insertCompany = (company) => {
    return axios.post(API_URL, company);
};
