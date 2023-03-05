namespace DrawingApp.Hubs
{
    public class DrawingObjects
    {
        public class StrokeTool
        {
            public int MousePosX { get; set; }

            public int MousePosY { get; set; }

            public int MousePreviousPosX { get; set; }

            public int MousePreviousPosY { get; set; }

            public int LineWidth { get; set; }

            public string? StrokeStyle { get; set; }

            public string? FillStyle { get; set; }
        }

        public class StrokeStartingCoordinates
        {
            public int StartPosX { get; set; }

            public int StartPosY { get; set;}
        }

    }


}
