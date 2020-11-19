using HtmlAgilityPack;
using Zeats.Legacy.PlainTextTable.Grid;
using Zeats.Legacy.PlainTextTable.HtmlParser.Cells;
using Zeats.Legacy.PlainTextTable.HtmlParser.Columns;
using Zeats.Legacy.PlainTextTable.HtmlParser.Renders.Basic;
using Zeats.Legacy.PlainTextTable.HtmlParser.Rows;

namespace Zeats.Legacy.PlainTextTable.HtmlParser.Renders
{
    public class HrGridRender : BasicGridRender
    {
        public HrGridRender(string html)
            : this(LoadHtml(html))
        {
        }

        public HrGridRender(HtmlNode htmlNode)
            : base(htmlNode, ParseHtmlNode(htmlNode))
        {
        }

        private static GridDefinition ParseHtmlNode(HtmlNode htmlNode)
        {
            var grid = new GridDefinition();

            var rowDefinition = new HrRowDefinition(htmlNode);
            grid.RowDefinitions.Add(rowDefinition);

            var columnDefinition = new HrColumnDefinition(htmlNode);
            grid.ColumnDefinitions.Add(columnDefinition);

            var cellDefinition = new HrCellDefinition(htmlNode);
            grid.CellDefinitions.Add(cellDefinition);

            return grid;
        }
    }
}