using HtmlAgilityPack;
using Zeats.Legacy.PlainTextTable.Grid;
using Zeats.Legacy.PlainTextTable.HtmlParser.Cells.Basic;

namespace Zeats.Legacy.PlainTextTable.HtmlParser.Cells
{
    public class TrCellDefinition : BasicCellDefinition
    {
        public TrCellDefinition(CellDefinition father, HtmlNode htmlNode)
            : base(father, htmlNode)
        {
        }
    }
}