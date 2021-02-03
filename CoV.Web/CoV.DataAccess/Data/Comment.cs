namespace CoV.DataAccess.Data
{
    public class Comment
    {
        public int Id { get; set; }
        
        public int ProductId { get; set; }
        public Product Product { get; set; }
        
        public string CommentProduct { get; set; }
    }
}