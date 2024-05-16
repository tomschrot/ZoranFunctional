
namespace ZoranFunctional.Models;

using Names = List<Name>;

public static class NameExtensions
{
    //-------------------------------------------------------------------------
    public static Names Append (this Names names, Name? name)
    {
        if (name is not null) names.Add (name);
        return names;
    }
    //-------------------------------------------------------------------------

    public static Names Append (this Names names, string firstname, string? lastname = null)
        =>
            names.Append (Name.Create (firstname, lastname));
    //-------------------------------------------------------------------------

    public static void Differ
    (
        this Name          name,
        Action <FullName>? onFullName = null,
        Action <Mononym >? onMononym  = null
    )
    {
        switch (name)
        {
            case FullName full: onFullName?.Invoke (full); break;
            case Mononym  mono: onMononym ?.Invoke (mono); break;
        }
    }
    //-------------------------------------------------------------------------

    public static string? Format (this Name name)
    {
        string? result = null;

        name.Differ
        (
            onFullName: n => result = $"{n.FirstName} {n.LastName}",
            onMononym : n => result = n.Name
        );

        return result;
    }
    //-------------------------------------------------------------------------
}

