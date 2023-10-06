namespace LockSolver.Hints;

public class RightDigitWrongPlace:IHint
{
    private readonly string _hint;

    public RightDigitWrongPlace(string hint)
    {
        _hint = hint;
    }
    public bool IsMatch(string candidate)
    {
        return candidate.Zip(_hint, (c, h) => c != h && _hint.Contains(c) ? 1 : 0).Sum() == 0;
    }
}