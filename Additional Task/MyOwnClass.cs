using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11__Restricts_of_Generics_Types_.Additional_Task
{
    public class MyOwnClass
    {
        private int id;
        private string discribe;
        //-----------------------------------------------------

        public int ID => this.id;
        public string Discribe => this.discribe;
        //-----------------------------------------------------

        public MyOwnClass() { }

        public MyOwnClass(int id, string discribe)
        {
            this.id = id;
            this.discribe = discribe;
        }
        //-----------------------------------------------------
    }
}
