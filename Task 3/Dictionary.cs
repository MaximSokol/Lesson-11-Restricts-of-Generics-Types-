using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11__Restricts_of_Generics_Types_.Task_3
{
    class Dictionary<TKey, TValue>
    {
        MyList<TKey> key = null;
        MyList<TValue> value = null;
        //--------------------------------------

        public Dictionary()
        {
            this.key = new MyList<TKey>();
            this.value = new MyList<TValue>(); 
        }
        //-----------------------------------------

        public void AddElem(TKey k, TValue v)
        {
            this.key.Add(k);
            this.value.Add(v);
        }
        //-----------------------------------------

        public string this[int index]
        {
            get { return $"Key:\t{this.key[index]}\t" 
                    + $"Value:\t{this.value[index]}"; }
        }
        //-----------------------------------------

        public string GetPairOfElements
        {
            get { return $"The pair of elemets:\t {this.key.Count}"; }
        }
        //-----------------------------------------

        public override string ToString()
        {
            string stroka = string.Empty;
            for (int i = 0; i < key.Count; i++)
            {
                stroka += key[i] + " " + value[i] + "\n";
            }
            if (stroka != null)
                return stroka;
            return "В словаре нет значений.";
        }
        //-----------------------------------------
    }
}
