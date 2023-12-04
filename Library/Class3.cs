using System;

namespace Library
{
    public class Class3
    {
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
