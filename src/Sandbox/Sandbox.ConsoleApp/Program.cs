﻿#region ClassWithDestructor

if (false)
{
    for (int i = 0; i < 100; i++)
    {
        var obj = new ClassWithDestructor();
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}

#endregion

#region Calculator

if (false)
{
    Calculator.Calculate(2, 3, Calculator.Add);
}

#endregion

#region Ref

if (false)
{
    int a = 32;

    RefSample.Increase(ref a);
    Console.WriteLine(a);
}

#endregion

#region IDisposable


if (false)
{
    using (var res = new ClassWithResources()) ;

    Console.WriteLine("End");
}

#endregion

#region Params

if (false)
{
    ParamsSample.DisplayNames(new string[] { "adam", "roman", "ola" });
    ParamsSample.DisplayNames("adam", "roman", "ola");
}

#endregion