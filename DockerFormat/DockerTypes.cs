using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DockerFormat;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DockerFormat
{

    public class DockerTypes
    {
        private DockerFormat.Language DaLang= null;
        private bool m_isvalid;
        private string jsonString;

        public bool IsValid
        {
            get { return m_isvalid; }
            set { m_isvalid = value; }
        }

        public DockerFormat.Language Lang
        {
            get { return DaLang; }           
        }

        public DockerTypes( string JsonPath)
        {
            //assume is kosher. be optimistic
            m_isvalid = true;
            jsonString ="";
           

            //Read Json to string
            if (!File.Exists(JsonPath)) 
            {
                m_isvalid = false;
                return ;
                //boke
            }

            //if (File.Exists(JsonPath))
            //{
            //    JsonConvert.DeserializeObject<DockerFormat.Language>();
            //}

            jsonString = File.ReadAllText(JsonPath);

            DaLang = Language.FromJson(jsonString);
        }
    }
}
