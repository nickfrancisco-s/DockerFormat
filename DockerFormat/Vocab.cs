using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DockerFormat
{
    public class Item
    {
        public string Type { get; set; }
        public System.Drawing.Color Color { get; set; }
        public string Name { get; set; }
        public string Help { get; set; }

        public Item()
        {

        }
    }
    class Vocab
    {
        private SortedDictionary<string, Item> m_Items;
        
        private DockerTypes Keywords;
        private bool m_isValid;

        

        public SortedDictionary<string, Item> Items
        {
            get { return m_Items; }
            set { m_Items = value; }
        }

        public bool IsValid
        {
            get { return m_isValid; }
            set { m_isValid = value; }
        }

        private Dictionary<string,System.Drawing.Color> m_Prefixes;

        public Dictionary<string,System.Drawing.Color> Prefixes
        {
            get { return m_Prefixes; }
            set { m_Prefixes = value; }
        }
        
               

        public Vocab(string JSonPath)
        {
            //init!
            m_Items = new SortedDictionary<string,Item>();

            //bold it in for now, but later make a JSON ting.
           
            Keywords = new DockerTypes(JSonPath);
            m_Prefixes = new Dictionary<string, System.Drawing.Color>();
           
            m_isValid = Keywords.IsValid;
                
            if(!m_isValid)
            {
                return;
            }

            int FamilyCount = Keywords.Lang.Types.Count;
            for(int i=0;i<FamilyCount;i++)
            {
                System.Drawing.Color FamilyColor = System.Drawing.ColorTranslator.FromHtml(Keywords.Lang.Types[i].Color);
                string FamilyName = Keywords.Lang.Types[i].Type;

                int ItemsInFamily = Keywords.Lang.Types[i].Defs.Count();
                for(int j=0;j<ItemsInFamily;j++)
                {
                    string Name = Keywords.Lang.Types[i].Defs[j].Name;
                    string Help = Keywords.Lang.Types[i].Defs[j].Help;

                    Item ThisOne = new Item(); ;
                    ThisOne.Color = FamilyColor;
                    ThisOne.Name = Name;
                    ThisOne.Help = Help;
                    ThisOne.Type = FamilyName;
                    if (!m_Items.ContainsKey(Name))
                    {
                        m_Items.Add(Name, ThisOne);
                    }

                    if (ThisOne.Type == "Prefixes")
                    {
                        if (!m_Prefixes.ContainsKey(Name))
                        {
                            m_Prefixes.Add(Name, FamilyColor);
                        }
                    }

                }                
            }

            foreach (KeyValuePair<string, DockerFormat.Item> Df in m_Items)
            {
               
            }

        }

    }
}
