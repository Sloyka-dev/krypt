using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;

internal struct PolePoint
{

    public static readonly int A = 26, B = 55;

    public PoleInt X, Y;

    public PolePoint()
    {

        X = 0;
        Y = 0;

    }

    public PolePoint(PoleInt x, PoleInt y)
    {

        X = x;
        Y = y;

    }

    public static PolePoint operator +(PolePoint left, PolePoint right)
    {

        if (left.Equals(right))
        {
            // A + A 

            var lambd = (3 * PoleInt.Pow(right.X, 2) + A) / (2 * right.Y);
            var x3 = PoleInt.Pow(lambd, 2) - 2 * right.X;
            var y3 = lambd * (right.X - x3) - right.Y;

            return new PolePoint(x3, y3);

        }
        else
        {
            // A + B

            if (right.X == left.X) 
                return new PolePoint(-1, -1);

            var lambd = (right.Y - left.Y) / (right.X - left.X);
            var x3 = PoleInt.Pow(lambd, 2) - left.X - right.X;
            var y3 = lambd * (left.X - x3) - left.Y;

            return new PolePoint(x3, y3);

        }

    }

    public override bool Equals([NotNullWhen(true)] object? obj)
    {
        
        if (!ReferenceEquals(this, obj)) return false;
        if (obj == null) return false;

        return Equals((PolePoint)obj);

    }

    public bool Equals(PolePoint obj) => X == obj.X && Y == obj.Y;

    public override string ToString()
    {
        return String.Format("({0,2}, {1,2})", X, Y);
    }

}
