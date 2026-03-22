namespace QRMenuSystem.Models
{
    public class Order
    {
        public int Id { get; set; }

        // Foreign Key: Hangi masadan sipariş verildiğini gösterir
        public int TableId { get; set; }

        // Siparişin verildiği tarih ve saat
        public DateTime OrderDate { get; set; } = DateTime.Now;

        // Siparişin durumu: "Pending", "Preparing", "Ready"
        public string Status { get; set; } = "Pending";

        // Bağlantı (Navigation Property)
        public Table Table { get; set; }

        // Siparişin içindeki ürünlerin listesi
        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}