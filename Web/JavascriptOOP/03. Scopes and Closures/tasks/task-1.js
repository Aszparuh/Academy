/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
	var library = (function () {
		var books = [];
		var categories = [];
		function listBooks() {
			return books;
		}
		
		function validateBook(book) {
			if (typeof book.title !== 'string' || book.title < 2 || book.title > 100 ) {
				throw new Error('Book title must be between 2 and 100');
			}
			if (book.author !== 'string' || book.author === '') {
				throw new Error('Author must not be empty string');
			}
			if (typeof book.isbn !== 'string' ||
                (book.isbn.length !== 10 &&
                    book.isbn.length !== 13) ||
                book.isbn.split('').every(function(item) {
                    return isNaN(item);
                })) {
                throw new Error('ISBN must be a string, containing 10 or 13 digits');
            }
		}

		function addBook(book) {
			var newBook;
			var id = 1;
			validateBook(book);
			newBook = new Book(newBook); 
			newBook.ID = ++id;
			books.push(newBook);
			categories[newBook.category].books.push(book);
			return newBook;
		}

		function listCategories() {
			return categories;
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());
	return library;	
}

module.exports = solve;
