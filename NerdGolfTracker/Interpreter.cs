namespace NerdGolfTracker
{
    public interface Interpreter
    {
        Operation OperationFuer(string kommando);
    }
}