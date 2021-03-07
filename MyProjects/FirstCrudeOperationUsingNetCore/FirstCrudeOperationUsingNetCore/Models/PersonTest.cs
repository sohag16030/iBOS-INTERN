using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstCrudeOperationUsingNetCore.Models
{
    public partial class PersonTest
    {
        public PersonTest()
        {
            OrderTest = new HashSet<OrderTest>();
        }

        [Key]
        [Column("intPersonID")]
        public long IntPersonId { get; set; }
        [Required]
        [Column("strName")]
        [StringLength(50)]
        public string StrName { get; set; }
        [Required]
        [Column("strAddress")]
        [StringLength(50)]
        public string StrAddress { get; set; }
        public int Age { get; set; }

        [InverseProperty("IntPerson")]
        public virtual ICollection<OrderTest> OrderTest { get; set; }
    }
}
