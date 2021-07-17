using ComputerWebShop.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerWebShop.Models.Repo
{
    public interface ICategoryRepo
    {
        public Category Create(Category category);

        public List<Category> Read();

        public Category Read(int id);

        public Category Update(Category category);

        public bool Delete(Category category);
    }
}
