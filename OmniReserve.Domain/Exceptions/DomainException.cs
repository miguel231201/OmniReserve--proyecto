namespace OmniReserve.Domain.Exceptions;

public class DomainException : Excception
{
    public DomainException(string message) : base(message)
    {
    }
}