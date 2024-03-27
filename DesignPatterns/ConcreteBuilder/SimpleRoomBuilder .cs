using BuilderPattern.Product;

namespace BuilderPattern.ConcreteBuilder;

public class SimpleRoomBuilder
{
    public Room Build()
    {
        return new Room("Simple")
            .WithBed(1);
    }
}
