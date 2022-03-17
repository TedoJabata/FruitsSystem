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
            using (FruitsDBEntities gdbe = new FruitsDBEntities())
            {
                var fruits = gdbe.Fruits.ToList();
                return fruits;
            }
        }
    }
}
