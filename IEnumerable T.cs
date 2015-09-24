//IEnumera
tor<T>, you must cast to expose the explicit interface:

int[] data= {1,2,3};
var rator = ((IEnumerable<T>)data).GetEnumerator;