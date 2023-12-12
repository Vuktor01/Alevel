using System;
using System.Threading.Tasks;

public class MessageBox
{
    public event EventHandler<StateEventArgs> WindowClosed;

    public async void Open()
    {
        Console.WriteLine("Window is open");
        await Task.Delay(3000);
        Console.WriteLine("Window was closed by the user");
        OnWindowClosed(GetRandomState());
    }

    private State GetRandomState()
    {
        Array values = Enum.GetValues(typeof(State));
        Random random = new Random();
        State randomState = (State)values.GetValue(random.Next(values.Length));
        return randomState;
    }

    protected virtual void OnWindowClosed(State state)
    {
        WindowClosed?.Invoke(this, new StateEventArgs(state));
    }
}

public enum State
{
    Ok,
    Cancel
}

public class StateEventArgs : EventArgs
{
    public State State { get; }

    public StateEventArgs(State state)
    {
        State = state;
    }
}