using static LibuvSharp.Libuv;

namespace LibuvSharp;

public enum PollEvent
{
	Read = 1,
	Write = 2,
}

public class Poll : Handle
{
	public Poll(int fd)
		: this(Loop.Constructor, fd)
	{
	}

	public Poll(Loop loop, int fd)
		: base(loop, HandleType.UV_POLL, uv_poll_init, fd)
	{
		poll_cb += pollcallback;
	}

	public void Start(PollEvent events)
	{
		Invoke(uv_poll_start, (int)events, poll_cb);
	}

	public void Stop()
	{
		Invoke(uv_poll_stop);
	}

	private event poll_callback poll_cb;

	private void pollcallback(IntPtr handle, int status, int events)
	{
		OnEvent((PollEvent)events);
	}

	public event Action<PollEvent>? Event;

	private void OnEvent(PollEvent events)
	{
		Event?.Invoke(events);
	}
}