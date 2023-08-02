using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Trello
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public class AttachmentsByType
    {
        public Trello trello { get; set; }
    }

    public class Badges
    {
        public AttachmentsByType attachmentsByType { get; set; }
        public bool location { get; set; }
        public int votes { get; set; }
        public bool viewingMemberVoted { get; set; }
        public bool subscribed { get; set; }
        public string fogbugz { get; set; }
        public int checkItems { get; set; }
        public int checkItemsChecked { get; set; }
        public object checkItemsEarliestDue { get; set; }
        public int comments { get; set; }
        public int attachments { get; set; }
        public bool description { get; set; }
        public DateTime? due { get; set; }
        public bool dueComplete { get; set; }
        public DateTime? start { get; set; }
    }

    public class CheckItemState
    {
        public string idCheckItem { get; set; }
        public string state { get; set; }
    }

    public class Cover
    {
        public object idAttachment { get; set; }
        public object color { get; set; }
        public object idUploadedBackground { get; set; }
        public string size { get; set; }
        public string brightness { get; set; }
        public object idPlugin { get; set; }
    }

    public class DescData
    {
        public Emoji emoji { get; set; }
    }

    public class Emoji
    {
    }

    public class Label
    {
        public string id { get; set; }
        public string idBoard { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        public int uses { get; set; }
    }

    public class Root
    {
        public string id { get; set; }
        public Badges badges { get; set; }
        public List<CheckItemState> checkItemStates { get; set; }
        public bool closed { get; set; }
        public bool dueComplete { get; set; }
        public DateTime dateLastActivity { get; set; }
        public string desc { get; set; }
        public DescData descData { get; set; }
        public DateTime? due { get; set; }
        public int? dueReminder { get; set; }
        public object email { get; set; }
        public string idBoard { get; set; }
        public List<string> idChecklists { get; set; }
        public string idList { get; set; }
        public List<string> idMembers { get; set; }
        public List<object> idMembersVoted { get; set; }
        public int idShort { get; set; }
        public string idAttachmentCover { get; set; }
        public List<Label> labels { get; set; }
        public List<string> idLabels { get; set; }
        public bool manualCoverAttachment { get; set; }
        public string name { get; set; }
        public double pos { get; set; }
        public string shortLink { get; set; }
        public string shortUrl { get; set; }
        public DateTime? start { get; set; }
        public bool subscribed { get; set; }
        public string url { get; set; }
        public Cover cover { get; set; }
        public bool isTemplate { get; set; }
        public object cardRole { get; set; }
    }

    public class Trello
    {
        public int board { get; set; }
        public int card { get; set; }
    }


}
