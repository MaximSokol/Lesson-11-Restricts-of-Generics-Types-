using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11__Restricts_of_Generics_Types_.Task_3
{
    interface IMyInterface<T>
    {
        void Add(T elem);
        T this[int index] { get; }
        int Count { get; }
        bool Clear();
        bool Contains(T item);
    }

    public class MyList<T> : IMyInterface<T>
    {
        T[] list;
        //-----------------------------------------

        public MyList()
        {
            list = new T[0];
        }
        //-----------------------------------------

        public void Add(T elem)
        {
            T[] newArr = new T[list.Length + 1];
            for (int i = 0; i < list.Length; i++)
            {
                newArr[i] = list[i];
            }
            newArr[list.Length] = elem;
            list = newArr;
        }
        //-----------------------------------------

        public T this[int index]
        {
            get { return list[index]; }
        }
        //-----------------------------------------

        public int Count
        {
            get { return list.Length; }
        }
        //-----------------------------------------

        public bool Clear()
        {
            if (list.Length > 0)
            {
                list = null;
                return true;
            }
            else
                return false;
        }
        //-----------------------------------------

        public bool Contains(T item)
        {
            bool stat = false;
            for (int i = 0; i < list.Length; i++)
            {
                if ((int)(object)list[i] == (int)(object)item)
                    return stat = true;
                else
                    return stat = false;
            }
            return stat;
        }
        //-----------------------------------------

        public override string ToString()
        {
            string stroka = null;
            for (int i = 0; i < list.Length; i++)
            {
                stroka += list[i] + " ";
            }
            return "Размерность массива " + list.Length + " Элементы массива:" + stroka;
        }
        //-----------------------------------------
    }
}
