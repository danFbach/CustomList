using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomLists : System.Collections.IEnumerable
    { 
        Array newArray;        
        public CustomLists()
        {
        }
        public static IEnumerable<TSource> Concat<TSource>
        (
            this IEnumerable<TSource> first,
            IEnumerable<TSource> second
        )
        {
            return second;
        }
        public IEnumerator GetEnumerator()
        {
            return newArray.GetEnumerator();
        }
        public Array getList()
        {
            return newArray;
        }
    }
}
//static CustomLists[] listItem<T>(T stuff)
//{
//    CustomLists[] items = { new CustomLists { this.stuff = stuff } };
//    return items;
//}
//static Pet[] GetCats()
//{
//    Pet[] cats = { new Pet { Name="Barley", Age=8 },
//                   new Pet { Name="Boots", Age=4 },
//                   new Pet { Name="Whiskers", Age=1 } };
//    return cats;
//}