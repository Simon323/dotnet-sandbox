#region ClassWithDestructor

using Sandbox.ConsoleApp.Errors;

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

#region LocalMethod

if (false)
{
    var objectWithLocalMethods = new LocalMethod();
    objectWithLocalMethods.Run();
}
#endregion

#region Record

if (false)
{
    var user = new UserRecord("John", "Doe", 32);
    Console.WriteLine(user);
}

#endregion

#region Extension method

if (false)
{
    double NewYork = 32;
    Console.WriteLine($"{NewYork.CalsiusToFahrenheit()}");
}

#endregion

#region TryCatch

if (true)
{
    try
    {
        var service = new OrderService();
        //int id = service.GetLastOrderId();
        service.SignOrder(1, "xyz12");
    }
    catch (OrderSignException exc)
    {
        // logger.Error()
        Console.WriteLine($"Problems with signing {exc.OrderId} - {exc.SignErrorCode}");
    }
    catch (Exception exc)
    {
        // logger.Error()
        Console.WriteLine("Other problems...");
    }
}


#endregion