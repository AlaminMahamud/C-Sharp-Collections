// following Methods counts elements in any collection recursively

public static int Count(IEnumerable e)
{
	int count = 0;
	foreach(object element in e)
	{
		var subCollection = element as IEnumerable;
		if(subCollection != null)
			count += Count(subCollection);
		else
			count++;
	}
	return count++;
}