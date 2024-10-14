using Microsoft.AspNetCore.Mvc;
using Grpc.Net.Client;
using GrpcService; // Замените на ваше пространство имен
using router; // Замените на ваше пространство имен

[ApiController]
[Route("api/[controller]")]
public class RouteController : ControllerBase
{
    private readonly Route.RouteClient _routeClient;

    public RouteController(Route.RouteClient routeClient)
    {
        _routeClient = routeClient;
    }

    [HttpPost("calculate")]
    public async Task<ActionResult<RouteResponse>> CalculateRoute([FromBody] RouteRequest request)
    {
        var response = await _routeClient.CalculateRouteAsync(request);
        return Ok(response);
    }
}
