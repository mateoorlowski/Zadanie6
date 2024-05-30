using Hospital.Model;

public interface IMedicamentRepository
{
    public Task<Medicament> GetMedicamentAsync(int id);
}