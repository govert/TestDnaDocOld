using ExcelDna.Documentation;
using ExcelDna.Integration;

namespace TestDnaDoc
{
    public class Class1
    {
        [ExcelFunctionDoc("Returns a greeting.", Description = "Function that returns a greeting.",
            Returns = "The string 'Hello'.",
            HelpTopic = "TestDnaDocOld-AddIn.chm!101")]
        public static object SayHello(
            [ExcelArgument(Name = "name", Description = "The name to greet.")] string name
            )
        {
            return "Hello " + name;
        }
    }
}
