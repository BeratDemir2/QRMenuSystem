namespace QRMenuSystem.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Fiyat için ondalık tip (decimal) kullanıyoruz
        public decimal Price { get; set; }

        public string Description { get; set; } // İçindekiler
        public string PhotoPath { get; set; } // Fotoğrafın web adresi
        public int Calories { get; set; }

        public bool IsVegan { get; set; } = false;
        public string Allergens { get; set; } // Örn: "Gluten, Lactose"

        // Bu menü öğesinin geçtiği sipariş detayları
        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
} 
