namespace HPlusSport.Ecommerce.Data.Entities
{
    public partial class CartProduct
    {
        public int CartProductId { get; set; }

        public int CartId { get; set; }

        public int ProductId { get; set; }

        public virtual Cart Cart { get; set; }

        public virtual Product Product { get; set; }
    }
}