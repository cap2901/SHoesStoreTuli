using System;

namespace CoV.DataAccess.Data
{
    public class Contact
    {
        public int Id { get; set; }
        
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        
        public  string Information { get; set; }
        
        public DateTime CreaDateTime { get; set; }
    }
}