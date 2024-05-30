namespace Hospital.DTO.Response;

public class PrescriptionQueryDTO
{
    public int IdPrescription { get; set; }
    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }
    public List<MedicamentQueryDTO> Medicaments { get; set; } = new List<MedicamentQueryDTO>();
    public DoctorQueryDTO Doctor { get; set; } = null!;

}