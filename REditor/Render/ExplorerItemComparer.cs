﻿using System.Collections.Generic;

namespace FastColoredTextBoxNS.Render
{

    class ExplorerItemComparer : IComparer<ExplorerItem>
    {
        public int Compare(ExplorerItem x, ExplorerItem y)
        {
            return x.title.CompareTo(y.title);
        }
    }
}