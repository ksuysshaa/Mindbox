namespace Geometry.Figures;

public class Triangle
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new ArgumentException("Error. Side must be greater than zero.");

        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;

        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            throw new ArgumentException("Error. Triangle with such sides does not exist.");
    }

    public double CalculateArea()
    {
        double s = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(s * (s - _sideA) * (s - _sideB) * (s - _sideC));
    }

    public bool IsRightAngled()
    {
        double[] sides = { _sideA, _sideB, _sideC };
        Array.Sort(sides);
        return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-10;
    }
}