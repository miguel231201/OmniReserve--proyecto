using MediatR;

namespace OmniReserve.Application.Rooms.Queries.GetRoomById;

public class GetRoomByIdQueryHandler : IRequestHandler<GetRoomByIdQuery, RoomResponseDto>
{
    public async Task<RoomResponseDto> Handle(GetRoomByIdQuery request, CancellationToken cancellationToken)
    {
    }
}