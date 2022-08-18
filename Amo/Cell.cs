using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Amo
{
    public class Cell
    {
        /// <summary>
        /// Статус жизни.
        /// </summary>
        public bool Life { get; set; } = true;

        public Brush Brush { get; set; } = Brushes.White;
    }
}
