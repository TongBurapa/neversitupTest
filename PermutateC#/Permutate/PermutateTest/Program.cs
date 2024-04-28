using Permutate;

var permutateClass = new PermutateClass();
var input = "aabb";
var result = permutateClass.AllPermutations(input);

foreach(var str in result)
{
    Console.WriteLine(str);
}