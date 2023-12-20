using (ApplicationContext db = new ApplicationContext())
{
    var selector1 = db.Users.Where(u => u.Age > 30); // 
    var selector2 = db.Users.Where(u => u.Name!.Contains("Tom"));

    // İkinci seçimdə olmayanları götürmək
    var users = selector1.Except(selector2);

    foreach (var user in users)
        Console.WriteLine(user.Name);

    /*
     * SELECT "u"."Id", "u"."Age", "u"."CompanyId", "u"."Name"
       FROM "Users" AS "u"
       WHERE "u"."Age" > 30
       EXCEPT
       SELECT "u0"."Id", "u0"."Age", "u0"."CompanyId", "u0"."Name"
       FROM "Users" AS "u0"
       WHERE ('Tom' = '') OR (instr("u0"."Name", 'Tom') > 0)
     */
}

Console.WriteLine("\nDone!");