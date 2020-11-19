using HtmlAgilityPack;
using Zeats.Legacy.PlainTextTable.Enums;
using Zeats.Legacy.PlainTextTable.HtmlParser.Rows.Basic;

namespace Zeats.Legacy.PlainTextTable.HtmlParser.Rows
{
    public class HrRowDefinition : BasicRowDefinition
    {
        public HrRowDefinition(HtmlNode htmlNode)
            : base(htmlNode)
        {
            HeightType = HeightType.Auto;
            Height = 1;
        }
    }
}