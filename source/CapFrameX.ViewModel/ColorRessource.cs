﻿using OxyPlot;
using System.Windows.Media;

namespace CapFrameX.ViewModel
{
    public static class ColorRessource
    {
        public readonly static SolidColorBrush PieChartSmmoothFill = new SolidColorBrush(Color.FromRgb(34, 151, 243));

        public readonly static SolidColorBrush PieChartStutterFill = Brushes.Red;

        public readonly static SolidColorBrush LShapeStroke = new SolidColorBrush(Color.FromRgb(156, 210, 0));

        public readonly static SolidColorBrush BarChartFill = new SolidColorBrush(Color.FromRgb(241, 125, 32));

		public readonly static OxyColor FrametimeMovingAverageStroke = OxyColor.FromArgb(180, 139, 106, 96);

        public readonly static OxyColor FrametimeStroke = OxyColor.FromRgb(156, 210, 0);

        public readonly static OxyColor FpsAverageStroke = OxyColor.FromArgb(200, 139, 106, 96);

        public readonly static OxyColor FpsStroke = OxyColor.FromRgb(156, 210, 0);
    }
}
