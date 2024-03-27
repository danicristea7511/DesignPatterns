using BuilderPattern.Product;

namespace BuilderPattern.ConcreteBuilder;

public class FamilyRoomBuilder
{
    public Room Build()
    {
        return new Room("Family")
            .WithBalcony()
            .WithWiFi()
            .WithBed(3);
    }
}
