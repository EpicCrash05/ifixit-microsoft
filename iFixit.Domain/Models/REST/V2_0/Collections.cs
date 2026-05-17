using System.Collections.Generic;

namespace iFixit.Domain.Models.REST.V2_0
{
    public class CollectionItem
    {
        public string dataType { get; set; }
        public int guideid { get; set; }
        public string locale { get; set; }
        public int revisionid { get; set; }
        public long modified_date { get; set; }
        public long prereq_modified_date { get; set; }
        public string url { get; set; }
        public string type { get; set; }
        public string category { get; set; }
        public string subject { get; set; }
        public string title { get; set; }
        public string summary { get; set; }
        public string difficulty { get; set; }
        public int time_required_max { get; set; }
        public bool @public { get; set; }
        public int userid { get; set; }
        public string username { get; set; }
        public List<string> flags { get; set; }
        public Image image { get; set; }
    }

    public class Image
    {
        public int id { get; set; }
        public string guid { get; set; }
        public string mini { get; set; }
        public string thumbnail { get; set; }
        public string _140x105 { get; set; }
        public string _200x150 { get; set; }
        public string standard { get; set; }
        public string _440x330 { get; set; }
        public string medium { get; set; }
        public string large { get; set; }
        public string huge { get; set; }
        public string original { get; set; }
    }

    public class Collection
    {
        public int collectionid { get; set; }
        public string title { get; set; }
        public long date { get; set; }
        public string link { get; set; }
        public int featured { get; set; }
        public long publish_date { get; set; }
        public string langid { get; set; }
        public List<CollectionItem> items { get; set; }
        public Image image { get; set; }
    }

    public class Collections : List<Collection>
    {
    }
}
