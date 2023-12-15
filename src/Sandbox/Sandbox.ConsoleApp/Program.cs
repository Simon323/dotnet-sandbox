#region ClassWithDestructor

//using Sandbox.ConsoleApp.Samples;

//for (int i = 0; i < 100; i++)
//{
//    var obj = new ClassWithDestructor();
//    GC.Collect();
//    GC.WaitForPendingFinalizers();
//}

#endregion

#region Calculator


//Calculator.Calculate(2, 3, Calculator.Add);

#endregion

#region Ref

//using Sandbox.ConsoleApp.Samples;

//int a = 32;

//RefSample.Increase(ref a);
//Console.WriteLine(a);

#endregion

#region IDisposable

using Sandbox.ConsoleApp.Samples;

if (true)
{
    using (var res = new ClassWithResources()) ;

    Console.WriteLine("End");
}

#endregion