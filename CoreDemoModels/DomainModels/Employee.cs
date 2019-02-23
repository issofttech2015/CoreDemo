using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreDemoModels.DomainModels
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int DepertmentId { get; set; }
        public bool IsDeleted { get; set; }
        public virtual Depertment Depertment { get; set; }
    }
}
