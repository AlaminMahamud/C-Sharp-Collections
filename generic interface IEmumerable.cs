// we can also implement the generic interface IEnumerable<T> 

public class MyGenCollection : IEnumerable<int>
{
	int[] data = {1,2,3};
	public IEnumerator<int> GetEnumerator()
	{
		foreach(int i in data)
			yield return i;
	}

	IEnumerator IEnumerable.GetEnumerator() // Explicit Implementation
	{
		return GetEnumerator(); // keeps it hidden
	}
}