namespace Hospital.DTO.Response;

public class DoctorQueryDTO
{
    public int IdDoctor { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
}