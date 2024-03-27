namespace DependencyInjectionPattern.Interface;

public interface IAddress
{
    string ZipCode { get; set; }
    string Country { get; set; }
    string City { get; set; }
}
