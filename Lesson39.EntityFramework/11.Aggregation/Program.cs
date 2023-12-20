using (ApplicationContext db = new ApplicationContext())
{
    // Hər-hansı biri
    bool result = db.Users.Any(u => u.Company!.Name == "Google");

    // Hamısı
    bool result2 = db.Users.All(u => u.Company!.Name == "Microsoft");

    // Sayı
    int number1 = db.Users.Count();
    // Şərtə əsasən sayı
    int number2 = db.Users.Count(u => u.Name!.Contains("Tom"));

    Console.WriteLine(number1);
    Console.WriteLine(number2);

    // Minimal yaş
    int minAge = db.Users.Min(u => u.Age);
    // Maksimal yaş
    int maxAge = db.Users.Max(u => u.Age);
    // Microsoft-da işləyənlərin orta yaşı
    double avgAge = db.Users.Where(u => u.Company!.Name == "Microsoft")
                        .Average(p => p.Age);

    Console.WriteLine(minAge);
    Console.WriteLine(maxAge);
    Console.WriteLine(avgAge);

    // Yaşların cəmi 
    int sum1 = db.Users.Sum(u => u.Age);
    // Microsoft-da işləyənlərin yaşının cəmi
    int sum2 = db.Users.Where(u => u.Company!.Name == "Microsoft")
                        .Sum(u => u.Age);
    Console.WriteLine(sum1);
    Console.WriteLine(sum2);
}

Console.WriteLine("\nDone!");