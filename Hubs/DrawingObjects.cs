namespace DrawingApp.Hubs
{
    public class DrawingObjects
    {
        public class StrokeTool
        {
            public int MousePosX { get; set; }

            public int MousePosY { get; set; }

            public string? StrokeStyle { get; set; }
        }

        public class Rectangle
        {
            public int MousePosX { get; set; }

            public int MousePosY { get; set; }

            public int Width { get; set; }

            public int Height { get; set; }

            public bool FillColor { get; set; }
        }

        public class Triangle
        {
            public int MousePosX { get; set; }

            public int MousePosY { get; set; }

            public int MousePreviousPosX { get; set; }

            public int MousePreviousPosY { get; set; }

            public bool FillColor { get; set; }
        }

        public class Circle
        {
            public int MousePreviousPosX { get; set; } 

            public int MousePreviousPosY { get; set; }

            public double Radius { get; set; }

            public bool FillColor { get; set; }
        }


        public class NewStrokeObject
        {
            public int StartPosX { get; set; }

            public int StartPosY { get; set; }

            public int LineWidth { get; set; }

            public string? StrokeStyle { get; set; }

            public string? FillStyle { get; set; }
        }

    }


}
