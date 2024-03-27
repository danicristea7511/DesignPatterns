using BuilderPattern.ConcreteBuilder;

Console.WriteLine("Builder Sample");

var simpleRoom = new SimpleRoomBuilder().Build();
simpleRoom.Describe();

var familyRoom = new FamilyRoomBuilder().Build();
familyRoom.Describe();

Console.ReadLine();
