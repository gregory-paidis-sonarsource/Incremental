// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var x = 42;


/*
 *
 */

class Thingy
{
    public object SomeObjectWithStupidlyLongName;
    public int Count;
    public bool Flag;

    public Thingy Nested;
}


class PatternMacher
{
    Thingy GetThingy() => default;

    void DoWorkVar(Thingy thingy)
    {
        // is { var pattern }
        if (thingy is { SomeObjectWithStupidlyLongName: var x1 }
            && SomeCheck(x1)
            && SomeCheck(x1))
        {
            // Work
        }

        // is { type pattern }
        if (thingy is { SomeObjectWithStupidlyLongName: string typeCheck })
        {
            // Work
        }

        // is { other patterns...var pattern...other patterns }
        if (thingy is { Count: > 0, SomeObjectWithStupidlyLongName: var x3, Flag: true })
        {
            // Work
        }

        // is { other patterns...var pattern }
        if (thingy is { Count: > 0, Flag: true, SomeObjectWithStupidlyLongName: var x2 })
        {
            // Work
        }

        // is { var pattern, var pattern... }
        if (thingy is { Count: var a1, Flag: var a2, SomeObjectWithStupidlyLongName: var a3 })
        {
            // Work
        }

        // Psychopath code
        if (thingy is { Nested: { Nested: { Nested: var x42 } } })
        {
            // Work
        }

        // Less Psychopath code
        if (thingy is { Nested.Nested.Nested: var x41 })
        {
            // Work
        }
    }

    void DoWorkNoVar(Thingy thingy)
    {
        // is { var pattern }
        if (SomeCheck(thingy.SomeObjectWithStupidlyLongName)
            && SomeCheck(thingy.SomeObjectWithStupidlyLongName))
        {
            // Work
        }

        // is { type pattern }
        if (thingy.SomeObjectWithStupidlyLongName is string typeCheck)
        {
            // Work
        }

        // is { other patterns...var pattern...other patterns }
        if (thingy is { Count: > 0, Flag: true }
            && SomeCheck(thingy.SomeObjectWithStupidlyLongName))
        {
            // Work
        }

        // is { var pattern, var pattern... }
        if (SomeCheck(thingy.Count)
            && SomeCheck(thingy.Flag)
            && SomeCheck(thingy.SomeObjectWithStupidlyLongName))
        {
            // Work
        }

        // Psychopath code
        if (SomeCheck(thingy.Nested.Nested.Nested))
        {
            // Work
        }
    }

    bool SomeCheck(object x) => false;
}
