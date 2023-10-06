namespace LockSolver.Hints;

public class ExactMatchHint:IHint
{
    private readonly string _hint;

    public ExactMatchHint(string hint)
    {
        _hint = hint;
    }
    public bool IsMatch(string candidate)
    {
        return candidate.Zip(_hint, (c, h) => c == h ? 1 : 0).Sum() == 1;
    }
}