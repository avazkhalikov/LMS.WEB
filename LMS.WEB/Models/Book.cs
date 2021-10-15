using LMS.WEB.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.WEB.Models
{
    public partial class Book : BaseEntity
    {
        //private int _id;
        //public int Id
        //{
        //    get { return _id; }
        //    set { _id = value; }
        //}

        public string Title { get; set; }

       // public List<string> Authors { get; set; }

        public string Edition { get; set; }

        public int YearPublished { get; set; }

        public string Category { get; set; }

        public string Publisher { get; set; }

        public string Barcode { get; set; }

        public string ISBN { get; set; }

        public string Location { get; set; }

        public BookStatus Status { get; set; }
    }

    public enum BookStatus
    {
        Reserved = 0,
        InLoan = 1,
        Available = 2
    }
}
