using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_one
{
    class Car
    {
        private string color;

        public Car(string color)
        {
            this.color = color;
        }

        public string Describe()
        {
            return "This car is " + Color;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }

    class SillyMessages
    {
        public string Mumble(Int16 calledBy)
        {
            String result = "SHEESH";
            if (calledBy == 1)
                result = "AHH";
            else
                result = "DOH";

            return result; }
    }
}
