using System;

namespace Library
{
    public class Class2
    {
        public int test1;
        public int test2;
        public int test3;
        public int Test1 { get; set; }
        public int Test2 { get; set; }
        public int Test3 { get; set; }
        public string CoolISBN { get; set; }
        public string CoolAuthor { get; set; }
        public DateTime CreationDate { get; set; }
        public Class2(string CoolISBN, string CoolAuthor, DateTime CreationDate)
        {
            this.CoolISBN = CoolISBN;
            this.CoolAuthor = CoolAuthor;
            this.CreationDate = CreationDate;
        }
    }
}
