using Hospital.Service;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controller;

[ApiController]
[Route("api/[controller]")]
public class PatientsController : ControllerBase
{
    private readonly IPatientService _patientService;

    public PatientsController(IPatientService patientService)
    {
        _patientService = patientService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetPatient(int id)
    {
        var patient = await _patientService.GetPatientAsync(id);
        if (patient == null)
        {
            return NotFound();
        }

        return Ok(patient);
    }
}