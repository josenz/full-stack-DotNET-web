import React from 'react';
import Book from './book.jsx';

class BookList extends React.Component {

    constructor(props) {
        super(props);
        this.state = { data: [] };
    }

    loadBooks() {
        const xhr = new XMLHttpRequest();
        xhr.open('get', this.props.url, false);
        xhr.onload = () => {
            const data = JSON.parse(xhr.responseText);
            this.setState({ data: data });
        }
        xhr.send();
    }

    componentWillMount() {
        this.loadBooks();
    }

    render() {

        const books = this.state.data.map(book => ( <Book key={book.id} bookName={book.name} bookPrice={book.price} /> ));

        return (
            <div>{books}</div>
        );
    }
};

export default BookList;