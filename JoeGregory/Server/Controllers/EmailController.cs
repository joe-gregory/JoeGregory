using Microsoft.AspNetCore.Mvc;
using JoeGregory.Server.Services;


[Route("api/[controller]")]
[ApiController]
public class EmailController : ControllerBase
{
    private readonly EmailService _emailService;

    public EmailController(EmailService emailService)
    {
        _emailService = emailService;
    }

    [HttpPost]
    public async Task<IActionResult> SendEmail([FromBody] ContactModel model)
    {
        try
        {
            _emailService.SendEmail(model.Email, model.Name, model.Message);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}

public class ContactModel
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Message { get; set; }
}