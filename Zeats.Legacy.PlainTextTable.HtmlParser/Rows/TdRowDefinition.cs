using HtmlAgilityPack;
using Zeats.Legacy.PlainTextTable.Grid;
using Zeats.Legacy.PlainTextTable.HtmlParser.Rows.Basic;

namespace Zeats.Legacy.PlainTextTable.HtmlParser.Rows
{
    public class TdRowDefinition : BasicRowDefinition
    {
        public TdRowDefinition(RowDefinition father, HtmlNode htmlNode)
            : base(father, htmlNode)
        {
        }
    }
}