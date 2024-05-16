
namespace ZoranFunctional.Models;

using Names = List<Name>;

public sealed record FullName (string FirstName, string LastName ): Name;
public sealed record Mononym  (string Name)                       : Name;

public abstract record Name
{
    //-------------------------------------------------------------------------

    public static Name? Create (string firstname, string? lastname = null)
        =>
            string.IsNullOrWhiteSpace (firstname)
                ? null
                : string.IsNullOrWhiteSpace (lastname)
                    ? new Mononym  (firstname)
                    : new FullName (firstname, lastname);
    //-------------------------------------------------------------------------

    public static Names CreateList () => [];

    //-------------------------------------------------------------------------
}

