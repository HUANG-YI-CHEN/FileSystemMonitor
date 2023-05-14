using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;

namespace FileSystemMonitor.Lib
{
    public static class XmlUtil
    {
        public static void SerializeToXml(string fileName, object obj)
        {
            Stream stream = null;
            StreamWriter writer = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(obj.GetType());
                stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.Read);
                writer = new StreamWriter(stream, Encoding.UTF8);
                xml.Serialize(writer, obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (stream != null && writer != null)
                {
                    stream.Close();
                    writer.Close();
                    stream.Dispose();
                    writer.Dispose();
                }
            }
        }

        public static T DeserializeFromXml<T>(string FileName)
        {
            Stream stream = null;
            StreamReader reader = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));
                stream = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                reader = new StreamReader(stream, Encoding.UTF8);
                object obj = xml.Deserialize(reader);
                return (T)obj;
            }
            catch
            {
                return default;
            }
            finally
            {
                if(stream!=null && reader!=null)
                {
                    stream.Close();
                    reader.Close();
                    stream.Dispose();
                    reader.Dispose();
                }            
            }
        }

        public static DataTable List2DataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }

        public static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        public static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }
    }
}
