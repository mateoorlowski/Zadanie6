﻿namespace Hospital.DTO.Response;

public class PatientQueryDTO
{
    public int IdPatient { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateTime BirthDate { get; set; }
    
    public virtual ICollection<PrescriptionQueryDTO> Prescriptions { get; set; } = new List<PrescriptionQueryDTO>();
}