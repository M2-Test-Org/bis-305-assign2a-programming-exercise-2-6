using Xunit;
using System.IO;
using System;

public class Assignment1Tests
{

    [Fact]
    public void Assign2MoveEstimate2_6()
    {
        //Sets the Out property to target the TextWriter object. Note that the System.IO.StringWriter is 
        //derived from TextWriter. The TextWriter class is an abstract class. Therefore, you do not 
        //instantiate it in your code.
        //The StreamWriter class derives from TextWriter and provides implementations of the members for 
        //writing to a stream. 
        var output = new StringWriter();
        Console.SetOut(output);

        //Sets the In property to the specified TextReader object. System.IO.StringReader is derived
        //from TextReader. The TextReader class is an abstract class. Therefore, you do not instantiate 
        //it in your code.
        //The StreamReader class derives from TextReader and provides implementations of the 
        //members for reading from a stream.
        var hoursInput = "10";
        var milesInput = "10";
        //separte multiple inputs with a new line break
        var input = new StringReader(hoursInput + Environment.NewLine + milesInput);
        Console.SetIn(input);
        
        MoveEstimator.Main();

        Assert.Equal(string.Format("For a move taking {0} hours and going {1} miles the estimate is {2}{3}",
            Convert.ToDouble(hoursInput), Convert.ToDouble(milesInput), "$1,720.00", Environment.NewLine), output.ToString());
    }
}
