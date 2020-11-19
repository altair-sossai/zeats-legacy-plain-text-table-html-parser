using HtmlAgilityPack;
using Zeats.Legacy.PlainTextTable.HtmlParser.Rows.Basic;

namespace Zeats.Legacy.PlainTextTable.HtmlParser.Rows
{
    public class ParagraphRowDefinition : BasicRowDefinition
    {
        public ParagraphRowDefinition(HtmlNode htmlNode)
            : base(htmlNode)
        {
        }
    }
}