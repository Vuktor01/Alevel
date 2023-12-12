using System;

class Program
{
    static void Main()
    {
        MessageBox messageBox = new MessageBox();
        messageBox.WindowClosed += MessageBox_WindowClosed;
        messageBox.Open();
    }

    private static void MessageBox_WindowClosed(object sender, StateEventArgs e)
    {
        if (e.State == State.Ok)
        {
            Console.WriteLine("Operation confirmed");
        }
        else if (e.State == State.Cancel)
        {
            Console.WriteLine("Operation rejected");
        }
    }
}