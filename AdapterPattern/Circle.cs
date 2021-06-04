namespace CSAnim.DesignPatterns
{
    // Circle implements the iCircle interface
    class Circle : iCircle
    {
        int _radius;
        public Circle(int radius)
        {
            _radius = radius;
        }
        int iCircle.Radius => _radius;
    }
}