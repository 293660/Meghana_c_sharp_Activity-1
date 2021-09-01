string[] teamCS = enteries[0];
string[] teamMath = enteries[1];
string[] teamSc = enteries[2];

string firstMemberCS = teamCS[1];
for (int size = 0; size < enteries.Length; size++)
{
   Console.WriteLine("Team {0}: ",enteries[size][0]); // team name
   for (int innerArrSize = 1; innerArrSize < enteries[size].Length; innerArrSize++)
   {
     Console.WriteLine(" {0}",enteries[size][innerArrSize]);// names of team members
 }
}
foreach (string[] team in enteries) // string[]: for inner array
{
  foreach (string element in team)
  {
   Console.WriteLine("{0}",element);
  }
}
//or
foreach (var team in enteries)
{
 foreach (var element in team)
 {
    Console.WriteLine("{0}",element);
 }
}
