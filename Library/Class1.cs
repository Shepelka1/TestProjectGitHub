using System;

namespace Library
{
    public class Class1
    {
        public string CoolName { get; set; }
        public int CoolYear { get; set; }
        public DateTime FavDateTime { get; set; }
        public Class1(string CoolName, int CoolYear, DateTime FavDateTime)
        {
            this.CoolName = CoolName;
            this.CoolYear = CoolYear;
            this.FavDateTime = FavDateTime;
        }
    }
}
