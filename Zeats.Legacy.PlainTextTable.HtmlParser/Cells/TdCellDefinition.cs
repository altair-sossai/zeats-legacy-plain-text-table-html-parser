using HtmlAgilityPack;
using Zeats.Legacy.PlainTextTable.Grid;
using Zeats.Legacy.PlainTextTable.HtmlParser.Cells.Basic;

namespace Zeats.Legacy.PlainTextTable.HtmlParser.Cells
{
    public class TdCellDefinition : BasicCellDefinition
    {
        public TdCellDefinition(CellDefinition father, HtmlNode htmlNode, int row, int column)
            : base(father, htmlNode)
        {
            Row = row;
            Column = column;
        }
    }
}