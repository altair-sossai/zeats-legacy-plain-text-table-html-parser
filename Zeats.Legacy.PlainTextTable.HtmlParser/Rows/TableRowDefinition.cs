using HtmlAgilityPack;
using Zeats.Legacy.PlainTextTable.HtmlParser.Rows.Basic;

namespace Zeats.Legacy.PlainTextTable.HtmlParser.Rows
{
    public class TableRowDefinition : BasicRowDefinition
    {
        public TableRowDefinition(HtmlNode htmlNode)
            : base(htmlNode)
        {
        }
    }
}