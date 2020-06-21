using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialTrainingTests
{
    class SimpleArray
    {
        public string[] groceryList;

        public SimpleArray()
        {
            groceryList = new string[4]; { "Bread", "Milk", "Eggs", "Cheese"};
        }

        public override string ToString()
        {
            return "There are " + groceryList.Length + " and they are: " + groceryList.ToString();
        }

    }
}
