// IEnumerable<T> and IEnumerator<T>

public interface IEnumerator<T> : IEnumerator, IDisposable
{
	T Current{get;}
}

public interface IEnumerable<T> : IEnumerator
{
	IEnumerator<T> GetEnumerator();
}