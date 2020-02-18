using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson2_1
{
    interface IMyList<T>
    {
       	T this[int index] { get; }
       	int Count { get; }
        void Clear();
        void Add(T a);
        bool Contains(T item);

    }
}
