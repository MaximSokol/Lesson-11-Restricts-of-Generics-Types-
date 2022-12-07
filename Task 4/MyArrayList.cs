using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11__Restricts_of_Generics_Types_.Task_4
{
    class MyArrayList
    {
        object[] list;
        //-----------------------------------------

        public MyArrayList()
        {
            list = new object[0];
        }
        //-----------------------------------------

        public void Add(object elem)
        {
            object[] newArr = new object[list.Length + 1];
            for (int i = 0; i < list.Length; i++)
            {
                newArr[i] = list[i];
            }
            newArr[list.Length] = elem;
            list = newArr;
        }
        //-----------------------------------------

        public object this[int index]
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

        public bool Contains(object item)
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
