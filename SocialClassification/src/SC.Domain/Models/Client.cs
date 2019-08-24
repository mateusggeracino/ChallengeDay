using System;
using System.ComponentModel.DataAnnotations.Schema;
using SC.Domain.Models.Base;

namespace SC.Domain.Models
{
    [Table("Persons")]
    public sealed class Client : Entity
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}