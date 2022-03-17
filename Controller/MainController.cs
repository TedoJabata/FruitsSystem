using FruitsSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitsSystem.Controller
{
    class MainController
    {
        public List<Fruit> ShowAllFruits()
        {
            using (FruitsDBEntities fdbe = new FruitsDBEntities())
            {
                var fruits = fdbe.Fruits.ToList();
                return fruits;
            }
        }

        public void CreateFruit(Fruit f)
        {
            using (FruitsDBEntities fdbe = new FruitsDBEntities())
            {
                f.Id = fdbe.Fruits.Count() + 1;
                fdbe.Fruits.Add(f);
                fdbe.SaveChanges();
            }
        }
    }
}
