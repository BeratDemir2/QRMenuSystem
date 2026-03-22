namespace QRMenuSystem.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }

        // Foreign Key: Hangi siparişe ait
        public int OrderId { get; set; }

        // Foreign Key: Hangi yemekten sipariş edildi
        public int MenuItemId { get; set; }

        public int Quantity { get; set; } // Adet

        // Bağlantılar (Navigation Properties)
        public Order Order { get; set; }
        public MenuItem MenuItem { get; set; }
    }
}