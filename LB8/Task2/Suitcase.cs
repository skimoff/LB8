namespace LB8.Task2;

public delegate void ItemAddedEventHandler(LuggageItem item);

public class Suitcase
{
    public string Color{get; set;}
    public string Manufacturer{get; set;}
    public double Weight {get; set;}  
    public double Volume{get; set;}
 
    private LuggageItem[] _items = new LuggageItem[0];
    
    public event ItemAddedEventHandler ItemAdded;

    public Suitcase(string color, string manufacturer, double weight, double volume)
    {
        Color = color;
        Manufacturer = manufacturer;
        Weight = weight;
        Volume = volume;
    }
    
    
    public double UsedVolume
    {
        get
        {
            double used = 0;
            foreach (var item in _items)
            {
                if (item != null)
                    used += item.Volume;
            }
            return used;
        }
    }

    public void AddItem(LuggageItem item)
    {
        if (UsedVolume + item.Volume > Volume)
            throw new InvalidOperationException("Перевищено допустимий об'єм валізи!");

        Array.Resize(ref _items, _items.Length + 1);
        _items[^1] = item;

        // Виклик події
        ItemAdded?.Invoke(item);
    }

    public void ShowContents()
    {
        Console.WriteLine("Вміст валізи:");
        foreach (var item in _items)
        {
            Console.WriteLine(" - " + item);
        }
        Console.WriteLine($"Зайнятий об'єм: {UsedVolume} / {Volume} л");
    }
}