namespace LibraryApp
{
    public class Loan
    {
        public int ID { get; set; }
        public int IDAnggota { get; set; }
        public int IDBuku { get; set; }
        public DateTime TanggalPeminjaman { get; set; }
        public DateTime TanggalPengembalian { get; set; }
    }
}
