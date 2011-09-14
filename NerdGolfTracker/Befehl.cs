namespace NerdGolfTracker
{
    public interface Befehl
    {
        string Kommando { get; }
        Operation Operation { get; }
        string Erklaerung { get; }
    }
}