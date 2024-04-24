import { useEffect, useState } from "react";

import BookTable from '../book-table';

import { getBookList } from '../../services/book-service';

import './book.css';

function Book() {
  const [books, setBooks] = useState([]);
  const [isLoading, setIsLoading] = useState(false);
  const [searchBy, setSearchBy] = useState('0');
  const [searchValue, setSearchValue] = useState('');

  useEffect(() => {
    searchBooks();
  }, [])

  const searchBooks = () => {
    setIsLoading(true);
    const filter = {
      Author: searchBy === '1' ? searchValue : null,
      ISBN: searchBy === '2' ? searchValue : null,
    };
    console.log('filter', filter);
    getBookList(filter).then(response => {
      setBooks(response);
      setIsLoading(false);
    });
  }

  return (
    <div className="App">
      <div className="filterContainer">
        <div className="filterRow">
          <label htmlFor="searchBy">Search By</label>
          <select
            id="searchBy"
            name="Search By"
            onChange={event => setSearchBy(event.target.value)}
            value={searchBy}
          >
            <option value ="0">None</option>
            <option value ="1">Author</option>
            <option value ="2">ISBN</option>
          </select> 
        </div>
        <div className="filterRow">
          <label htmlFor="searchValue">Search Value</label>
          <input
            id="searchValue"
            value={searchValue}
            onChange={event => setSearchValue(event.target.value)}
          ></input>
        </div>
        <div className="filterRow">
          <button disabled={isLoading} onClick={() => searchBooks()}>Search</button>
        </div>
      </div>
      <div className="tableContainer">
        <div className="tableTitle">
          Search Results:
        </div>
        <BookTable bookList={books}/>
      </div>
    </div>
  );
}

export default Book;