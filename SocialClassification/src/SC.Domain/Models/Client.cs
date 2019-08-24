using System;
using SC.Domain.Models.Base;

namespace SC.Domain.Models
{
    public sealed class Client : Entity
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}