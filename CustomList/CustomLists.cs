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
        public Type customType;
        public CustomLists newList;
        public CustomLists(Array newArray)
        {
            this.newArray = newArray;
            this.newList = newList;
        }
        public void add(String newItem)
        {
            CustomLists newCustomList = newList + newItem;
        }
        public static CustomLists operator +(CustomLists newList, String newItem)
        {
            newList = new CustomLists(newList.newArray + newItem);
            return newList;
        }
        public int Count()
        {
            int count = 0;
            foreach (Type item in newArray)
            {
                count++;
            }
            return count;
        }
        public IEnumerator GetEnumerator()
        {
            return newArray.GetEnumerator();
        }
        public Array getList()
        {
            return newArray;
        }
        public void RemoveAt(int removeIndex)
        {

        }
    }
}
