string dayStr = Console.ReadLine();
int dayInt = Convert.ToInt32(dayStr);
if ((dayInt > 0) && (dayInt < 6)) Console.WriteLine("no");
else if ((dayInt < 8) && (dayInt > 5)) Console.WriteLine("yes");
    else Console.WriteLine("error");