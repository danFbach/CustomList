using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class Menu
    {
        CustomLists customLists = new CustomLists(newList);
        public void mainMenyuu()
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("Build a list. Please enter a new item for the list.");
                String newEntry = Console.ReadLine();
                if(newEntry != null)
                {
                    customLists.add(newEntry);

                }
                if (newEntry.Equals("exit")) { check = false; }
                foreach (CustomLists items in customLists.newList)
                {
                    Console.WriteLine(items);
                }
            }            
        }
    }
}
