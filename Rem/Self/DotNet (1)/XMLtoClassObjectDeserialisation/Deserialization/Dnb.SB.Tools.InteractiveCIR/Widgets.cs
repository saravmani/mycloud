
using Dnb.SB.Web.Website.CIRDasboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Dnb.SB.Web.BC.CIRDashBoard.Common
{
    /// <summary>
    /// Class DataColumn.
    /// </summary>
    public class DataColumn
    {
        /// <summary>
        /// Gets or sets the data field.
        /// </summary>
        /// <value>The data field.</value>
        public string DataField { get; set; }
        /// <summary>
        /// Gets or sets the data source identifier.
        /// </summary>
        /// <value>The data source identifier.</value>
        public string DataSourceID { get; set; }
    }

    /// <summary>
    /// Class Header.
    /// </summary>
    public class Header
    {
        /// <summary>
        /// Gets or sets the display text.
        /// </summary>
        /// <value>The display text.</value>
        public string DisplayText { get; set; }
        /// <summary>
        /// Gets or sets the display text_ language.
        /// </summary>
        /// <value>The display text_ language.</value>
        public string DisplayText_Lang { get; set; }
        /// <summary>
        /// Gets or sets the data field.
        /// </summary>
        /// <value>The data field.</value>
        public string DataField { get; set; }
        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>The width.</value>
        public int Width { get; set; }
        /// <summary>
        /// Gets or sets the attributes.
        /// </summary>
        /// <value>The attributes.</value>
        public string Attributes { get; set; }
    }

    /// <summary>
    /// Class GroupHeader.
    /// </summary>
    public class GroupHeader
    {
        /// <summary>
        /// Gets or sets the display text.
        /// </summary>
        /// <value>The display text.</value>
        public string DisplayText { get; set; }
        /// <summary>
        /// Gets or sets the display text_ language.
        /// </summary>
        /// <value>The display text_ language.</value>
        public string DisplayText_Lang { get; set; }
        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>The width.</value>
        public int Width { get; set; }
    }

    /// <summary>
    /// Class Table.
    /// </summary>
    public class Table
    {
        /// <summary>
        /// Gets or sets the data source identifier.
        /// </summary>
        /// <value>The data source identifier.</value>
        public string DataSourceID { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [enable server paging].
        /// </summary>
        /// <value><c>true</c> if [enable server paging]; otherwise, <c>false</c>.</value>
        public bool EnableServerPaging { get; set; }
        /// <summary>
        /// Gets or sets the size of the page.
        /// </summary>
        /// <value>The size of the page.</value>
        public int PageSize { get; set; }
        /// <summary>
        /// Gets or sets the heading.
        /// </summary>
        /// <value>The heading.</value>
        public List<Header> Heading { get; set; }
        /// <summary>
        /// Gets or sets the group heading.
        /// </summary>
        /// <value>The group heading.</value>
        public List<GroupHeader> GroupHeading { get; set; }
        /// <summary>
        /// Gets or sets the type of the table.
        /// </summary>
        /// <value>The type of the table.</value>
        public string TableType { get; set; }
        /// <summary>
        /// Gets or sets the row data.
        /// </summary>
        /// <value>The row data.</value>
        public List<DataColumn> RowData { get; set; }
        /// <summary>
        /// Gets or sets the table identifier.
        /// </summary>
        /// <value>The table identifier.</value>
        public string TableID { get; set; }
        /// <summary>
        /// Gets or sets the head column.
        /// </summary>
        /// <value>The head column.</value>
        public string HeadColumn { get; set; }
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }
    }

    /// <summary>
    /// Class Graph.
    /// </summary>
    public class Graph
    {
        /// <summary>
        /// Gets or sets the data source identifier.
        /// </summary>
        /// <value>The data source identifier.</value>
        public string DataSourceID { get; set; }
        /// <summary>
        /// Gets or sets the type of the graph.
        /// </summary>
        /// <value>The type of the graph.</value>
        public string GraphType { get; set; }
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }
        /// <summary>
        /// Gets or sets the title_ language.
        /// </summary>
        /// <value>The title_ language.</value>
        public string Title_Lang { get; set; }
    }

    /// <summary>
    /// Class Tab.
    /// </summary>
    public class Tab
    {
        /// <summary>
        /// Gets or sets the tables.
        /// </summary>
        /// <value>The tables.</value>
        public List<Table> Tables { get; set; }
        /// <summary>
        /// Gets or sets the graphs.
        /// </summary>
        /// <value>The graphs.</value>
        public List<Graph> Graphs { get; set; }
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }
        /// <summary>
        /// Gets or sets the title_ language.
        /// </summary>
        /// <value>The title_ language.</value>
        public string Title_Lang { get; set; }
        /// <summary>
        /// Gets or sets the tab identifier.
        /// </summary>
        /// <value>The tab identifier.</value>
        public string TabID { get; set; }
    }

    /// <summary>
    /// Class Panel.
    /// </summary>
    public class Panel
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string ID { get; set; }
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public string Type { get; set; }
        /// <summary>
        /// Gets or sets the tabs.
        /// </summary>
        /// <value>The tabs.</value>
        public List<Tab> Tabs { get; set; }

    }

    /// <summary>
    /// Class Widget.
    /// </summary>
    public class Widget
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string ID { get; set; }
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public string Type { get; set; }
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }
        /// <summary>
        /// Gets or sets the title_ language.
        /// </summary>
        /// <value>The title_ language.</value>
        public string Title_Lang { get; set; }
        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>The tool tip.</value>
        public string ToolTip { get; set; }
        /// <summary>
        /// Gets or sets the tool tip_ language.
        /// </summary>
        /// <value>The tool tip_ language.</value>
        public string ToolTip_Lang { get; set; }
        /// <summary>
        /// Gets or sets the mode.
        /// </summary>
        /// <value>The mode.</value>
        public string Mode { get; set; }
        /// <summary>
        /// Gets or sets the panels.
        /// </summary>
        /// <value>The panels.</value>
        public List<Panel> Panels { get; set; }
        /// <summary>
        /// Gets or sets the tables.
        /// </summary>
        /// <value>The tables.</value>
        public List<Table> Tables { get; set; }
        /// <summary>
        /// Gets or sets the graphs.
        /// </summary>
        /// <value>The graphs.</value>
        public List<Graph> Graphs { get; set; }
        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>The position.</value>
        public int Position { get; set; }
    }

    /// <summary>
    /// Class Banner.
    /// </summary>
    public class Banner
    {
        /// <summary>
        /// Gets or sets the display text.
        /// </summary>
        /// <value>The display text.</value>
        public string DisplayText { get; set; }
        /// <summary>
        /// Gets or sets the display text_ language.
        /// </summary>
        /// <value>The display text_ language.</value>
        public string DisplayText_Lang { get; set; }
        /// <summary>
        /// Gets or sets the data field.
        /// </summary>
        /// <value>The data field.</value>
        public string DataField { get; set; }
       
    }


    /// <summary>
    /// Class WidgetCollection.
    /// </summary>
    public class WidgetCollection
    {
        /// <summary>
        /// Gets or sets the widgets.
        /// </summary>
        /// <value>The widgets.</value>
        public List<Widget> Widgets { get; set; }
        /// <summary>
        /// Gets or sets the banner collection.
        /// </summary>
        /// <value>The banner collection.</value>
        public List<Banner> BannerCollection { get; set; }
        /// <summary>
        /// Gets or sets the banner data source identifier.
        /// </summary>
        /// <value>The banner data source identifier.</value>
        public string BannerDataSourceID { get; set; }
        /// <summary>
        /// Gets or sets the product identifier.
        /// </summary>
        /// <value>The product identifier.</value>
        [XmlIgnore]
        public string ProductID { get; set; }
        /// <summary>
        /// Gets or sets the widget XML path.
        /// </summary>
        /// <value>The widget XML path.</value>
        [XmlIgnore]
        public string WidgetXmlPath { get; set; }
        /// <summary>
        /// Gets or sets the database query.
        /// </summary>
        /// <value>The database query.</value>
        [XmlIgnore]
        public DBQuery DbQuery { get; set; }
      }
}
