using HtmlAgilityPack;
using Zeats.Legacy.PlainTextTable.HtmlParser.Columns.Basic;

namespace Zeats.Legacy.PlainTextTable.HtmlParser.Columns
{
    public class TableColumnDefinition : BasicColumnDefinition
    {
        public TableColumnDefinition(HtmlNode htmlNode)
            : base(htmlNode)
        {
        }
    }
}