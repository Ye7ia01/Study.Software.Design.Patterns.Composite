namespace Software.Design.Patterns.Composite;

// The Interface / Abstract class defining common functionalities for leafs and composites 
// The client deals with this
public abstract class Component
{
    protected string Name;

    public Component(string name)
    {
        Name = name;
    }
    public abstract void AddChild(Component component);
    public abstract void RemoveChild(Component component);
    public abstract void Display(int depth);

}