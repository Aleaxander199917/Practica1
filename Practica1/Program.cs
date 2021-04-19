using System;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            Company companyy = new Company();
            companyy.TITLE = "Polotsk";
            companyy.ADDRESS = "Construction";
            companyy.YEAROFFOUNDATION = 2013;
            companyy.ShowTitle();
            companyy.ShowAddress();
            companyy.ShowYearOfFoundation();
        }
    }
}
