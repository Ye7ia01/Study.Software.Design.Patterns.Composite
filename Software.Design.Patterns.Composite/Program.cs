// The Composite Pattern is a pattern for structuring and using Hierarchy structures
// Allowing using Leafs and composite the same way by client 
// Structure can have multiple Leaf Components but one Composite components
using Software.Design.Patterns.Composite;

CompositeComponent root = new CompositeComponent("root");
root.AddChild(new LeafComponent("Leaf A"));
root.AddChild(new LeafComponent("Leaf B"));

CompositeComponent comp = new CompositeComponent("Composite X");
comp.AddChild(new LeafComponent("Leaf XA"));
comp.AddChild(new LeafComponent("Leaf XB"));

root.AddChild(comp);
root.AddChild(new LeafComponent("Leaf C"));
// Add and remove a leaf
LeafComponent leaf = new LeafComponent("Leaf D");
root.AddChild(leaf);
root.RemoveChild(leaf);
// Recursively display tree
root.Display(1);