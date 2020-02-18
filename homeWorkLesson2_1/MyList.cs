using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson2_1
{
    class MyList<T> : IMyList<T>
    {
        private T[] arrayList;

        public MyList()
        {
            arrayList = new T[] { };
        }

        public T this[int index] 
        { 
            get 
            { 
                if (index < arrayList.Length)
                { 
                    return arrayList[index]; 
                }

                return default;
            } 
        }

        public int Count 
        { 
            get
            { 
                return arrayList.Length; 
            } 
        }

        public void Add(T a)
        {
            T[] newArrayList = new T[arrayList.Length + 1];

            for (int i = 0; i < arrayList.Length; i++)
            {
                newArrayList[i] = arrayList[i];
            }

            newArrayList[newArrayList.Length - 1] = a;
            arrayList = newArrayList;
        }

        public void Clear()
        {
            arrayList = new T[] { }; 
        }

        public bool Contains(T item)
        {
            foreach (var items in arrayList)
            {
                if(items.Equals(item))
                {
                    return true;
                }                
            }
            return false;
        }  
    }
}
