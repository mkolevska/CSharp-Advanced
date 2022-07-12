using SEDC.Oop.Class11.Homework.TreeCommand.Entities;
using SEDC.Oop.Class11.Homework.TreeCommand.HelperService;

try
{
    if (args.Length == 0)
    {
        new ConsoleWriter();
    }
    else if (args.Length == 1)
    {
        new ConsoleWriter(args[0]);
    }
    else if (args.Length == 2)
    {
        new ConsoleWriter(args[0], args[1]);
    }
    else
    {
        throw new ApplicationException("You can only enter up to 2 parameters");
    }
}
catch (ApplicationException ex)
{
    Logger.Log(ex.Message);
    Console.WriteLine(ex.Message);
}




