using Hospital.DTO.Request;
using Hospital.DTO.Response;

namespace Hospital.Service;

public interface IPrescriptionService
{
    Task<PrescriptionQueryDTO> AddPrescriptionAsync(PrescriptionCreateDTO prescriptionCreateDTO);
}