using System;

namespace CoV.Service.DataModel
{
    public class ContactViewModel
    {
        public int Id { get; set; }
        
        /// <summary>
        /// customer 
        /// </summary>
        public int CustomerId { get; set; }
        public CustomerViewModel Customer { get; set; }
        
        /// <summary>
        /// information messager
        /// </summary>
        public  string Information { get; set; }
        
        public DateTime CreaDateTime { get; set; }
    }
}