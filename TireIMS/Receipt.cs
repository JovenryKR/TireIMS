using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TireIMS
{
    internal class Receipt
    {
        public ObjectId Id { get; set; }
        public List<Product> Products { get; set; }
        public float TotalAmount { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
