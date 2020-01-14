using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DockerFormat
{
    class Vocab
    {
        private SortedDictionary<string, string> m_Var_Type;
        private SortedDictionary<string, System.Drawing.Color> m_Type_Color;

        public SortedDictionary<string, string> Var_Type
        {
            get { return m_Var_Type; }
            set { m_Var_Type = value; }
        }

        public SortedDictionary<string, System.Drawing.Color> Type_Color        
        {
            get { return m_Type_Color; }
            set { m_Type_Color = value; }
        }

        public Vocab(string JSonPath)
        {
            //init!
            m_Var_Type = new SortedDictionary<string, string>();
            Type_Color = new SortedDictionary<string,System.Drawing.Color>();

            //bold it in for now, but later make a JSON ting.

            //do col0r first

            //Type_Color.Add("VARIABLE")


        }

    }
}
