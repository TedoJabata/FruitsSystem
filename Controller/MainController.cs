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

        public void UpdateFruit(int id, string name, int price, int sugar, string color, Fruit fruit)
        {
            using (FruitsDBEntities fdbe = new FruitsDBEntities())
            {
                var fruitToUpdate = fdbe.Fruits.Where(f => f.Id == id).FirstOrDefault();
                if (fruitToUpdate != null)
                {
                    fruitToUpdate.Id = id;
                    fruitToUpdate.Name = name;
                    fruitToUpdate.Price = price;
                    fruitToUpdate.Sugar = sugar;
                    fruitToUpdate.Color = color;
                    fdbe.SaveChanges();
                }
            }
        }       



        public void DeleteFruit(int id)
        {
            using(FruitsDBEntities fdbe = new FruitsDBEntities())
            {
                var fruitToDelete = fdbe.Fruits.Where(f => f.Id == id).FirstOrDefault();
                if (fruitToDelete != null)
                {
                    fdbe.Fruits.Remove(fruitToDelete);
                    fdbe.SaveChanges();
                }
            }
        }

        internal void UpdateFruit(int id, Fruit fruit)
        {
            throw new NotImplementedException();
        }
    }
}
