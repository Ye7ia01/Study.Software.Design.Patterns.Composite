namespace Software.Design.Patterns.Composite;

public class LeafComponent : Component
{
    public LeafComponent(string name) : base(name)
    {
    }

    public override void AddChild(Component component)
    {
        Console.WriteLine("Cannot add nodes to leaf");
    }

    public override void RemoveChild(Component component)
    {
        Console.WriteLine("Cannot add nodes to leaf");
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + Name);
    }
}