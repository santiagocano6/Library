import { useEffect, useState } from "react";

import BookTable from '../book-table';

import { getBookList } from '../../services/book-service';

import './book.css';

function Book() {
  const [books, setBooks] = useState([]);
  
  useEffect(() => {
    console.log('get');
    getBookList().then(response => {
      setBooks(response);
    });
  }, [])

    return (
      <div className="App">
        Hola mundo
        <BookTable bookList={books}/>
      </div>
    );
}

export default Book;