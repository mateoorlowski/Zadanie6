using Hospital.DTO.Response;

namespace Hospital.Service;

public interface IPatientService
{
    public Task<PatientQueryDTO> GetPatientAsync(int id);
}