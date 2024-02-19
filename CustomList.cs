using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_CustomList_TylerSimpson
{
    public class CustomList<T>
    {
        //two constructors, one default and another that allows specifying the initial size. <T> makes our class generic.
        private T[] items;
        private int count;

        public CustomList() : this(10) { }

        public CustomList(int initialSize)
        {
            items = new T[initialSize];
        }

        public int Count => count;

        // Additional methods will be added here.

        //Implement the Add method: Add inserts items at the end. Method calls CheckIntegrity to ensure there's enough space.
        public void Add(T item)
        {
            CheckIntegrity();
            items[count++] = item;
        }
        //Implement the AddAtIndex method: AddAtIndex places items at a specified index. Method calls CheckIntegrity to ensure there's enough space.
        public void AddAtIndex(T item, int index)
        {
            CheckIntegrity();
            if (index < 0 || index > count) throw new ArgumentOutOfRangeException(nameof(index));
            for (int i = count; i > index; i--)
            {
                items[i] = items[i - 1];
            }
            items[index] = item;
            count++;
        }
        //Add the Remove method: Remove searches for an item and, if found, shifts subsequent elements forward.
        public bool Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item))
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        items[j] = items[j + 1];
                    }
                    count--;
                    return true;
                }
            }
            return false;
        }
        //Add the CheckIntegrity method: ensures the array size is sufficient, expanding it when 80% full.
        private void CheckIntegrity()
        {
            if (count >= 0.8 * items.Length)
            {
                T[] largerArray = new T[items.Length * 2];
                Array.Copy(items, largerArray, count);
                items = largerArray;
            }
        }
        //Implement the GetItem method: retrieves an item by index, with bounds checking.
        public T GetItem(int index)
        {
            if (index < 0 || index >= count) throw new ArgumentOutOfRangeException(nameof(index));
            return items[index];
        }
    }
}
