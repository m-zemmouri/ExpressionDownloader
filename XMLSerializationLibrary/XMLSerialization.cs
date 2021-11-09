using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace XMLSerializationLibrary
{

    public class XMLSerialization
    {
        #region XmlSerialization

        /// <summary>
        /// Serialize an Object To an XML Document
        /// </summary>
        /// <param name="ObjectToSerialize">The Object To Serialize</param>
        /// <param name="XMLFileName">The path of the Destination XML File</param>
        static public void WriteToXML(Object ObjectToSerialize, String XMLFileName)
        {
            XmlSerializer serializer = new XmlSerializer(ObjectToSerialize.GetType());
            TextWriter writer = new StreamWriter(XMLFileName);
            serializer.Serialize(writer, ObjectToSerialize);
            writer.Close();
        }

        /// <summary>
        /// DeSerialize an Object From an XML Document
        /// </summary>
        /// <param name="XMLFileName">The path of the XML File</param>
        /// <param name="ClassType">The Type of the Serialized Object</param>
        /// <returns>Object</returns>
        static public Object ReadFromXML(String XMLFileName, Type ClassType)
        {
            XmlSerializer serializer = new XmlSerializer(ClassType);
            FileStream fs = new FileStream(XMLFileName, FileMode.Open);
            return serializer.Deserialize(fs);
        }

        /// <summary>
        /// DeSerialize an Object From an XML Document
        /// </summary>
        /// <param name="XMLFileName">The path of the XML File</param>
        /// <param name="InstanceObject">An Object of the same Type With the Serialized Object</param>
        /// <returns>Object</returns>
        static public Object ReadFromXML(String XMLFileName, Object InstanceObject)
        {
            XmlSerializer serializer = new XmlSerializer(InstanceObject.GetType());
            FileStream fs = new FileStream(XMLFileName, FileMode.Open);
            return serializer.Deserialize(fs);
        }

        #endregion
    }
}