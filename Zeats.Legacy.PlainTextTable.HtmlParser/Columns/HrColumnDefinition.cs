using HtmlAgilityPack;
using Zeats.Legacy.PlainTextTable.Enums;
using Zeats.Legacy.PlainTextTable.HtmlParser.Columns.Basic;

namespace Zeats.Legacy.PlainTextTable.HtmlParser.Columns
{
    public class HrColumnDefinition : BasicColumnDefinition
    {
        public HrColumnDefinition(HtmlNode htmlNode)
            : base(htmlNode)
        {
            WidthType = WidthType.Star;
            Width = 1;
        }
    }
}