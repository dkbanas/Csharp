namespace genericTypes;

public delegate T Operation<T>(T a, T b);
public class Calculator
{
    public T GetResult<T>(T a, T b, Operation<T> operation)
    {
        return operation(a, b);
    }
}