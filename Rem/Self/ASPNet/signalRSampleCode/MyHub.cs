using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Dnb.SB.Utils.DAC;

namespace Dnb.SB.Web.WebClient
{
    public class SBHub : Hub
    {
        private static int _MaxItemsDisplay = -1;
        public static int MaxItemsDisplay
        {
            get
            {
                if (_MaxItemsDisplay == -1)
                {
                    var QUICKSEARCHITEMSCOUNT = SystemConfiguration.GetConfigValueByKey("QUICKSEARCHITEMSCOUNT");
                    if (!string.IsNullOrEmpty(QUICKSEARCHITEMSCOUNT))
                        _MaxItemsDisplay = Convert.ToInt32(QUICKSEARCHITEMSCOUNT);
                    else
                        _MaxItemsDisplay = 5;
                }
                return _MaxItemsDisplay;
            }
        }

        public void SendNotifications(string SearchName, Boolean consumersearch)
        {
            var defaultCultureCode = SystemConfiguration.GetConfigValueByKey("DefaultCultureCode");
            List<string> NameList = null;
            string currCulture = System.Threading.Thread.CurrentThread.CurrentCulture.Name;

            if (consumersearch)
            {
                if (currCulture.ToUpper().Equals(defaultCultureCode.ToUpper()))
                    NameList = SearchNameListConfig.ConsumerNameListEN;
                else
                    NameList = SearchNameListConfig.ConsumerNameListAR;
            }
            else
            {
                if (currCulture.ToUpper().Equals(defaultCultureCode.ToUpper()))
                    NameList = SearchNameListConfig.CommercialNameListEN;
                else
                    NameList = SearchNameListConfig.CommercialNameListAR;
            }

            var MatchingNames = NameList.Where(stringToCheck => stringToCheck.StartsWith(SearchName.ToUpper()));

            var TopNames = (from Name in MatchingNames select Name).Take(MaxItemsDisplay);
            Clients.Client(Context.ConnectionId).receiveNotification(TopNames);
        }
        public override System.Threading.Tasks.Task OnConnected()
        {

            return base.OnConnected();
        }
        public override System.Threading.Tasks.Task OnDisconnected(bool stopCalled)
        {
            return base.OnDisconnected(stopCalled);
        }
        public override System.Threading.Tasks.Task OnReconnected()
        {
            return base.OnReconnected();
        }
    }



    public class DashboardHub : Hub
    {
        public DashboardHub()
        {

        }
        private bool IsClientConnected = true;
        public void pushDashboardData(string queryParam)
        {
            while (true)
            {
                if (!IsClientConnected) break;
                Clients.Client(Context.ConnectionId).flush("{'dashboardId':'rewre',queryParam:'" + queryParam + "'}");
                System.Threading.Thread.Sleep(5000);
            }

        }


        public override System.Threading.Tasks.Task OnConnected()
        {

            return base.OnConnected();
        }
        public override System.Threading.Tasks.Task OnDisconnected(bool stopCalled)
        {
            IsClientConnected = false;
            return base.OnDisconnected(stopCalled);
        }
        public override System.Threading.Tasks.Task OnReconnected()
        {
            return base.OnReconnected();
        }


    }

}