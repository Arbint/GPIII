//this is a dynamic array
using algrithm;

List<string> intList = new List<string>() { "a", "b", "c"};
DArray<string> dArray = new DArray<string>() { "e", "f", "g"};

//IEnumerator<string> enumerator = intList.GetEnumerator();
//while (enumerator.MoveNext())
//{
//    Console.WriteLine(enumerator.Current);
//}


//foreach(string item in intList)
//{
//    Console.WriteLine(item);
//}

foreach(string otherItem in dArray)
{
    Console.WriteLine(otherItem);
}