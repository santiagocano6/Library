import './book-table.css';

function BookTable({ bookList }) {
    return (
        <table>
          <tr>
            <th>Book Title</th>
            <th>Authors</th>
            <th>Type</th>
            <th>ISBN</th>
            <th>Category</th>
            <th>Available Copies</th>
          </tr>
          <tbody>
            {bookList.map(book => {
              return (<tr key={book.bookId}>
                <td>{book.title}</td>
                <td>{book.firstName} {book.lastName}</td>
                <td>{book.type}</td>
                <td>{book.isbn}</td>
                <td>{book.category}</td>
                <td>{book.totalCopies - book.copiesInUse}</td>
              </tr>);
            })}
          </tbody>
        </table>
    );
}

export default BookTable;