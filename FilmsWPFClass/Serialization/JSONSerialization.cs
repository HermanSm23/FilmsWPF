using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;

namespace FilmsWPFClass.Serialization
{
    public class JSONSerialization : ISerialize
    {
        public void SaveData<T>(List<T> data, String filePath)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(T[]));
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, data.ToArray());
            }
        }

        public List<T> RestoreData<T>(String filePath)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(T[]));
            List<T> restoredData = new List<T>();
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                T[] data = (T[])jsonFormatter.ReadObject(fs);
                restoredData.AddRange(data);
            }
            return restoredData;
        }
    }
}
