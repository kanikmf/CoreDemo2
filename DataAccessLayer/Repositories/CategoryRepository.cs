using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        public void AddCategory(Category category)
        {
            using var c = new Context();
            c.Add(category);
            c.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            using var c = new Context();
            c.Remove(category);
            c.SaveChanges();
        }

        public Category GetById(int id)
        {
            using var c = new Context();
            return c.Set<Category>().Find(id);
        }

        public List<Category> ListAllCategory()
        {
            using var c = new Context();
            return c.Set<Category>().ToList();
        }

        public void UpdateCategory(Category category)
        {
            using var c = new Context();
            c.Update(category);
            c.SaveChanges();
        }
    }
}
