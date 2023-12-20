using (ApplicationContext db = new ApplicationContext())
{
    User? user = db.Users.Find(3); // id=3
                                   
    if (user != null) Console.WriteLine($"{user.Name} ({user.Age})");
}

/*
 SELECT "u"."Id", "u"."Age", "u"."CompanyId", "u"."Name"
 FROM "Users" AS "u"
 WHERE "u"."Id" = @__p_0
 LIMIT 1
 */

Console.WriteLine("\nDone!");