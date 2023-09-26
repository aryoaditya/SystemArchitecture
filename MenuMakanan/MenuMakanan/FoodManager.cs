namespace MenuMakanan
{
    public class FoodManager
    {
        private List<Food> foods = new List<Food>();    // List makanan

        // Mengambil semua list makanan
        public List<Food> GetAllFoods()
        {
            return foods;
        }

        // tambah makanan
        public void AddFood(Food food)
        {
            foods.Add(food);
        }

        // ubah makanan
        public void EditFood(string name, Food updatedFood)
        {
            var existingFood = foods.FirstOrDefault(f => f.Name == name);
            if (existingFood != null)
            {
                existingFood.Name = updatedFood.Name;
                existingFood.Description = updatedFood.Description;
                existingFood.Price = updatedFood.Price;
            }
        }

        // hapus makanan
        public void DeleteFood(string name)
        {
            var foodToRemove = foods.FirstOrDefault(f => f.Name == name);
            if (foodToRemove != null)
            {
                foods.Remove(foodToRemove);
            }
        }
    }
}
