using System.Runtime.InteropServices.JavaScript;

namespace Software.Design.Patterns.Composite;

public class CompositeComponent : Component
{
    private List<Component> Children = new List<Component>();

    public CompositeComponent (string name) : base(name) {}

    public override void AddChild(Component component)
    {
        Children.Add(component);
    }

    public override void RemoveChild(Component component)
    {
        Children.Remove(component);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-',depth) + Name);
        foreach (var child in Children)
        {
            child.Display(depth + 2);
        }
    }
}