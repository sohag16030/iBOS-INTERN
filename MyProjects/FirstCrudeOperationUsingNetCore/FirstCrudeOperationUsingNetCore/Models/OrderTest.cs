using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstCrudeOperationUsingNetCore.Models
{
    public partial class OrderTest
    {
        [Key]
        [Column("intOrderID")]
        public long IntOrderId { get; set; }
        [Required]
        [Column("strOrderNumber")]
        [StringLength(50)]
        public string StrOrderNumber { get; set; }
        [Column("intPersonID")]
        public long IntPersonId { get; set; }

        [ForeignKey(nameof(IntPersonId))]
        [InverseProperty(nameof(PersonTest.OrderTest))]
        public virtual PersonTest IntPerson { get; set; }
    }
}
