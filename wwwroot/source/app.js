import React from 'react';
import ReactDOM from 'react-dom';
import BookList from './bookList.jsx';

class App extends React.Component {
    render() {
        return (
            <div>
                <BookList url="/api/books" />
            </div>
        );
    }
};

ReactDOM.render(
    <App />,
    document.getElementById('container')
);

module.hot.accept();