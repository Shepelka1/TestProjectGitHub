using System;

namespace Library
{
    public class Class1
    {

        public int ivanP1;
        public int ivanP2;
        public int ivanP3;

        public int Const(int IvanP1, int IvanP2, int IvanP3)
        {
            this.ivanP1 = IvanP1;
            this.ivanP2 = IvanP2;
            this.ivanP3 = IvanP3;
        }
        

        public int acho1;
        public int acho2;
        public int acho3;
        public int Acho1 { get; set; }
        public int Acho2 { get; set; }
        public int Acho3 { get; set; }
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
