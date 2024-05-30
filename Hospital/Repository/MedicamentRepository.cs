using Hospital.Model;

public class MedicamentRepository(MyContext context) : IMedicamentRepository
{
    public async Task<Medicament> GetMedicamentAsync(int id)
    {
        return (await context.Medicaments.FindAsync(id))!;
    }
}