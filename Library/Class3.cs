using System;

namespace Library
{
    public class Class3
    {
        public int sth1;
        public int sth2;
        public int sth3;
        public int Sth1 { get; set; }
        public int Sth2 { get; set; }
        public int Sth3 { get; set; }
        public string CoolLibraryName { get; set; }
        public string CoolAdress { get; set; }
        public decimal Revenue { get; set; }
        public Class3(string CoolLibraryName, string CoolAdress, decimal Revenue)
        {
            this.CoolLibraryName = CoolLibraryName;
            this.CoolAdress = CoolAdress;
            this.Revenue = Revenue;
        }
    }
}
