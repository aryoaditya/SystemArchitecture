namespace MenuMakanan
{
    public class program
    {
        static FoodManager foodManager = new FoodManager();
        public static void Main()
        {

            bool isLoop = true;
            // Tampilan menu
            while (isLoop != false)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Tampilkan Daftar Makanan");
                Console.WriteLine("2. Tambah Makanan");
                Console.WriteLine("3. Edit Makanan");
                Console.WriteLine("4. Hapus Makanan");
                Console.WriteLine("5. Keluar");
                Console.Write("Pilih menu : ");

                // input pilihan
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShowFoods(); // menampilkan makanan
                        break;
                    case "2":
                        AddFood(); // tambah makanan
                        break;
                    case "3":
                        EditFood(); // ubah makanan
                        break;
                    case "4":
                        DeleteFood(); // hapus makanan
                        break;
                    case "5":
                        isLoop = false; // keluar
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                        break;
                }
            }
        }

        static void ShowFoods()
        {
            // logika untuk menampilkan makanan
            var foods = foodManager.GetAllFoods();
            if (foods.Count > 0)
            {
                Console.WriteLine("Daftar Makanan:");
                foreach (var food in foods)
                {
                    Console.WriteLine($"Nama: {food.Name}, Deskripsi: {food.Description}, Harga: {food.Price}");
                }
            }
            else
            {
                Console.WriteLine("Daftar makanan kosong.");
            }
        }

        static void AddFood()
        {
            // logika menambah makanan dengan input user
            Console.Write("Nama Makanan: ");
            string name = Console.ReadLine();
            Console.Write("Deskripsi: ");
            string description = Console.ReadLine();
            Console.Write("Harga: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal price))
            {
                Food newFood = new Food
                {
                    Name = name,
                    Description = description,
                    Price = price
                };
                foodManager.AddFood(newFood);
                Console.WriteLine("Makanan berhasil ditambahkan.");
            }
            else
            {
                Console.WriteLine("Harga tidak valid. Makanan gagal ditambahkan.");
            }
        }

        static void EditFood()
        {
            // logika untuk mengedit makanan
            Console.Write("Nama Makanan yang akan diubah: ");
            string nameToEdit = Console.ReadLine();
            var existingFood = foodManager.GetAllFoods().FirstOrDefault(f => f.Name == nameToEdit);
            if (existingFood != null)
            {
                Console.Write("Nama Baru: ");
                string newName = Console.ReadLine();
                Console.Write("Deskripsi Baru: ");
                string newDescription = Console.ReadLine();
                Console.Write("Harga Baru: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal newPrice))
                {
                    Food updatedFood = new Food
                    {
                        Name = newName,
                        Description = newDescription,
                        Price = newPrice
                    };
                    foodManager.EditFood(nameToEdit, updatedFood);
                    Console.WriteLine("Makanan berhasil diubah.");
                }
                else
                {
                    Console.WriteLine("Harga tidak valid. Makanan gagal diubah.");
                }
            }
            else
            {
                Console.WriteLine("Makanan tidak ditemukan.");
            }
        }

        static void DeleteFood()
        {
            // logika untuk menghapus makanan
            Console.Write("Nama Makanan yang akan dihapus: ");
            string nameToDelete = Console.ReadLine();
            var existingFood = foodManager.GetAllFoods().FirstOrDefault(f => f.Name == nameToDelete);
            if (existingFood != null)
            {
                foodManager.DeleteFood(nameToDelete);
                Console.WriteLine("Makanan berhasil dihapus.");
            }
            else
            {
                Console.WriteLine("Makanan tidak ditemukan.");
            }
        }

    }

}