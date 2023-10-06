namespace LockSolver.Hints;

public class NoMatchHint:IHint
{
    private readonly string _hint;

    public NoMatchHint(string hint)
    {
        _hint = hint;
    }
    
    public bool IsMatch(string candidate)
    {
        return candidate.Any(c => _hint.Contains(c));
    }
}