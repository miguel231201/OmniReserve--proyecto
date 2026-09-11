using OmnoReserve.Domain.Exceptions;

namespace OmniReserve.Domain.Exceptions;

public class RoomNotAvailableException : DomainException
{
    public RoomNotAvailableException(string roomNumber) : base("La habitación con el número " + roomNumber + " no está disponible para las fechas seleccionadas.")
    {
    }
}
