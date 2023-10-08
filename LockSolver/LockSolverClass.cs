namespace LockSolver;

public class LockSolverClass
{
   

    private readonly List<IHint> hints; 
    private readonly int digitLength;
    public LockSolverClass(List<IHint> hints, int digitLength)
    {
        this.hints = hints;
        this.digitLength = digitLength;
    }

    public string Solve()
    {
        for (int i = 0; i < Math.Pow(10, digitLength) - 1; i++)
        {
            string candidate = i.ToString("D" + digitLength);
            if (hints.All(h=>h.IsMatch(candidate)))
            {
                return candidate;
            }
        }

        return "No Key Found";
    }
    
 
}