namespace EFTuts.Data.Repository.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }

        public virtual Category Category { get; set; }
        public int CategoryID { get; set; }
    }
}
