using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections;
using System.Drawing;

namespace TireIMS
{
    internal class mongodb_drivers
    {
        private MongoClient _client;
        private IMongoDatabase database; 
        

        public mongodb_drivers(string databaseName)
        {
            string connectionString = "mongodb://localhost:27017"; 
            _client = new MongoClient(connectionString); //Mongodb structure
            database = _client.GetDatabase(databaseName); 
            
        }
        //Check if the user exists
        public bool CheckCredentials(string username, string password)
        {
            var collection = database.GetCollection<User>("users"); 
            var filter = Builders<User>.Filter.Eq(u => u.Username, username) & Builders<User>.Filter.Eq(u => u.Password, password);
            var user = collection.Find(filter).FirstOrDefault();
            return user != null;
        }

        //Check if the product exists
        public bool CheckProduct(string size, string pattern, string brand, float Price, int QTY)
        {
            var collection = database.GetCollection<Product>("products");
            var filter = Builders<Product>.Filter.Eq(p => p.Size, size) & Builders<Product>.Filter.Eq(p => p.Pattern, pattern) & Builders<Product>.Filter.Eq(p => p.Brand, brand);
            var product = collection.Find(filter).FirstOrDefault();
            return product != null;
        }


        //Insert Product
        public async Task insertProduct(Product product)
        {
            bool productExist = CheckProduct(product.Size, product.Pattern, product.Brand, product.Price, product.QTY);

            if (productExist)
            {
                Console.WriteLine("Product Already exist");
            }
            else
            {
                var collection = database.GetCollection<Product>("products");
                await collection.InsertOneAsync(product);

            }
        }

        //Search product

        public async Task<Product> SearchProduct(string size)
        {
            var collection = database.GetCollection<Product>("products");
            var filter = Builders<Product>.Filter.Eq(p => p.Size, size);

            var product = collection.Find(filter).FirstOrDefault();
            return  (product != null) ? product : null;
        }

        // Search Product for data grid view for sell
        public async Task<List<Product>> SearchProductToList(string size)
        {
            var collection = database.GetCollection<Product>("products");
            var filter = Builders<Product>.Filter.Eq(p => p.Size, size);

            var products = await collection.Find(filter).ToListAsync();
            return products;
        }
        
        //Get all Product
        public async Task<List<Product>> GetAllProducts()
        {
            var collection = database.GetCollection<Product>("products");
            var filter = Builders<Product>.Filter.Empty; 

            var products = await collection.Find(filter).ToListAsync();
            return products;
        }


        //update product 
        public async Task Updateproduct(Product notUpdatedPrpduct ,Product updatedProduct)
        {
            var collection = database.GetCollection<Product>("products");
            //var filter = Builders<Product>.Filter.Eq(p => p.Size, notUpdatedPrpduct.Size) & Builders<Product>.Filter.Eq(p => p.Pattern, notUpdatedPrpduct.Pattern) & Builders<Product>.Filter.Eq(p => p.Brand, notUpdatedPrpduct.Brand);
            var filter = Builders<Product>.Filter.Eq(p => p.Size, notUpdatedPrpduct.Size)
                & Builders<Product>.Filter.Eq(p => p.Pattern, notUpdatedPrpduct.Pattern)
                & Builders<Product>.Filter.Eq(p => p.Brand, notUpdatedPrpduct.Brand)
                & Builders<Product>.Filter.Eq(p => p.Price, notUpdatedPrpduct.Price)
                & Builders<Product>.Filter.Eq(p => p.QTY, notUpdatedPrpduct.QTY);

            var update = Builders<Product>.Update
                .Set(p => p.Size, updatedProduct.Size)
                .Set(p => p.Pattern, updatedProduct.Pattern)
                .Set(p => p.Brand, updatedProduct.Brand)
                .Set(p => p.Price, updatedProduct.Price)
                .Set(p => p.QTY, updatedProduct.QTY);

            await collection.UpdateOneAsync(filter, update);
        }

        //Delete Product
        public async Task DeleteProduct(Product productToDelete)
        {
            var collection = database.GetCollection<Product>("products");
            var deleteFilter = Builders<Product>.Filter.Eq("_id", productToDelete.Id);

            await collection.DeleteOneAsync(deleteFilter);
            MessageBox.Show("Product Deleted!");
        }

        // decrement the product qty

        public async Task DecrementProductQty(Dictionary<ObjectId, int> product)
        {
            var collection = database.GetCollection<Product>("products");
            foreach (var item in product)
            {
                ObjectId id = item.Key;
                int quantityToDecrement = item.Value;

                var filter = Builders<Product>.Filter.Eq("_id", id);
                var update = Builders<Product>.Update.Set(p => p.QTY, quantityToDecrement);
                await collection.UpdateOneAsync(filter, update);
            }
        }

        //Create Receipt
        public async Task CreateReceipt(Receipt receipt)
        {
            var collection = database.GetCollection<Receipt>("receipts");

            await collection.InsertOneAsync(receipt);
        }

        //Daily sale
        public async Task<List<Receipt>> GetDailyReceipts(DateTime date)
        {
            var collection = database.GetCollection<Receipt>("receipts");

            // Define a filter for receipts on the specified date
            var startOfDay = date.Date;  // Midnight of the specified date
            var endOfDay = startOfDay.AddDays(1);  // Midnight of the next day
            var filter = Builders<Receipt>.Filter.Gte(r => r.PurchaseDate, startOfDay) &
                         Builders<Receipt>.Filter.Lt(r => r.PurchaseDate, endOfDay);
            var receipts = await collection.Find(filter).ToListAsync();
            return receipts;
        }

            // Create user function
            public async Task CreateUser(User user)
        {
            bool usernameExist = await CheckIfUsernameExist(user.Username);
            var collection = database.GetCollection<User>("users");

            if (usernameExist)
            {
                MessageBox.Show("Username already exist");
            } else
            {
                await collection.InsertOneAsync(user);
                MessageBox.Show("User Created");
            }
        }

        

        //Check if user is exist
        private async Task<bool> CheckIfUsernameExist(string username)
        {
            var collection = database.GetCollection<User>("users");
            var filter = Builders<User>.Filter.Eq(u => u.Username, username);
            var user = await collection.Find(filter).FirstOrDefaultAsync();
            return user != null;
        }

        
    }
}