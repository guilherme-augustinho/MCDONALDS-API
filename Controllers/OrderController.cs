using System;
using McDonaldsAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace MCDONALDS_API.Controller;

[ApiController]
[Route("order")]
public class OrderController : ControllerBase
{
    [HttpPost("create/{storeId}")]
    public async Task<ActionResult> CreateOrder(int storeId, [FromServices]IOrderRepository repo)
    {
        try
        {
            var orderId = await repo.CreateOrder(storeId);
            return Ok(orderId);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}

