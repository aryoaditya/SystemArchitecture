namespace LibraryApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            BookManagement bookManagement = new BookManagement();
            MemberManagement memberManagement = new MemberManagement();
            LoanManagement loanBook = new LoanManagement();

            bool isLoop = true;

            while (isLoop)
            {
                Console.WriteLine("Layanan Perpustakaan:");
                Console.WriteLine("1. Manajemen Buku");
                Console.WriteLine("2. Manajemen Anggota");
                Console.WriteLine("3. Peminjaman Buku");
                Console.WriteLine("0. Keluar");

                Console.Write("Masukkan opsi pilihan : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        //BookManagementView();
                        break;
                    case 2:
                        // Tambahkan logika untuk Manajemen Anggota di sini
                        break;
                    case 3:
                        // Tambahkan logika untuk Peminjaman Buku di sini
                        break;
                    case 0:
                        isLoop = false;
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                        break;
                }
            }
        }
    }
}