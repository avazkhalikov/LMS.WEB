using LMS.WEB.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.WEB.Models
{
    public partial class Loan : BaseEntity
    {
        
        public User Borrower { get; set; }

        public Book BorrowedBook { get; set; }

        public DateTime DateTaken { get; set; }

        public int Duration { get; set; }

        public bool IsReturned { get; set; }

        public DateTime? ActualReturnDate { get; set; }

    }
}
