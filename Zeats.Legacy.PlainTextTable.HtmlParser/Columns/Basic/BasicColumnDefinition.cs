using HtmlAgilityPack;
using Zeats.Legacy.PlainTextTable.Enums;
using Zeats.Legacy.PlainTextTable.Grid;
using Zeats.Legacy.PlainTextTable.HtmlParser.Extensions;

namespace Zeats.Legacy.PlainTextTable.HtmlParser.Columns.Basic
{
    public class BasicColumnDefinition : ColumnDefinition
    {
        public BasicColumnDefinition(HtmlNode htmlNode)
            : this(null, htmlNode)
        {
        }

        public BasicColumnDefinition(ColumnDefinition father, HtmlNode htmlNode)
        {
            WidthType = htmlNode.WidthType(father?.WidthType ?? WidthType);
            Width = htmlNode.Width(father?.Width ?? Width);
        }
    }
}