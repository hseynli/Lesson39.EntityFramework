using (ApplicationContext db = new ApplicationContext())
{
    // Fərq
    var users = db.Users.Where(u => u.Age > 30)
                        .Intersect(db.Users.Where(u => u.Name!.Contains("Tom")));

    foreach (var user in users)
        Console.WriteLine(user.Name);

    /*
     * SELECT "u"."Id", "u"."Age", "u"."CompanyId", "u"."Name"
       FROM "Users" AS "u"
       WHERE "u"."Age" > 30
       INTERSECT
       SELECT "u0"."Id", "u0"."Age", "u0"."CompanyId", "u0"."Name"
       FROM "Users" AS "u0"
       WHERE ('Tom' = '') OR (instr("u0"."Name", 'Tom') > 0)
     */
}

Console.WriteLine("\nDone!");