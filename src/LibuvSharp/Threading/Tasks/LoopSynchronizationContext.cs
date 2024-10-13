namespace LibuvSharp.Threading.Tasks;

public class LoopSynchronizationContext(Loop loop, Thread thread) : SynchronizationContext
{
    public Loop Loop { get; private set; } = loop;

    public Thread Thread { get; private set; } = thread;

    public int PendingOperations { get; private set; }

    public LoopSynchronizationContext(Loop loop)
        : this(loop, Thread.CurrentThread)
    {
    }

    public override void Post(SendOrPostCallback d, object? state)
    {
        if(Thread == Thread.CurrentThread)
        {
            d(state);
        }
        else
        {
            Loop.Sync(() => d(state));
        }
    }

    public override void OperationStarted()
    {
        PendingOperations++;
        Loop.Ref();
    }

    public override void OperationCompleted()
    {
        Loop.Unref();
        PendingOperations--;
    }
}
