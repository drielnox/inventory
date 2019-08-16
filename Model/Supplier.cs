using System;

namespace SmartInventorySystem.Model
{
    public class Supplier : IAuditable
    {
        public int Identifier { get; set; }
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string ModifiedBy { get; set; }
    }
}
