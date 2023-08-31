//this is a dynamic array
using algrithm;

List<string> intList = new List<string>() { "a", "b", "c"};
DArray<string> dArray = new DArray<string>();
dArray.Add("e");
dArray.Add("f");
dArray.Add("g");

IEnumerator<string> enumerator = intList.GetEnumerator();
while (enumerator.MoveNext())
{
    Console.WriteLine(enumerator.Current);
}


foreach(string item in intList)
{
    Console.WriteLine(item);
}

foreach(string item in dArray)
{

}