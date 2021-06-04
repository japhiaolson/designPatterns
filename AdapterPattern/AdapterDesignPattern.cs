namespace CSAnim.DesignPatterns
{
    // Our adaptee that is incompatible with the iCircle interface
    class Square
    {
        public int Width { get; private set; }
        public Square(int width)
        {
            Width = width;
        }
    }

    // Adapter which adapts our square to the iCircle interface
    class SquareAdapter : iCircle
    {
        Square _square;
        int iCircle.Radius => _square.Width / 2;
        public SquareAdapter(Square square)
        {
            _square = square;
        }
    }

    class AdapterTest
    {
        public void Run()
        {
            // Let's add a couple circles to our Legacy Sorter.
            LegacySorter.AddSortedItem(new Circle(5));
            LegacySorter.AddSortedItem(new Circle(2));

            // Create our adaptee object.
            Square square = new Square(6);

            // Adapt our square to the iCircle interface.
            iCircle adaptedSquare = new SquareAdapter(square);

            // And finally, we can now add our square to the legacy item sorter.
            LegacySorter.AddSortedItem(adaptedSquare);
        }
    }
}