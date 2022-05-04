using System;
using System.Collections.Generic;

#nullable disable

namespace DAL_Reference.Models
{
    public partial class TblUserDataDetail
    {
        public string UserId { get; set; }
        public string PassWord { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int? RecordDeleted { get; set; }
        public int? UserCreatedBy { get; set; }
        public DateTime? UserCreatedOn { get; set; }
        public int? UserUpdatedBy { get; set; }
        public DateTime? UserUpdatedOn { get; set; }
    }
}
