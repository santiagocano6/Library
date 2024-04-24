import './book-table.css';

function BookTable({ bookList }) {
    return (
      <div className="App">
        {bookList.map(book => {
          return (<div>{book.bookId}</div>);
        })}
      </div>
    );
}

export default BookTable;