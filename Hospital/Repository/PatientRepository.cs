using Hospital.Model;

public class PatientRepository(MyContext context) : IPatientRepository
{
    public async Task<Patient> GetPatientAsync(int id)
    {
        return (await context.Patients.FindAsync(id))!;
    }
}