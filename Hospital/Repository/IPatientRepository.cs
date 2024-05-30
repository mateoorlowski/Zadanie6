using Hospital.Model;

public interface IPatientRepository
{
    public Task<Patient> GetPatientAsync(int id);
}