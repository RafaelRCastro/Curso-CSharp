using Microsoft.AspNetCore.Mvc;

[ApiController]
[RouteAttribute("[controller]")]
public class MovieController : ControllerBase
{
    public MovieController()
    {

    }

    [HttpPost]
    public string Post()
    {
        return "Post";    
    }

    [HttpPut]
    public string Put()
    {
        return "Put";
    }

    [HttpGet]
    public string Get()
    {
        return "Get";
    }

    [HttpDelete]
    public string Delete()
    {
        return "Delete";
    }
}