using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ZEMMOURI_Downloader.Downloader
{
    /// <summary>
    /// The Connexion Parameter
    /// </summary>
    public class ConnexionParameter
    {
        #region Constructor

        /// <summary>
        /// Constructor of ConnexionParameter
        /// </summary>
        public ConnexionParameter()
        {
        }

        /// <summary>
        /// Constructor of ConnexionParameter
        /// </summary>
        /// <param name="User">The user name</param>
        /// <param name="Pwd">The PassWord</param>
        /// <param name="ProxyURI">The URI of the proxy server.</param>
        public ConnexionParameter(string User,string Pwd,string ProxyURI)
        {
            this.user = User;
            this.passWord = Pwd;
            this.proxy = ProxyURI;
        }

        #endregion

        #region Variables

        /// <summary>
        /// The user name
        /// </summary>
        private string user;

        /// <summary>
        /// The PassWord
        /// </summary>
        private string passWord;

        
        /// <summary>
        /// The URI of the proxy server.
        /// </summary>
        private string proxy;


        #endregion

        #region Proprieties

        /// <summary>
        /// The user name
        /// </summary>
        public string User
        {
            get
            {
                return user;
            }
            set
            {
                user = value;
            }
        }
        /// <summary>
        /// The PassWord
        /// </summary>
        public string PassWord
        {
            get
            {
                return passWord;
            }
            set
            {
                passWord = value;
            }
        }

        /// <summary>
        /// The URI of the proxy server.
        /// </summary>
        public string Proxy
        {
            get
            {
                return proxy;
            }
            set
            {
                proxy = value;
            }
        }
        
        #endregion

        #region Methodes

        #endregion
    }
}