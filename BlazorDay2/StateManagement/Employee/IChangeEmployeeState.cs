namespace BlazorDay2.StateManagement.Employee
{
    public interface IChangeEmployeeState
    {
        string? name { get; }
        void ChangeState(string state);
        void Subscribe(Action<string> subscriber);
        void Unsubscribe(Action<string> subscriber);
    }
}
