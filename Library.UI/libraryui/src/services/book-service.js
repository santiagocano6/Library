import axios from "axios";

const baseURL = 'http://localhost:5147'

export const getBookList = () => {
    const url = `${baseURL}/Books`;
    return axios.get(url)
        .then((response) => {
            console.log(response.data);
            return response.data;
      });
}