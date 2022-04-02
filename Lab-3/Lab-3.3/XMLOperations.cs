using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Lab_3
{
    internal class XMLOperations<T>
    {

        Type dataType;
        public string filePath;

        public XMLOperations()
        {
            dataType = typeof(T);
        }

        public XMLOperations(string filePath)
        {
            this.filePath = filePath + ".xml";
            dataType = typeof(T);
        }

        public T Load()
        {
            TextReader tr = new StreamReader(filePath);
            XmlSerializer reader = new XmlSerializer(dataType);
            T instance = (T)reader.Deserialize(tr);
            tr.Close();
            return instance;
        }

        public void Save(object obj)
        {
            TextWriter tw = new StreamWriter(filePath);
            XmlSerializer writer = new XmlSerializer(dataType);
            writer.Serialize(tw, obj);
            tw.Close();
        }
    }
}
