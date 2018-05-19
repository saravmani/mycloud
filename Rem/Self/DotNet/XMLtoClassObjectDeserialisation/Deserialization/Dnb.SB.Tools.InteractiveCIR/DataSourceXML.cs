using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Dnb.SB.Web.Website.CIRDasboard
{
    public class DBQuery
    {
        public DBQuery()
        {
            Query = new List<Query>();
        }
        [XmlAttribute()]
        public int QueryCount { get; set; }

        [XmlElement("Query", typeof(Query))]
        public List<Query> Query;
    }

    public class Query
    {
        public Query()
        {
            SubQuery = new List<SubQuery>();
        }
        [XmlAttribute()]
        public string DataSetId;
        [XmlAttribute()]
        public string QueryType;

        [XmlAttribute()]
        public bool InitialLoad;

        [XmlAttribute()]
        public bool DependancyLoad;


        [XmlAttribute()]
        public bool OnDemand;
        [XmlAttribute()]
        public string DataSource;
        [XmlAttribute()]
        public string Params;
        [XmlAttribute()]
        public string DllName;
        [XmlAttribute()]
        public string CustomClass;

        [XmlElement("SubQuery", typeof(SubQuery))]
        public List<SubQuery> SubQuery;
    }
    public class SubQuery
    {
        [XmlAttribute()]
        public string DataSetId;
        [XmlAttribute()]
        public string QueryType;
        [XmlAttribute()]
        public string ParentDataSetId;
        [XmlAttribute()]
        public string GroupByField;
        [XmlAttribute()]
        public string SumFields;
    }

}
