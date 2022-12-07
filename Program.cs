using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_11__Restricts_of_Generics_Types_.Additional_Task;
using Lesson_11__Restricts_of_Generics_Types_.Task_2;
using Lesson_11__Restricts_of_Generics_Types_.Task_3;

namespace Lesson_11__Restricts_of_Generics_Types_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Additional Task

            //var ownObj = new MyOwnClass(1109, "Head!");
            //var arrLst = new ArrayList()
            //{
            //    "hello",
            //    125458,
            //    ownObj.ID,
            //    ownObj.Discribe
            //};

            //for (int i = 0; i < arrLst.Count; i++)
            //{
            //    Console.WriteLine(arrLst[i]);
            //}

            // Task 2

            //var cars = new CarCollection<object>();
            //cars.SetSize = 1;
            //cars.Name = "Lincoln";
            //cars.Grade = 1982;

            //cars.AddACar(cars);
            //Console.WriteLine(cars[0]);
            //Console.WriteLine(cars.GetGeneralQuantityOfElements);
            //cars.DelAllTheCars();

            // Task 3

            //var dictionary =  new Lesson_11__Restricts_of_Generics_Types_
            //    .Task_3.Dictionary<int, string>();

            //dictionary.AddElem(10, "Hello");
            //Console.WriteLine(dictionary.GetPairOfElements);
            //Console.WriteLine(dictionary[0]);

            // Task 4

            var myArrList = new MyList<int>();
            myArrList.Add(20);
            Console.WriteLine(myArrList.Count);
            Console.WriteLine(myArrList[0]);
        }
    }
}
