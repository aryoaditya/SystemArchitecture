namespace LibraryApp
{
    public class BookManagement
    {
        private List<Book> bookList = new List<Book>();

        public void Add(int id, string judul, string pengarang, string isbn)
        {
            Book newBook = new Book
            {
                ID = id,
                Judul = judul,
                Pengarang = pengarang,
                NomorISBN = isbn,
            };
            // Logika untuk menambah buku ke daftar buku
            bookList.Add(newBook);
        }

        public void Edit(int id, Book book)
        {
            // Logika untuk mengedit buku berdasarkan ID
            var updatedBook = bookList.FirstOrDefault(b => b.ID == id);
            if (updatedBook != null)
            {
                updatedBook.Judul = book.Judul;
                updatedBook.Pengarang = book.Pengarang;
                updatedBook.NomorISBN = book.NomorISBN;
            }
        }

        public void Delete(int id)
        {
            // Logika untuk menghapus buku berdasarkan ID
            var deleteBook = bookList.FirstOrDefault(b => b.ID == id);
            if (deleteBook != null)
            {
                bookList.Remove(deleteBook);
            }
        }

        public List<Book> BookList()
        {
            // Logika untuk melihat daftar buku
            return bookList;
        }
    }
}