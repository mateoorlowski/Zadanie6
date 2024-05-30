using Hospital.Model;

public interface IDoctorRepository
{
    public Task<Doctor> GetDoctorAsync(int id);
}