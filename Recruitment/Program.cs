using System.Security.Principal;

List<string> names = ["Micke", "Martin", "Lena"];

names[1] = "Nicholas";

names.Add("Ludde");
names.Add("Jessica");
names.Add("Linda");

names.Remove("Micke");
names.RemoveAt(1);

if (names.Contains("jessica") == true)
{
  Console.WriteLine("yes, hon finns i listan");
}

// Console.WriteLine(string.Join("\n", names));

for (int i = 0; i < names.Count; i++)
{
  Console.WriteLine(names[i]);
}


// string name = Console.ReadLine();
// if (name == names[1])
// {
//   Console.WriteLine("Hej dummer!");
// }

// Console.WriteLine(names[1]);

Console.ReadLine();