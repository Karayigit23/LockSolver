// See https://aka.ms/new-console-template for more information

using LockSolver;
using LockSolver.Hints;

List<IHint> GetHints_1()
{
    return new List<IHint>()
    {
        new ExactMatchHint("682"),
        new RightDigitWrongPlace("614"),
        new TwoRightDigitWrongPlace("206"),
        new NoMatchHint("738"),
        new RightDigitWrongPlace("780")

    };
}