using HtmlAgilityPack;
using Zeats.Legacy.PlainTextTable.Grid;
using Zeats.Legacy.PlainTextTable.HtmlParser.Extensions;
using Zeats.Legacy.PlainTextTable.Render;

namespace Zeats.Legacy.PlainTextTable.HtmlParser.Renders.Basic
{
    public abstract class BasicGridRender : GridRender
    {
        protected BasicGridRender(HtmlNode htmlNode, GridDefinition grid)
            : base(grid)
        {
            Styles.AddRange(htmlNode.BorderStyles());
        }

        protected static HtmlNode LoadHtml(string html)
        {
            var htmlDocument = new HtmlDocument();

            htmlDocument.LoadHtml(html);

            return htmlDocument.DocumentNode.FirstChild;
        }
    }
}