namespace NewCoffeeShop.Models
{
    
    public class ProductDAL
    {
        private static CoffeeShopDbContext dbContext= new CoffeeShopDbContext();

        public static List<Product> GetAll()
        {
            return dbContext.Products.ToList();
        }
        public static Product GetById(int id)
        {
            return dbContext.Products.Find(id);
        }
        public static List<Product> GetAllByCatergory(string c) 
        {
            return dbContext.Products.Where(p => p.Category.ToLower().Trim() == c.ToLower().Trim() ).ToList();
        }
        public static List<string> GetAllCatergory()
        {
            //return dbContext.Products.DistinctBy(p => p.Category).ToList();
            return dbContext.Products.GroupBy(p => p.Category).ToDictionary(x => x.Key, y => y).Keys.ToList();
        }
    }
}
