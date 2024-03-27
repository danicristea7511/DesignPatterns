using DependencyInjectionPattern.Interface;

namespace DependencyInjectionPattern.Concrete;

class DestinationAddress: IAddress
{
    public string ZipCode { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
}
