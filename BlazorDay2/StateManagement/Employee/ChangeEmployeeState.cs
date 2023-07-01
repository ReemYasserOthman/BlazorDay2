namespace BlazorDay2.StateManagement.Employee
{
    public class ChangeEmployeeState : IChangeEmployeeState
    {
        Action<string>? subscribers;
        public string? name { get; private set; }

        public void ChangeState(string state)
        {
            name = state;
            if (subscribers != null)
            {
                subscribers.Invoke(name);
            }
        }

        public void Subscribe(Action<string> subscriber)
        {
            subscribers += subscriber;
        }

        public void Unsubscribe(Action<string> subscriber)
        {
            subscribers -= subscriber;
        }
    }
}
