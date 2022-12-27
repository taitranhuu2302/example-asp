import axios from 'axios';

const BASE_URL = "https://localhost:7235";
export const fetchAllContacts = () => axios.get(`${BASE_URL}/Contact`).then(({data}) => data)
export const createContact = (data) => axios.post(`${BASE_URL}/Contact`, data).then(({data}) => data)
export const updateContact = ({id,data}) => axios.put(`${BASE_URL}/Contact/${id}`, data).then(({data}) => data)
export const deleteContact = (id) => axios.delete(`${BASE_URL}/Contact/${id}`);
