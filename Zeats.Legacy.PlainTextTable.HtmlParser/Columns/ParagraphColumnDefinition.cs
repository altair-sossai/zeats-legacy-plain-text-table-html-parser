using HtmlAgilityPack;
using Zeats.Legacy.PlainTextTable.HtmlParser.Columns.Basic;

namespace Zeats.Legacy.PlainTextTable.HtmlParser.Columns
{
    public class ParagraphColumnDefinition : BasicColumnDefinition
    {
        public ParagraphColumnDefinition(HtmlNode htmlNode)
            : base(htmlNode)
        {
        }
    }
}