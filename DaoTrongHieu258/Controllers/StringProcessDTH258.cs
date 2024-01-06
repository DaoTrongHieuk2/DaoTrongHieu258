using Microsoft.AspNetCore.Mvc;

namespace DaoTrongHieu258.Controllers;

public class StringProcessDTH258 : Controller
{
    public ActionResult ToLowerToUpper(string input)
    {
        string result = input.ToLower().ToUpper();
        return Content(result);
    }
}

