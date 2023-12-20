using (ApplicationContext db = new ApplicationContext())
{
    // пересоздаем базу данных
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();

    Company microsoft = new Company { Name = "Microsoft" };
    Company google = new Company { Name = "Google" };
    db.Companies.AddRange(microsoft, google);

    User tom = new User { Name = "Tom", Age = 36, Company = microsoft };
    User bob = new User { Name = "Bob", Age = 39, Company = google };
    User alice = new User { Name = "Alice", Age = 28, Company = microsoft };
    User kate = new User { Name = "Kate", Age = 25, Company = google };

    db.Users.AddRange(tom, bob, alice, kate);
    db.SaveChanges();

    var users = db.Users.Where(u => u.Age < 30)
                        .Union(db.Users.Where(u => u.Name!.Contains("Tom")));
    foreach (var user in users)
        Console.WriteLine(user.Name);

    /*
     * SELECT "u"."Id", "u"."Age", "u"."CompanyId", "u"."Name"
       FROM "Users" AS "u"
       WHERE "u"."Age" < 30
       UNION
       SELECT "u0"."Id", "u0"."Age", "u0"."CompanyId", "u0"."Name"
       FROM "Users" AS "u0"
       WHERE ('Tom' = '') OR (instr("u0"."Name", 'Tom') > 0)
     */
}

Console.WriteLine("\nDone!");