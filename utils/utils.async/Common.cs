using System.Runtime.CompilerServices;

namespace utils
{

    public interface IAwaiter : INotifyCompletion
    {
        bool IsCompleted { get; }
        void GetResult();
    }
    public interface IAwaiter<TResult> : INotifyCompletion
    {
        bool IsCompleted { get; }
        TResult GetResult();
    }
    public interface IAwaitable
    {
        IAwaiter GetAwaiter();
    }
    public interface IAwaitable<TResult>
    {
        IAwaiter<TResult> GetAwaiter();
    }

}
