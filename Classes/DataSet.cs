using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public static class DataSet
    {
        public static DataBase Database { get; set; } = new DataBase();
        public static string PathFile { get; set; } = "Database.dbr";

        public static void SaveToFile()
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream(PathFile, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, Database);
                fStream.Close();
            }
        }
        public static void LoadIsFile()
        {
            if (File.Exists(PathFile))
            {
                FileInfo file = new FileInfo(PathFile);
                long size = file.Length;
                if (size > 0)
                {
                    FileStream fs = new FileStream(PathFile, FileMode.Open);
                    BinaryFormatter formatter = new BinaryFormatter();
                    
                    DataBase tempBase = (DataBase)formatter.Deserialize(fs);
                    Database.Clients = tempBase.Clients;
                    Database.Dishes = tempBase.Dishes;
                    Database.Menus = tempBase.Menus;
                    Database.Orders = tempBase.Orders;
                    Database.Waiters = tempBase.Waiters;
                    fs.Close();
                }
            }
        }
    }
}