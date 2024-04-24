import axios from "axios";

const baseURL = 'http://localhost:5147'

const convertObjectToQuery =(obj) => {
    let values = [];
    for (let prop in obj) {
        if(obj[prop]) {
            values.push(`${prop}='${obj[prop]}'`);
        }
    }
    return encodeURI("?" + values.join("&"));
  }

export const getBookList = (filter) => {
    const query = convertObjectToQuery(filter);
    const url = `${baseURL}/Books${query}`;
    return axios.get(url).then((response) => response.data);
}