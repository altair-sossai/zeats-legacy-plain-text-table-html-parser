using HtmlAgilityPack;
using Zeats.Legacy.PlainTextTable.Enums;
using Zeats.Legacy.PlainTextTable.HtmlParser.Cells.Basic;

namespace Zeats.Legacy.PlainTextTable.HtmlParser.Cells
{
    public class BrCellDefinition : BasicCellDefinition
    {
        public BrCellDefinition(HtmlNode htmlNode)
            : base(htmlNode)
        {
            Border.Left = null;
            Border.Top = null;
            Border.Right = null;
            Border.Bottom = null;

            Border.TopLeft = null;
            Border.TopRight = null;
            Border.BottomRight = null;
            Border.BottomLeft = null;

            HorizontalAlign = HorizontalAlign.Left;
            VerticalAlign = VerticalAlign.Top;

            Value = string.Empty;
            PadValue = ' ';
        }
    }
}