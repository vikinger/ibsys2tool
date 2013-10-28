using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;


namespace ibsys2tool.XML
{
    class LoadXML
    {
        public bool ladeXML(string pfad)
        {
            bool result = false;
            string xmlText = string.Empty;
            // xmlLoad
            var doc = new XmlDocument();
            
            //xml saubern und in xmlText speichern
            using (var sr = new StreamReader(pfad, Encoding.UTF8))
            {
                string zeile;
                while ((zeile = sr.ReadLine()) != null)
                {
                    //var r = new Regex(@"^\s+");
                    var r = new Regex("(?s)<!--.*?-->");
                    zeile = r.Replace(zeile, "");
                    //zeile = zeile.Replace("\r\n", string.Empty);
                   // zeile = zeile.Replace("<!-- \w -->", string.Empty);
                    //if (zeile.Contains("results"))
                    result = true;
                    xmlText += zeile;
                }
                if (result == false)
                    return result;
            }
            doc.LoadXml(xmlText);
            schreibeObjekte(doc);
            return false;
        }

        public void schreibeObjekte(XmlDocument doc)
        {
            string id;
            string menge;
            string startMenge;
            string pct;
            string preis;
            string stockvalue;

            

            XmlNodeList articleList = null;
            XmlNodeList idletimecosts = doc.SelectNodes("/results/idletimecosts/workplace");

            articleList = doc.GetElementsByTagName("article");

            //Liste des warehousestocks
            foreach (XmlNode xmlNode in articleList)
            {
                Console.WriteLine(xmlNode.Attributes["id"].Value + xmlNode.Attributes["amount"].Value + 
                    xmlNode.Attributes["startamount"].Value + xmlNode.Attributes["pct"].Value + xmlNode.Attributes["price"].Value + 
                    xmlNode.Attributes["stockvalue"].Value);
            }

            //Liste des inwardstockmovements
            foreach (XmlNode xmlNode in doc.DocumentElement.ChildNodes[1].ChildNodes)
            {
               Console.WriteLine( xmlNode.Attributes["orderperiod"].Value +  xmlNode.Attributes["id"].Value + 
                   xmlNode.Attributes["mode"].Value + xmlNode.Attributes["article"].Value + xmlNode.Attributes["amount"].Value 
                   + xmlNode.Attributes["time"].Value + xmlNode.Attributes["materialcosts"].Value + xmlNode.Attributes["ordercosts"].Value
                   + xmlNode.Attributes["entirecosts"].Value + xmlNode.Attributes["piececosts"].Value);
            }
            //Liste des futureinwardstockmovement
            foreach (XmlNode xmlNode in doc.DocumentElement.ChildNodes[2].ChildNodes)
            {
                Console.WriteLine(xmlNode.Attributes["orderperiod"].Value + xmlNode.Attributes["id"].Value +
                    xmlNode.Attributes["mode"].Value + xmlNode.Attributes["article"].Value + xmlNode.Attributes["amount"].Value);
            }
          
            //Liste der idletimecosts
            //Liste des futureinwardstockmovement
            foreach (XmlNode xmlNode in idletimecosts)
            {
                    Console.WriteLine(xmlNode.Attributes["id"].Value + xmlNode.Attributes["setupevents"].Value + xmlNode.Attributes["idletime"].Value + xmlNode.Attributes["wageidletimecosts"].Value +
                                      xmlNode.Attributes["wagecosts"].Value + xmlNode.Attributes["machineidletimecosts"].Value);
             
            }

        }
        
    }
}
