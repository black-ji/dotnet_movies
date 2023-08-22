using Microsoft.AspNetCore.Mvc;

namespace movies.api.Controllers;

[ApiVersion("1")]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiController]
public class ApiController: ControllerBase{}