using MongoDB.Driver;
using PowerView.DataAccess.MongoDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.DataAccess
{
    public class MongoDBUtil
    {
        public static void InsertOne<Type>(Type value)
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("powerView");          
            var collection = db.GetCollection<Type>(value.GetType().Name);
            collection.InsertOne(value);
        }
    }
}
