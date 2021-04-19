using System;
using System.Collections.Generic;
using System.Text;

namespace Practica1
{
    class Company
    {
        private string Title;
        private string Address;
        private int YearOfFoundation;
        public Company()
        {
            Title = "";
            Address = "";
            YearOfFoundation = 0;
        }
        public void ShowTitle()
        {

            Console.WriteLine("The current company title is {0}", Title);
        }
        public void ShowAddress()
        {

            Console.WriteLine("The current company address is {0}", Address);
        }
        public void ShowYearOfFoundation()
        {

            Console.WriteLine("The current company year of foundation = {0}", YearOfFoundation);

        }
        public string TITLE
        {
            get

            {
                return Title;
            }
            set
            {
                Title = value;
            }

        }
        public string ADDRESS
        {
            get

            {
                return Address;
            }
            set
            {
                Address = value;
            }

        }
        public int YEAROFFOUNDATION
        {
            get
            {

                return YearOfFoundation;
            }
            set
            {
                YearOfFoundation = value;
            }
        }
    }
}
