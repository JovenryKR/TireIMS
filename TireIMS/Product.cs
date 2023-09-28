using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TireIMS
{
    internal class Product
    {
        public ObjectId Id { get; set; }
        public string Size { get; set; }
        public string Pattern { get; set; }
        public string Brand { get; set; }
        public float Price { get; set; }
        public int QTY { get; set; }
    } 
}
