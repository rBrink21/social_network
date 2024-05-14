namespace social_network.Model;

public enum Theme
{
    Journal,
    Dark,
    Minty,
    Materia,
    Vapor,
    Bootstrap,
    Quartz,
    Pulse,
    Sketchy,
}

public static class ThemeExtensions
{
    public static string ToCSS(this Theme theme)
    {
        switch (theme)
        {
            case Theme.Journal:
                return "/bootstrap/journal.css";
            case Theme.Dark:
                return "/bootstrap/dark.css";
            case Theme.Minty:
                return "/bootstrap/minty.css";
            case Theme.Materia:
                return "/bootstrap/Materia.css";
            case Theme.Vapor:
                return "/bootstrap/vapor.css";
            case Theme.Bootstrap:
                return "/bootstrap/bootstrap_classic.css";
            case Theme.Quartz:
                return "/bootstrap/quartz.css";
            case Theme.Pulse:
                return "/bootstrap/pulse.css";
            case Theme.Sketchy:
                return "/bootstrap/sketchy.css";
            default:
                throw new ArgumentOutOfRangeException(nameof(theme), theme, null);
        }
    }
}