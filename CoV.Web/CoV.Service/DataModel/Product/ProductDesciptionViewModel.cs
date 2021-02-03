namespace CoV.Service.DataModel
{
    public class ProductDesciptionViewModel
    {
        public int  Id { get; set; }
        
        public  int ProductId { get; set; }
        public ProductViewModel Product { get; set; }
        
        public string Description { get; set; }
    }
}