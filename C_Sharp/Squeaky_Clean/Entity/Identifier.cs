namespace Squeaky_Clean.Entity;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        if (string.IsNullOrEmpty(identifier))
            return "";

        string resultIdentifier = "";

        for (int i = 0; i < identifier.Length; i++)
        {
            if (Char.IsWhiteSpace(identifier[i]))
            {
                resultIdentifier += "_";
            }
            else if (Char.IsControl(identifier[i]))
            {
                resultIdentifier += "CTRL";
            }
            else if (identifier[i] == '-')
            {
                resultIdentifier += identifier[i + 1].ToString().ToUpper();
                i++;
            }
            else if (identifier[i] >= 'α' && identifier[i] <= 'ω')
            {
                continue;
            }
            else
            {
                if (Char.IsLetter(identifier[i]))
                    resultIdentifier += identifier[i];
            }
        }

        return resultIdentifier;
    }
}
