namespace HelloWorld.Arrays;

public class Quiz2_Lists
{
    public static void Run()
    {
    //Diary production MWh
    List<double> diaryProductionMWh = new List<double> { 55.3, 62.8, 48.4, 51.2, 67.5, 60.3, 66.4 };
    diaryProductionMWh.Add(59.4);
    diaryProductionMWh[2] = 55.6;
    diaryProductionMWh.RemoveAt(3);
    
    double diaryProductionMWhSum = diaryProductionMWh.Sum();
    double diaryProductionMWhLength = diaryProductionMWh.Count;
    double average = diaryProductionMWh.Sum() / diaryProductionMWhLength;

    Console.WriteLine($"Diary production math is: {average} MWh");
    }
}