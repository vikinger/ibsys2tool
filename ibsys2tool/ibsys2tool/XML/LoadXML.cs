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
            XmlNodeList articleList = null;
            XmlNodeList inwardStockMovement = doc.SelectNodes("/results/inwardstockmovement/order");
            XmlNodeList futureInwardStockMovement = doc.SelectNodes("/results/futureinwardstockmovement/order");
            XmlNodeList idleTimeCosts = doc.SelectNodes("/results/idletimecosts/workplace");
            XmlNodeList waitingListWorkstations = doc.SelectNodes("/results/waitinglistworkstations/workplace");
            XmlNodeList waitingListStock = doc.SelectNodes("/results/waitingliststock/missingpart");
            XmlNodeList ordersInWork = doc.SelectNodes("/results/ordersinwork/workplace");
            XmlNodeList completedOrders = doc.SelectNodes("/results/completedorders/order");
            XmlNodeList cycletimes = doc.SelectNodes("/results/cycletimes");



            articleList = doc.GetElementsByTagName("article");

            //Liste des warehousestocks
            foreach (XmlNode xmlNode in articleList)
            {
                Console.WriteLine(xmlNode.Attributes["id"].Value + xmlNode.Attributes["amount"].Value +
                    xmlNode.Attributes["startamount"].Value + xmlNode.Attributes["pct"].Value + xmlNode.Attributes["price"].Value +
                    xmlNode.Attributes["stockvalue"].Value);
            }

            //Liste des inwardstockmovements
            foreach (XmlNode xmlNode in inwardStockMovement)
            {
                Console.WriteLine(xmlNode.Attributes["orderperiod"].Value + xmlNode.Attributes["id"].Value +
                    xmlNode.Attributes["mode"].Value + xmlNode.Attributes["article"].Value + xmlNode.Attributes["amount"].Value
                    + xmlNode.Attributes["time"].Value + xmlNode.Attributes["materialcosts"].Value + xmlNode.Attributes["ordercosts"].Value
                    + xmlNode.Attributes["entirecosts"].Value + xmlNode.Attributes["piececosts"].Value);
            }
            //Liste des futureinwardstockmovement
            foreach (XmlNode xmlNode in futureInwardStockMovement)
            {
                Console.WriteLine(xmlNode.Attributes["orderperiod"].Value + xmlNode.Attributes["id"].Value +
                    xmlNode.Attributes["mode"].Value + xmlNode.Attributes["article"].Value + xmlNode.Attributes["amount"].Value);
            }

            //Liste der idletimecosts
            foreach (XmlNode xmlNode in idleTimeCosts)
            {
                Console.WriteLine(xmlNode.Attributes["id"].Value + xmlNode.Attributes["setupevents"].Value + xmlNode.Attributes["idletime"].Value + xmlNode.Attributes["wageidletimecosts"].Value +
                                  xmlNode.Attributes["wagecosts"].Value + xmlNode.Attributes["machineidletimecosts"].Value);

            }
            //Liste der waitinglistworkstations
            foreach (XmlNode xmlNode in waitingListWorkstations)
            {
                if (xmlNode.Attributes["timeneed"].Value != "0")
                {
                    Console.WriteLine(xmlNode.Attributes["id"].Value + xmlNode.Attributes["timeneed"].Value);
                    foreach (XmlNode xNodeInner in xmlNode.ChildNodes)
                    {
                        Console.WriteLine(xNodeInner.Attributes["period"].Value + xNodeInner.Attributes["order"].Value +
                            xNodeInner.Attributes["firstbatch"].Value + xNodeInner.Attributes["lastbatch"].Value +
                            xNodeInner.Attributes["item"].Value + xNodeInner.Attributes["amount"].Value +
                            xNodeInner.Attributes["timeneed"].Value);
                    }
                }
            }


            //Liste der waitingListStock
            foreach (XmlNode xmlNode in waitingListStock)
            {
                Console.WriteLine(xmlNode.Attributes["id"].Value);
                foreach (XmlNode xNodeInner in xmlNode.ChildNodes)
                {
                    Console.WriteLine(xNodeInner.Attributes["period"].Value + xNodeInner.Attributes["order"].Value +
                        xNodeInner.Attributes["firstbatch"].Value + xNodeInner.Attributes["lastbatch"].Value +
                        xNodeInner.Attributes["item"].Value + xNodeInner.Attributes["amount"].Value);
                }
            }
            //Liste der ordersInWork
            foreach (XmlNode xmlNode in ordersInWork)
            {
                Console.WriteLine(xmlNode.Attributes["id"].Value + xmlNode.Attributes["period"].Value +
                    xmlNode.Attributes["order"].Value + xmlNode.Attributes["batch"].Value +
                    xmlNode.Attributes["item"].Value + xmlNode.Attributes["amount"].Value + xmlNode.Attributes["timeneed"].Value);
            }

            //Liste der completedorders
            foreach (XmlNode xmlNode in completedOrders)
            {
                Console.WriteLine(xmlNode.Attributes["period"].Value + xmlNode.Attributes["id"].Value +
                    xmlNode.Attributes["item"].Value + xmlNode.Attributes["quantity"].Value +
                    xmlNode.Attributes["cost"].Value + xmlNode.Attributes["averageunitcosts"].Value);
                foreach (XmlNode xNodeInner in xmlNode.ChildNodes)
                {
                    Console.WriteLine(xNodeInner.Attributes["id"].Value + xNodeInner.Attributes["amount"].Value +
                        xNodeInner.Attributes["cycletime"].Value + xNodeInner.Attributes["cost"].Value);
                }
            }


            //Liste der cycletimes
            foreach (XmlNode xmlNode in cycletimes)
            {
                Console.WriteLine(xmlNode.Attributes["startedorders"].Value + xmlNode.Attributes["waitingorders"].Value);
                foreach (XmlNode xNodeInner in xmlNode.ChildNodes)
                {
                    Console.WriteLine(xNodeInner.Attributes["id"].Value + xNodeInner.Attributes["period"].Value +
                        xNodeInner.Attributes["starttime"].Value + xNodeInner.Attributes["finishtime"].Value +
                        xNodeInner.Attributes["cycletimemin"].Value + xNodeInner.Attributes["cycletimefactor"].Value);
                }
            }
        }

    }
}
