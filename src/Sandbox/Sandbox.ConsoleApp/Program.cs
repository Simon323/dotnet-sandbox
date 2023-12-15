#region ClassWithDestructor

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

#region ClassVsTuple

if (false)
{
    var personalInfo = ClassVsTuple.GetPersonalInfo();
    Console.WriteLine($"{personalInfo.Name}, {personalInfo.Age}");

    var (name, age) = ClassVsTuple.GetPersonaInfoAsTupel();
    Console.WriteLine($"{name}, {age}");

    (string country, string surname, int age) tuple = ("Poland", "Doe", 32);
    Console.WriteLine($"{tuple.country} {tuple.surname} {tuple.age}");

}

#endregion