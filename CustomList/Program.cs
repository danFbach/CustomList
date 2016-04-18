using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.mainMenyuu();
        }
    }
}
//The standard System.Collections.Generic.List class that we know and love is actually just a class that stores its list data in an internal array and provides some convenient, additional functions to make things easier on us.
//Implement your own version of the List class from scratch, called CustomList, using an array as its internal data representation.Implement the following methods with the same behavior as their analogues in the standard List class:

//   CustomList.Add(element) : Adds an element to the end of the array

//   CustomList.Remove(element) : Removes the element from the array

//   CustomList.Insert(index, element) : Inserts the specified element at the specified index in the array

//   CustomList.Count() : Returns the number of elements in the array

//   CustomList[] : Accesses an element from the array via its index using bracket notation

//   Your CustomList class must accept elements of any kind of datatype, though you can assume the array's elements in whole will all be the same type.