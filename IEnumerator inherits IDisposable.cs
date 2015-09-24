// IEnumerator inherits IDisposable

foreach (var element in somethingEnumerable){...}


// into the Logical Equivalent of this:

using (var rator = somethingEnumerable.GetEnumerator())
	while(rator.MoveNext())
	{
		var element = rator.Current;
		...
	}


