/*
* ============================================================================
* THIS CODE IS GENERATED BY 'ClasseCodeGenerator'
* ZEMMOURI Mohamed m.zemmouri@gmail.com
* ============================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;


namespace ZEMMOURI_Downloader.File_SourceDestination
{
    /// <summary>
    /// Describes a List of Files to Download, it is a List of FileDownloadInfo
    /// </summary>
    public class ListFileSourceDestination
    {
        #region Constructor

        /// <summary>
        /// Constructor of ListFileDownloadInfo
        /// </summary>
        public ListFileSourceDestination()
        {

        }

        /// <summary>
        /// Constructor of ListFileDownloadInfo
        /// </summary>
        /// <param name="Expression">Expression to Download</param>
        public ListFileSourceDestination(ExpressionDownload Expression)
        {
            items = Expression.Evaluate();
        }

        #endregion

        #region Variables


        /// <summary>
        /// List of FileDownloadInfo
        /// </summary>
        private List<FileSourceDestination> items = new List<FileSourceDestination>();

        #endregion

        #region Proprieties


        /// <summary>
        /// List of FileDownloadInfo
        /// </summary>
        [XmlArrayAttribute("Items")]
        public List<FileSourceDestination> Items
        {
            get
            {
                return items;
            }
            set
            {
                items = value;
            }
        }

        #endregion

        #region Methodes

        
        #endregion

        #region Indexor

        /// <summary>
        /// Indexor of ListFileDownloadInfo
        /// </summary>
        /// <param name="i">Item Ranke</param>
        /// <returns>FileDownloadInfo</returns>
        public FileSourceDestination this[int i]
        {
            get
            {
                return items[i];
            }
            set
            {
                items[i] = value;
            }
        }

        #endregion

        #region XmlSerialization

        /// <summary>
        /// Export a List of FileDownloadInfo To an XML File
        /// </summary>
        /// <param name="list">List of FileDownloadInfo</param>
        /// <param name="XMLFileName">The path of the Destination XML File</param>
        static public void WriteToXML(ListFileSourceDestination list, String XMLFileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ListFileSourceDestination));
            TextWriter writer = new StreamWriter(XMLFileName);
            serializer.Serialize(writer, list);
            writer.Close();
        }

        /// <summary>
        /// Import a List of FileDownloadInfo from an XML File
        /// </summary>
        /// <param name="XMLFileName">The path of the XML File</param>
        /// <returns>ListFileDownloadInfo</returns>
        static public ListFileSourceDestination ReadFromXML(String XMLFileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ListFileSourceDestination));
            FileStream fs = new FileStream(XMLFileName, FileMode.Open);
            return (ListFileSourceDestination)serializer.Deserialize(fs);
        }

        #endregion

    }
}