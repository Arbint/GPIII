//this is a dynamic array
using algrithm;
using System.Collections;

List<string> intList = new List<string>() { "a", "b", "c"};
DArray<string> dArray = new DArray<string>() { "e", "f", "g"};

foreach(string item in dArray)
{
    Console.WriteLine(item);
}