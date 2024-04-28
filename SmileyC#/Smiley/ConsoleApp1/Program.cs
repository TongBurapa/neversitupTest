using Smileface;

var Smiley = new SmilyFaceFunction();

// 1
// string[] input = { ";]", ":[", ";*", ":$", ";-D" };

// 2
string[] input = { ":)", ";(", ";}", ":-D" };

// 3
// string[] input = {  ":D", ":-(", ":-)", ";~)" };
int result = Smiley.SmileyCheck(input);
Console.WriteLine(result);

