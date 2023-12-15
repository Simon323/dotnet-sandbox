#region ClassWithDestructor

using Sandbox.ConsoleApp.Samples;

for (int i = 0; i < 100; i++)
{
    var obj = new ClassWithDestructor();
    GC.Collect();
    GC.WaitForPendingFinalizers();
}

#endregion
