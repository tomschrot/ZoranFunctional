
using System.Text;

namespace ZoranFunctional.Models;

public partial record Book (string Title, Name[] Authors);

public partial record Book
{
    public static Book? Create (string Title, Name[] Authors)
        =>
            String.IsNullOrWhiteSpace (Title) || (Authors?.Length ?? 0) == 0
            ? null
            : new (Title, Authors!);

    override
    public string ToString ()
    {
        var sb = new StringBuilder ();

        sb
        .Append ('"')
        .Append (Title)
        .Append ('"')
        .Append ("\n\tby\n")
        ;

        foreach (var author in Authors)
            sb.AppendFormat ("\t   {0}\n", author.Format());

        return sb.ToString ();
    }
}
