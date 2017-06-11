using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PrdEditor.Utils
{    
    /// <summary>
    /// Az alkalmazás verzió lekérdezése.
    /// </summary>
    class ApplicationUtil
    {
        private static ApplicationUtil instance;
        private string applicationName;        
        private Version applicationVersion;       

        protected ApplicationUtil()
        {
            applicationVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
        }

        public static ApplicationUtil Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ApplicationUtil();                    
                }
                return instance;
            }
        }

        //getters/setters------------------------------------------------------
        #region

        public string ApplicationName
        {
            get
            {
                return applicationName;
            }

            set
            {
                applicationName = value;
            }
        }

        public string ApplicationVersion
        {
            get
            {
                return AppVersion.Major + "." + AppVersion.Minor;  
            }            
        }

        public Version AppVersion
        {
            get
            {
                return applicationVersion;
            }

            set
            {
                applicationVersion = value;
            }
        }
        #endregion
    }
}
