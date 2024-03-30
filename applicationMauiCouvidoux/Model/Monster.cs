namespace applicationMauiCouvidoux.Model;

public class Monster
{
    public int Id { get; set; }
    public string Image { get; set; }
    public string Name { get; set; }
    public List<Element> Elements { get; set; }
    public List<Weakness> Weakness { get; set; }
    public List<Resistance> Resistance { get; set; }
    public Stats Stats { get; set; }
    public Boolean visible { get; set; } = true;
}

public class Element
{
    public string Type { get; set; }
    public string Image { get; set; }
}

public class Weakness
{
    public string Type { get; set; }
    public string Image { get; set; }
}

public class Resistance
{
    public string Type { get; set; }
    public string Image { get; set; }
}

public class Stats
{
    public int Strength { get; set; }
    public int Magic { get; set; }
    public int Health { get; set; }
    public int Defence { get; set; }
    public int Potion { get; set; }
}