let books = [];

let nextId = 1;


function addBook() {

    let title = document.getElementById("title").value;
    let author = document.getElementById("author").value;
    let price = document.getElementById("price").value;


    let book = {
        id: nextId,
        title: title,
        author: author,
        price: price
    };


    books.push(book);

    nextId++;

    displayBooks();
}


function displayBooks() {

    let table = document.getElementById("bookTable");

    table.innerHTML = "";


    books.forEach(function(book) {

        let row = `
            <tr>

                <td>${book.id}</td>

                <td>${book.title}</td>

                <td>${book.author}</td>

                <td>${book.price}</td>

                <td>
                    <button onclick="deleteBook(${book.id})">
                        Delete
                    </button>
                </td>

            </tr>
        `;

        table.innerHTML += row;
    });
}


function deleteBook(id) {

    books = books.filter(function(book) {

        return book.id !== id;

    });

    displayBooks();
}