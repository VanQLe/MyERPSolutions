using System;
using System.Collections.Generic;
using System.Text;

namespace MyERPSolutions.PrideTek.Models
{
    public class User : IEntity
    {
        public long Id => UserId;
        public long UserId { get; set; }
        public string FullName => FirstName + LastName;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsEnabled { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreateDated { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
    }
}
