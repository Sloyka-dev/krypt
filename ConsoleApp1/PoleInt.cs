using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;

internal struct PoleInt
{

    public int Value;

    public const int P = 13;

    public PoleInt(int value)
    {

        Value = value % P;

    }

    public PoleInt()
    {

        Value = 0;

    }

    public static implicit operator PoleInt(int value) => new PoleInt(value);

    // +
    public static PoleInt operator +(PoleInt left, PoleInt right) => left + right.Value;
    public static PoleInt operator +(PoleInt left, int right) => left.Value + right;

    // *
    public static PoleInt operator *(PoleInt left, PoleInt right) => left * right.Value;
    public static PoleInt operator *(PoleInt left, int right) => left.Value * right;

    // -
    public static PoleInt operator -(PoleInt left, PoleInt right) => left - right.Value;
    public static PoleInt operator -(PoleInt left, int right) => left.Value + (P - right) % P;

    // /
    public static PoleInt operator /(PoleInt left, PoleInt right) => left / right.Value;
    public static PoleInt operator /(PoleInt left, int right)
    {

        for(int i = 1; i < P; i++)
        {

            if ((i * right) % P == 1)
                return left * i;

        }

        return -1;

    }

    // ==
    public static bool operator ==(PoleInt left, PoleInt right) => left == right.Value;
    public static bool operator ==(PoleInt left, int right) => left.Value == right;
    
    // !=
    public static bool operator !=(PoleInt left, PoleInt right) => left != right.Value;
    public static bool operator !=(PoleInt left, int right) => left.Value != right;

    // Pow
    public static PoleInt Pow(PoleInt Value, int power)
    {

        var res = (int)Math.Pow(Value.Value, power);
        Value.Value = res % P;

        return Value;

    }

    public override string ToString()
    {
        return Value.ToString();
    }

}
