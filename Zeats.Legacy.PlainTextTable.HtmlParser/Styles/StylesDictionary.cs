using System.Collections.Generic;
using Zeats.Legacy.PlainTextTable.Styles;
using Zeats.Legacy.PlainTextTable.Styles.Types;

namespace Zeats.Legacy.PlainTextTable.HtmlParser.Styles
{
    public static class StylesDictionary
    {
        private static readonly Dictionary<string, IBorderStyle> Styles = new Dictionary<string, IBorderStyle>
        {
            {"all-borders", new AllBordersStyle()},
            {"bottom-border", new BottomBorderStyle()},
            {"header-border", new HeaderBorderStyle()},
            {"inside-borders", new InsideBordersStyle()},
            {"inside-horizontal-border", new InsideHorizontalBorderStyle()},
            {"inside-vertical-border", new InsideVerticalBorderStyle()},
            {"left-border", new LeftBorderStyle()},
            {"no-border", new NoBorderStyle()},
            {"outside-borders", new OutsideBordersStyle()},
            {"right-border", new RightBorderStyle()},
            {"top-border", new TopBorderStyle()},
            {"white-space-border", new WhiteSpaceBorderStyle()},
            {"white-space-vertical-border", new WhiteSpaceVerticalBorderStyle()}
        };

        public static bool Contains(string name)
        {
            return Styles.ContainsKey(name);
        }

        public static IBorderStyle Get(string name)
        {
            return Contains(name) ? Styles[name] : null;
        }
    }
}