using HtmlAgilityPack;
using Zeats.Legacy.PlainTextTable.Grid;
using Zeats.Legacy.PlainTextTable.HtmlParser.Columns.Basic;

namespace Zeats.Legacy.PlainTextTable.HtmlParser.Columns
{
    public class TdColumnDefinition : BasicColumnDefinition
    {
        public TdColumnDefinition(ColumnDefinition father, HtmlNode htmlNode)
            : base(father, htmlNode)
        {
        }
    }
}