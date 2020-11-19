using HtmlAgilityPack;
using Zeats.Legacy.PlainTextTable.Enums;
using Zeats.Legacy.PlainTextTable.HtmlParser.Rows.Basic;

namespace Zeats.Legacy.PlainTextTable.HtmlParser.Rows
{
    public class BrRowDefinition : BasicRowDefinition
    {
        public BrRowDefinition(HtmlNode htmlNode)
            : base(htmlNode)
        {
            HeightType = HeightType.Auto;
            Height = 1;
        }
    }
}