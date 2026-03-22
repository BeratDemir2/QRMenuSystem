namespace QRMenuSystem.Models
{
    public class Table
    {
        // Masanın benzersiz kimliği (Primary Key)
        public int Id { get; set; }

        // Masanın numarası (1, 2, 3...)
        public int TableNumber { get; set; }

        // Masanın durumu: "Empty" (Boş) veya "Occupied" (Dolu)
        public string Status { get; set; } = "Empty";

        // Bu masadan verilen siparişleri tutar (EF Core için)
        public ICollection<Order>? Orders { get; set; }
    }
}