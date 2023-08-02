using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Trello
{
    

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class LabelNames
    {
        public string green { get; set; }
        public string yellow { get; set; }
        public string orange { get; set; }
        public string red { get; set; }
        public string purple { get; set; }
        public string blue { get; set; }
        public string sky { get; set; }
        public string lime { get; set; }
        public string pink { get; set; }
        public string black { get; set; }
        public string green_dark { get; set; }
        public string yellow_dark { get; set; }
        public string orange_dark { get; set; }
        public string red_dark { get; set; }
        public string purple_dark { get; set; }
        public string blue_dark { get; set; }
        public string sky_dark { get; set; }
        public string lime_dark { get; set; }
        public string pink_dark { get; set; }
        public string black_dark { get; set; }
        public string green_light { get; set; }
        public string yellow_light { get; set; }
        public string orange_light { get; set; }
        public string red_light { get; set; }
        public string purple_light { get; set; }
        public string blue_light { get; set; }
        public string sky_light { get; set; }
        public string lime_light { get; set; }
        public string pink_light { get; set; }
        public string black_light { get; set; }
    }

    public class Prefs
    {
        public string permissionLevel { get; set; }
        public bool hideVotes { get; set; }
        public string voting { get; set; }
        public string comments { get; set; }
        public string invitations { get; set; }
        public bool selfJoin { get; set; }
        public bool cardCovers { get; set; }
        public bool isTemplate { get; set; }
        public string cardAging { get; set; }
        public bool calendarFeedEnabled { get; set; }
        public List<object> hiddenPluginBoardButtons { get; set; }
        public List<SwitcherView> switcherViews { get; set; }
        public string background { get; set; }
        public string backgroundColor { get; set; }
        public string backgroundImage { get; set; }
        public object backgroundImageScaled { get; set; }
        public bool backgroundTile { get; set; }
        public string backgroundBrightness { get; set; }
        public string backgroundBottomColor { get; set; }
        public string backgroundTopColor { get; set; }
        public bool canBePublic { get; set; }
        public bool canBeEnterprise { get; set; }
        public bool canBeOrg { get; set; }
        public bool canBePrivate { get; set; }
        public bool canInvite { get; set; }
    }

    public class Root
    {
        public string id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public object descData { get; set; }
        public bool closed { get; set; }
        public string idOrganization { get; set; }
        public object idEnterprise { get; set; }
        public bool pinned { get; set; }
        public string url { get; set; }
        public string shortUrl { get; set; }
        public Prefs prefs { get; set; }
        public LabelNames labelNames { get; set; }
    }

    public class SwitcherView
    {
        public string viewType { get; set; }
        public bool enabled { get; set; }
    }


}
