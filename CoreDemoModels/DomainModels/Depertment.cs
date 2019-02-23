using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreDemoModels.DomainModels
{
    public class Depertment
    {
        [Key]
        public int DepertmentId { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
