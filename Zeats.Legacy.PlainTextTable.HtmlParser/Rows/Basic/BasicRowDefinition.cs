using HtmlAgilityPack;
using Zeats.Legacy.PlainTextTable.Enums;
using Zeats.Legacy.PlainTextTable.Grid;
using Zeats.Legacy.PlainTextTable.HtmlParser.Extensions;

namespace Zeats.Legacy.PlainTextTable.HtmlParser.Rows.Basic
{
    public class BasicRowDefinition : RowDefinition
    {
        public BasicRowDefinition(HtmlNode htmlNode)
            : this(null, htmlNode)
        {
        }

        public BasicRowDefinition(RowDefinition father, HtmlNode htmlNode)
        {
            HeightType = htmlNode.HeightType(father?.HeightType ?? HeightType);
            Height = htmlNode.Height(father?.Height ?? Height);
        }
    }
}