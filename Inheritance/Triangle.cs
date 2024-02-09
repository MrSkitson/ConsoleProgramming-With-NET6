class Triangle : Shape, IShape
{
    public Triangle()
    {
        
    }
    public Triangle( int hypotinuese)
    {
        Hypotenuese = hypotinuese;
    }    
    public Triangle(int length, int height, int hypotinuese)
    {
        Length = length;
        Height = height;
        Hypotenuese = hypotinuese;
    }
    public double Hypotenuese { get; set; }

    public double GetArea()
    {
        return .5 * Length * Height;
    }

}