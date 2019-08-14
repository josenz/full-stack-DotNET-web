import React from 'react';

class Book extends React.Component {

    render() {
        return (
            <div>
                {this.props.bookName} {this.props.bookPrice}
            </div>
        );
    }
};

export default Book;