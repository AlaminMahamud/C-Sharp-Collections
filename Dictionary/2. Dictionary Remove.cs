//C# That uses Remove

using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		Dictionary<string, int> d = new Dictionary<string, int>();
		d.Add("cat", 1);
		d.Add("dog", 2);

		d.Remove("cat"); // Removes cat
		d.Remove("nothing"); // Doesn't Remove Anything 
	}
}	