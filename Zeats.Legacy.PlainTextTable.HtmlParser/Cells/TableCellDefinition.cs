using HtmlAgilityPack;
using Zeats.Legacy.PlainTextTable.HtmlParser.Cells.Basic;

namespace Zeats.Legacy.PlainTextTable.HtmlParser.Cells
{
    public class TableCellDefinition : BasicCellDefinition
    {
        public TableCellDefinition(HtmlNode htmlNode)
            : base(htmlNode)
        {
        }
    }
}