 
 void FindUnder3Digits(string[] Array)
{
    var TargetArray = new string[Array.Length];
    var TargetArraySize = 0;
        foreach (var value in Array )
        {
            if (value.Length <= 3)
            {
                TargetArray[TargetArraySize] = value;
                TargetArraySize++;
            }
        }
    Console.WriteLine($"[ {String.Join(", ", TargetArray, 0, TargetArraySize)} ]");
    Console.WriteLine();    
}           

Console.WriteLine("Введите произвольное число слов/чисел через пробел:");
string input = Console.ReadLine();
string[] InputArray = input.Split(' ');

FindUnder3Digits(InputArray);
