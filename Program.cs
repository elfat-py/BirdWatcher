// See https://aka.ms/new-console-template for more information

class BirdWatcher
{
    public static void Main(string[] args)
    {
        int[] lastWeek = { 3, 5, 6, 8, 9, 7, 8 };
        int[] thisWeekBirdsNum = { 5, 7, 8, 7, 3, 9, 4 };

        int birdsToday = todayBirdsNum(thisWeekBirdsNum);
        int increasedBirdsNum = increaseTodayCount(birdsToday);
        bool dayWithoutBirds = BirdWatcher.dayWithoutBirds(thisWeekBirdsNum);
        int numberOfBirdsAllWeek = totalNumberBirds(thisWeekBirdsNum);
        
        Console.WriteLine($"The number of birds today is: {birdsToday}");
        Console.WriteLine($"The number of birds after their number is increased: {increasedBirdsNum}");
        Console.WriteLine($"During the week there were no birds: {dayWithoutBirds}");
        Console.WriteLine($"The total number of birds throught the week: {numberOfBirdsAllWeek}");
        
    }

    static bool dayWithoutBirds(int[] thisWeekBirds)
    {
        bool dayWithoutBirds = false;
        for (int i = 0; i < thisWeekBirds.Length; i++)
        {
            if (thisWeekBirds[i]==0)
            {
                dayWithoutBirds = true;
                break;
            }
        }

        return dayWithoutBirds;
    }

    static int todayBirdsNum(int [] thisWeekBirds)
    {
        int todayBirdNum = -1;
        for (int i = 0; i < thisWeekBirds.Length; i++)
        { 
            todayBirdNum = thisWeekBirds[thisWeekBirds.Length-1];
        }

        return todayBirdNum;
    }

    static int increaseTodayCount(int todayBirdsNum)
    {
        int increasedCount = 0;
        increasedCount += todayBirdsNum;
        return increasedCount;
    }

    static void lastWeekBirds(int [] lastWeek)
    {
        
        string[] dayOftheWeekBirds = { "Monday", "Tuesday", "Wensday", "Thursday", "Friday", "Saturdsay", "Sunday" };
        for (int i = 0; i < lastWeek.Length; i++)
        { 
            Console.WriteLine($"On {dayOftheWeekBirds[i]} there were: {lastWeek[i]}");
        }
        
    }

    static int totalNumberBirds(int[] thisWeekBirds)
    {
        int totalBirds = 0;
        for (int i = 0; i < thisWeekBirds.Length; i++)
        {
            totalBirds += thisWeekBirds[i];
            
        }

        return totalBirds;
    }
}
