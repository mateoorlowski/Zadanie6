using Hospital.Model;

public class DoctorRepository(MyContext context) : IDoctorRepository
{
    public async Task<Doctor> GetDoctorAsync(int id)
    {
        return (await context.Doctors.FindAsync(id))!;
    }
}