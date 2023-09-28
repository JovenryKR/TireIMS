using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TireIMS
{
    internal class User
    {
        public ObjectId Id {  get; set; }  
        public string Username { get; set; }
        public string Password { get; set; }
        public int Access_Level { get; set; }
    }
}
