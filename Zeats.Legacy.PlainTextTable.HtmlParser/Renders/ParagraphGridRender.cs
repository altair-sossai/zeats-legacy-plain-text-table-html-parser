using HtmlAgilityPack;
using Zeats.Legacy.PlainTextTable.Grid;
using Zeats.Legacy.PlainTextTable.HtmlParser.Cells;
using Zeats.Legacy.PlainTextTable.HtmlParser.Columns;
using Zeats.Legacy.PlainTextTable.HtmlParser.Renders.Basic;
using Zeats.Legacy.PlainTextTable.HtmlParser.Rows;

namespace Zeats.Legacy.PlainTextTable.HtmlParser.Renders
{
    public class ParagraphGridRender : BasicGridRender
    {
        public ParagraphGridRender(string html)
            : this(LoadHtml(html))
        {
        }

        public ParagraphGridRender(HtmlNode htmlNode)
            : base(htmlNode, ParseHtmlNode(htmlNode))
        {
        }

        private static GridDefinition ParseHtmlNode(HtmlNode htmlNode)
        {
            var grid = new GridDefinition();

            var rowDefinition = new ParagraphRowDefinition(htmlNode);
            grid.RowDefinitions.Add(rowDefinition);

            var columnDefinition = new ParagraphColumnDefinition(htmlNode);
            grid.ColumnDefinitions.Add(columnDefinition);

            var cellDefinition = new ParagraphCellDefinition(htmlNode);
            grid.CellDefinitions.Add(cellDefinition);

            return grid;
        }
    }
}