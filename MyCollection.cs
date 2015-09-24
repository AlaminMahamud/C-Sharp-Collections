public class MyCollection : IEnumerable
{
	int[] data = {1,2,3};

	public IEnumerator GetEnumerator()
	{
		foreach(int i in data)
			yield return i;
	}
}