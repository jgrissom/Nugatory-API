using Microsoft.AspNetCore.Mvc;

[ApiController, Route("[controller]/word")]
public class ApiController(DataContext db) : ControllerBase
{
    private readonly DataContext _dataContext = db;

    // http get entire collection
    [HttpGet]
    public IEnumerable<WordColor> Get()
    {
        return _dataContext.WordColors;
    }
}
