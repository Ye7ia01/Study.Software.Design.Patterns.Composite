namespace Software.Design.Patterns.Composite;

public class LeafComponent2Example : Component
{
    public LeafComponent2Example(string name) : base(name)
    {
    }

    public override void AddChild(Component component)
    {
        throw new NotImplementedException();
    }

    public override void RemoveChild(Component component)
    {
        throw new NotImplementedException();
    }

    public override void Display(int depth)
    {
        throw new NotImplementedException();
    }
}