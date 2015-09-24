// The Following example illustrates low-level use of IEnumerable and IEnumerator :

using System;

class Program
{
	static void Main()
	{
		string s = "Hello";

		// Because string implements IEnumerable, we can call GetEnumerator():

		IEnumerator rator = s.GetEnumerator();
		while(rator.MoveNext())
		{
			char c = (char)rator.Current;
			Console.Write(c+".");
		}
	}

}

// The Following is the alternative



string s = "Hello";
foreach(char c in s)
	Console.Write(c+".");
Console.WriteLine();