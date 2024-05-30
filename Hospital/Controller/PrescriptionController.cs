using Hospital.DTO.Request;
using Hospital.DTO.Response;
using Hospital.Service;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controller;

[Route("api/[controller]")]
[ApiController]
public class PrescriptionController : ControllerBase
{
    private readonly IPrescriptionService _prescriptionService;

    public PrescriptionController(IPrescriptionService prescriptionService)
    {
        _prescriptionService = prescriptionService;
    }

    [HttpPost]
    public async Task<ActionResult<PrescriptionQueryDTO>> AddPrescription(PrescriptionCreateDTO prescriptionCreateDTO)
    {
        try
        {
            var prescription = await _prescriptionService.AddPrescriptionAsync(prescriptionCreateDTO);
            return Ok(prescription);
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }
}