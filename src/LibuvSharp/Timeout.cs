namespace LibuvSharp;

public static class Timeout
{
    private static Action<Exception?> End(TimeSpan timeSpan, Action<Exception?>? callback)
    {
        UVTimer? timer = null;

        void end(Exception? exception)
        {
            if(timer != null)
            {
                timer.Close();
                timer = null;
                callback?.Invoke(exception);
            }
        }

        timer = UVTimer.Once(timeSpan, () => end(new TimeoutException()));

        return end;
    }

    public static Action<Action<Exception?>?> In(TimeSpan timeSpan, Action<Action<Exception?>?> callback)
    {
        return cb =>
        {
            callback?.Invoke(End(timeSpan, cb));
        };
    }

    public static Action<T, Action<Exception?>?> In<T>(TimeSpan timeSpan, Action<T, Action<Exception?>?> callback)
    {
        return (argument, cb) =>
        {
            callback?.Invoke(argument, End(timeSpan, cb));
        };
    }

    public static Action<T1, T2, Action<Exception?>?> In<T1, T2>(TimeSpan timeSpan, Action<T1, T2, Action<Exception?>?> callback)
    {
        return (arg1, arg2, cb) =>
        {
            callback?.Invoke(arg1, arg2, End(timeSpan, cb));
        };
    }

    public static Action<T1, T2, T3, Action<Exception?>?> In<T1, T2, T3>(TimeSpan timeSpan, Action<T1, T2, T3, Action<Exception?>?> callback)
    {
        return (arg1, arg2, arg3, cb) =>
        {
            callback?.Invoke(arg1, arg2, arg3, End(timeSpan, cb));
        };
    }

    public static Action<T1, T2, T3, T4, Action<Exception?>?> In<T1, T2, T3, T4>(TimeSpan timeSpan, Action<T1, T2, T3, T4, Action<Exception?>?> callback)
    {
        return (arg1, arg2, arg3, arg4, cb) =>
        {
            callback?.Invoke(arg1, arg2, arg3, arg4, End(timeSpan, cb));
        };
    }

    public static Action<T1, T2, T3, T4, T5, Action<Exception?>?> In<T1, T2, T3, T4, T5>(TimeSpan timeSpan, Action<T1, T2, T3, T4, T5, Action<Exception?>?> callback)
    {
        return (arg1, arg2, arg3, arg4, arg5, cb) =>
        {
            callback?.Invoke(arg1, arg2, arg3, arg4, arg5, End(timeSpan, cb));
        };
    }

    public static Action<T1, T2, T3, T4, T5, T6, Action<Exception?>?> In<T1, T2, T3, T4, T5, T6>(TimeSpan timeSpan, Action<T1, T2, T3, T4, T5, T6, Action<Exception?>?> callback)
    {
        return (arg1, arg2, arg3, arg4, arg5, arg6, cb) =>
        {
            callback?.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, End(timeSpan, cb));
        };
    }

    public static Action<T1, T2, T3, T4, T5, T6, T7, Action<Exception?>?> In<T1, T2, T3, T4, T5, T6, T7>(TimeSpan timeSpan, Action<T1, T2, T3, T4, T5, T6, T7, Action<Exception?>?> callback)
    {
        return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, cb) =>
        {
            callback?.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, End(timeSpan, cb));
        };
    }

    public static Action<T1, T2, T3, T4, T5, T6, T7, T8, Action<Exception?>?> In<T1, T2, T3, T4, T5, T6, T7, T8>(TimeSpan timeSpan, Action<T1, T2, T3, T4, T5, T6, T7, T8, Action<Exception?>?> callback)
    {
        return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, cb) =>
        {
            callback?.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, End(timeSpan, cb));
        };
    }
}
