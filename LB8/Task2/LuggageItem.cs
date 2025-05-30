namespace LB8.Task2;


public class LuggageItem
{
    public string Name { get; set; }
    public double Volume { get; set; }

    public LuggageItem(string name, double volume)
    {
        Name = name;
        Volume = volume;
    }

    public override string ToString()
    {
        return $"{Name} (об'єм: {Volume} л)";
    }
}