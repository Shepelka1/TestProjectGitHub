using System;

namespace Library
{
    public class Class2
    {
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
