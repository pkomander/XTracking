using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Trello
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public class Attachments
    {
        public PerBoard perBoard { get; set; }
        public PerCard perCard { get; set; }
    }

    public class BackgroundImageScaled
    {
        public int width { get; set; }
        public int height { get; set; }
        public string url { get; set; }
    }

    public class Boards
    {
        public TotalMembersPerBoard totalMembersPerBoard { get; set; }
        public TotalAccessRequestsPerBoard totalAccessRequestsPerBoard { get; set; }
    }

    public class Cards
    {
        public OpenPerBoard openPerBoard { get; set; }
        public OpenPerList openPerList { get; set; }
        public TotalPerBoard totalPerBoard { get; set; }
        public TotalPerList totalPerList { get; set; }
    }

    public class CheckItems
    {
        public PerChecklist perChecklist { get; set; }
    }

    public class Checklists
    {
        public PerBoard perBoard { get; set; }
        public PerCard perCard { get; set; }
    }

    public class CustomFieldOptions
    {
        public PerField perField { get; set; }
    }

    public class CustomFields
    {
        public PerBoard perBoard { get; set; }
    }

    public class DescData
    {
        public Emoji emoji { get; set; }
    }

    public class Emoji
    {
    }

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

    public class Labels
    {
        public PerBoard perBoard { get; set; }
    }

    public class Limits
    {
        public Attachments attachments { get; set; }
        public Boards boards { get; set; }
        public Cards cards { get; set; }
        public Checklists checklists { get; set; }
        public CheckItems checkItems { get; set; }
        public CustomFields customFields { get; set; }
        public CustomFieldOptions customFieldOptions { get; set; }
        public Labels labels { get; set; }
        public Lists lists { get; set; }
        public Stickers stickers { get; set; }
        public Reactions reactions { get; set; }
    }

    public class Lists
    {
        public OpenPerBoard openPerBoard { get; set; }
        public TotalPerBoard totalPerBoard { get; set; }
    }

    public class Membership
    {
        public string idMember { get; set; }
        public string memberType { get; set; }
        public bool unconfirmed { get; set; }
        public bool deactivated { get; set; }
        public string id { get; set; }
    }

    public class OpenPerBoard
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class OpenPerList
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class PerAction
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class PerBoard
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class PerCard
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class PerChecklist
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class PerField
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
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
        public List<string> hiddenPluginBoardButtons { get; set; }
        public List<SwitcherView> switcherViews { get; set; }
        public string background { get; set; }
        public string backgroundColor { get; set; }
        public string backgroundImage { get; set; }
        public List<BackgroundImageScaled> backgroundImageScaled { get; set; }
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

    public class Reactions
    {
        public PerAction perAction { get; set; }
        public UniquePerAction uniquePerAction { get; set; }
    }

    public class Root
    {
        public string id { get; set; }
        public string nodeId { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public DescData descData { get; set; }
        public bool closed { get; set; }
        public DateTime? dateClosed { get; set; }
        public string idOrganization { get; set; }
        public object idEnterprise { get; set; }
        public Limits limits { get; set; }
        public bool pinned { get; set; }
        public bool starred { get; set; }
        public string url { get; set; }
        public Prefs prefs { get; set; }
        public string shortLink { get; set; }
        public bool subscribed { get; set; }
        public LabelNames labelNames { get; set; }
        public List<object> powerUps { get; set; }
        public DateTime dateLastActivity { get; set; }
        public DateTime dateLastView { get; set; }
        public string shortUrl { get; set; }
        public List<object> idTags { get; set; }
        public object datePluginDisable { get; set; }
        public object creationMethod { get; set; }
        public string ixUpdate { get; set; }
        public object templateGallery { get; set; }
        public bool enterpriseOwned { get; set; }
        public string idBoardSource { get; set; }
        public List<string> premiumFeatures { get; set; }
        public string idMemberCreator { get; set; }
        public List<Membership> memberships { get; set; }
    }

    public class Stickers
    {
        public PerCard perCard { get; set; }
    }

    public class SwitcherView
    {
        public string viewType { get; set; }
        public bool enabled { get; set; }
    }

    public class TotalAccessRequestsPerBoard
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class TotalMembersPerBoard
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class TotalPerBoard
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class TotalPerList
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class UniquePerAction
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }


}
