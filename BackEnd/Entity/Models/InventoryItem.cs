using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class InventoryItem
    {
        // This class will represent a single inventory item (e.g., dental tools, supplies like gloves, toothpaste, etc.).
        public int Id { get; set; } // Unique identifier for the inventory item
        public string Name { get; set; } // Name of the item (e.g., "Dental Gloves", "Tooth Filling Material")
        public string Description { get; set; } // A detailed description of the item
        public decimal UnitPrice { get; set; } // Price per unit of the item
        public int QuantityInStock { get; set; } // Quantity of the item currently in stock
        public int ReorderLevel { get; set; } // The minimum quantity before replenishment is needed
        public bool IsActive { get; set; } // Whether the item is active in the inventory system

        public DateTime? CreatedDate { get; set; }  // Bu özellik artık nullable değil ve tip belirtilmiş.
        public DateTime? UpdatedDate { get; set; } // Nullable DateTime
    }
}
