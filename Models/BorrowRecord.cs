using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibraryManagementLayeredArchitectureAndRepository.Models
{
    class BorrowRecord
    {
        // Properties for the BorrowRecord class
        public int Id { get; set; }
        public string MemberId { get; set; }
        public int BookId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; } // Nullable to allow for books that haven't been returned yet
    }
}
