namespace LibraryApp
{
    public class LoanManagement
    {
        private List<Loan> loanList = new List<Loan>();

        public void LoanBook(int idAnggota, int idBuku, DateTime tanggalPeminjaman, DateTime tanggalPengembalian)
        {
            // Logika untuk memproses peminjaman buku
            var loan = new Loan
            {
                IDAnggota = idAnggota,
                IDBuku = idBuku,
                TanggalPeminjaman = tanggalPeminjaman,
                TanggalPengembalian = tanggalPengembalian
            };
            loanList.Add(loan);
        }

        public void ReturnBook(int idPeminjaman)
        {
            // Logika untuk mengembalikan buku berdasarkan ID peminjaman
            var loan = loanList.FirstOrDefault(p => p.ID == idPeminjaman);
            if (loan != null)
            {
                // Lakukan pemrosesan pengembalian buku
                loanList.Remove(loan);
            }
        }

        public List<Loan> LoanStatus(int idAnggota)
        {
            // Logika untuk melihat status peminjaman buku oleh anggota tertentu
            return loanList.Where(p => p.IDAnggota == idAnggota).ToList();
        }
    }
}
