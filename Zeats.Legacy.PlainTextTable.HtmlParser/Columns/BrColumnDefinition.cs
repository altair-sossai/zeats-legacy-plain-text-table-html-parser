using HtmlAgilityPack;
using Zeats.Legacy.PlainTextTable.Enums;
using Zeats.Legacy.PlainTextTable.HtmlParser.Columns.Basic;

namespace Zeats.Legacy.PlainTextTable.HtmlParser.Columns
{
    public class BrColumnDefinition : BasicColumnDefinition
    {
        public BrColumnDefinition(HtmlNode htmlNode)
            : base(htmlNode)
        {
            WidthType = WidthType.Star;
            Width = 1;
        }
    }
}