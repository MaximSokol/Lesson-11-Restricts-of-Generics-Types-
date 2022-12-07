using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11__Restricts_of_Generics_Types_.Task_2
{
    class CarCollection<Car>
    {
        private CarCollection<Car>[] parkOfCars = default;
        //------------------------------------------------------------------

        public string Name { get; set; }
        public int Grade { get; set; }
        public int SetSize { get; set; }
        //------------------------------------------------------------------

        public CarCollection()
        {
            parkOfCars = new CarCollection<Car>[SetSize];
        }
        //------------------------------------------------------------------

        public void AddACar(CarCollection<Car> car)
        {
            CarCollection<Car>[] newPark = new CarCollection<Car>[parkOfCars.Length + 1];

            for (int i = 0; i < parkOfCars.Length; i++)
            {
                newPark[i] = parkOfCars[i];
            }
            newPark[parkOfCars.Length] = car;
            parkOfCars = newPark;
        }
        //------------------------------------------------------------------

        public CarCollection<Car> this[int index]
        {
            get { return parkOfCars[index]; }
        }
        //------------------------------------------------------------------

        public int GetGeneralQuantityOfElements
        {
            get
            {
                if (parkOfCars.Length > 0)
                    return parkOfCars.Length;
                else
                    return -1;
            }
        }
        //------------------------------------------------------------------

        public bool DelAllTheCars()
        {
            if (parkOfCars.Length > 0)
            {
                parkOfCars = null;
                return true;
            }
            else
                return false;
        }
        //------------------------------------------------------------------

        public override string ToString()
        {
            return $"The size:\t\t{SetSize}\n" +
                $"Name of a car:\t\t{Name}\n" +
                $"The year of grade:\t{Grade}\n";
        }
        //------------------------------------------------------------------

    }
}
