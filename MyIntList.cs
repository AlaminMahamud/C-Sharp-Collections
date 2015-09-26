public class MyIntList : IEnumerable
{
	int[] data = {1,2,3,4};

	public IEnumerator GetEnumerator()
	{
		return new Enumerator(this);
	}

	class Enumerator : IEnumerator	// define an inner class for the Enumerator
	{
		MyIntList collection;
		int currentIndex = -1;

		public Enumerator(MyIntList _collection)
		{
			this.collection = collection;
		}

		public object Current
		{
			get
			{
				if(currentIndex == -1)
					throw new InvalidOperationException("Enumeration not started!");
				if(currentIndex == collection.data.Length)
					throw new InvalidOperationException("Past End of List!");
				return collection.data[currentIndex];
			}
		}

		public bool MoveNext()
		{
			if(currentIndex >= collection.data.Length - 1) return false;
			return ++currentIndex < collection.data.Length;
		}

		public void Reset()
		{
			currentIndex = -1;
		}
	}
}