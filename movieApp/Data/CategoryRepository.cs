using System.Collections.Generic;
using System.Linq;
using movieApp.Models;

namespace movieApp.Data
{
    public static class CategoryRepository
    {
        private static List<Category> _categories = null;

        static CategoryRepository()
        {
            _categories = new List<Category>()
            {
                new Category()
                {
                    Id=1,
                    Name="Biyografi"
                },
                new Category()
                {
                    Id=2,
                    Name="Fantastik"
                },
                new Category()
                {
                    Id=3,
                    Name="Drama"
                },
                new Category()
                {
                    Id=4,
                    Name="Bilim Kurgu"
                },
                new Category()
                {
                    Id=5,
                    Name="Aksiyon/Macera"
                },
                new Category()
                {
                    Id=6,
                    Name="Gerilim"
                }
            };
        }

        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }

        public static void AddCategory(Category entity)
        {
            _categories.Add(entity);
        }

        public static Category GetById(int id)
        {
            return _categories.FirstOrDefault(i => i.Id == id);
        }
    }
}