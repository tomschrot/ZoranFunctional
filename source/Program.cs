
/*
    https://www.youtube.com/watch?v=uHn_Nts4TVQ
*/

using ZoranFunctional.Models;

Console.WriteLine("Alternative Functional Types");

var a = Name.Create (string.Empty);
var b = Name.Create ("Tom");
var c = Name.Create ("Tom", "Petersen");

var list = Name.CreateList ()
            .Append (a)
            .Append (b)
            .Append (c)
            .Append ("Brian" , "Kernighan")
            .Append ("Dennis", "Ritchie"  )
            .Append (Name.Create("E. Gamma"))
            .ToArray ()
            ;

var book = Book.Create
(
    "Design Patterns - Elements of Reusable Object-Oriented Software",
    Name.CreateList ()
            .Append ("Erich"  , "Gamma"    ) //FullName
            .Append ("Richard", "Helm"     ) //FullName
            .Append ("Ralph"  , "Johnson"  ) //FullName
        //  .Append ("John"   , "Vlissides") //FullName
            .Append ("J. Vlissides")         //Mononym
            .ToArray ()
);

Console.WriteLine( book );

