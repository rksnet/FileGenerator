using System.IO;
using System.Xml.Serialization;


namespace BusinessLayer.Common
{
    public static class Utility
    {
        /// <summary>
        /// Generic method to Deserialize any xml string to object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static T DeserializeFromXml<T>(string xml)
        {
            if (string.IsNullOrEmpty(xml))
                return default(T);
            T result;
            var ser = new XmlSerializer(typeof(T));
            using (var tr = new StringReader(xml))
            {
                result = (T)ser.Deserialize(tr);
            }
            return result;
        }

    }
}
