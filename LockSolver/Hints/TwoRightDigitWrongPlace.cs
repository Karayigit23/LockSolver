namespace LockSolver.Hints;

public class TwoRightDigitWrongPlace:IHint
{
    private readonly string _hint;

    public TwoRightDigitWrongPlace(string hint)
    {
        _hint = hint;
    }
    public bool IsMatch(string candidate)
    {
        return candidate.Zip(_hint, (c, h) => c != h && _hint.Contains(c) ? 1 : 0).Sum() == 2;
    }
}