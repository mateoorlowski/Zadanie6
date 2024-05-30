using Hospital.DTO.Request;
using Hospital.DTO.Response;
using Hospital.Model;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Service;

public class PrescriptionService : IPrescriptionService
{
    private readonly MyContext _context;
    private readonly IPrescriptionRepository _prescriptionRepository;

    public PrescriptionService(MyContext context, IPrescriptionRepository prescriptionRepository)
    {
        _context = context;
        _prescriptionRepository = prescriptionRepository;
    }
    
    public async Task<PrescriptionQueryDTO> AddPrescriptionAsync(PrescriptionCreateDTO prescriptionCreateDTO)
    {
        if (prescriptionCreateDTO.Medicaments.Count() > 10)
                throw new Exception("Prescription cannot contain more than 10 medicaments.");

        if (prescriptionCreateDTO.DueDate < prescriptionCreateDTO.Date)
        {
            throw new Exception("DueDate must be on or after the Date.");
        }

        var patient = await _context.Patients.FirstOrDefaultAsync(p => p.IdPatient == prescriptionCreateDTO.Patient.IdPatient);
            if (patient == null)
            {
                patient = new Patient
                {
                    IdPatient = prescriptionCreateDTO.Patient.IdPatient,
                    FirstName = prescriptionCreateDTO.Patient.FirstName,
                    LastName = prescriptionCreateDTO.Patient.LastName,
                    BirthDate = prescriptionCreateDTO.Patient.BirthDate
                };
                _context.Patients.Add(patient);
                await _context.SaveChangesAsync();
            }

            foreach (var medicament in prescriptionCreateDTO.Medicaments)
            {
                if (!await _context.Medicaments.AnyAsync(m => m.IdMedicament == medicament.IdMedicament))
                    throw new Exception($"Medicament with ID {medicament.IdMedicament} does not exist.");
            }

            var prescription = new Prescription
            {
                Date = prescriptionCreateDTO.Date,
                DueDate = prescriptionCreateDTO.DueDate,
                IdPatient = patient.IdPatient,
                IdDoctor = 1 // Assuming the doctor ID is provided or retrieved appropriately
            };

            _context.Prescriptions.Add(prescription);
            await _context.SaveChangesAsync();

            foreach (var medicament in prescriptionCreateDTO.Medicaments)
            {
                var prescriptionMedicament = new PrescriptionMedicament
                {
                    IdMedicament = medicament.IdMedicament,
                    IdPrescription = prescription.IdPrescription,
                    Dose = medicament.Dose,
                    Details = medicament.Description
                };
                _context.PrescriptionMedicaments.Add(prescriptionMedicament);
            }
            await _context.SaveChangesAsync();

            return new PrescriptionQueryDTO
            {
                IdPrescription = prescription.IdPrescription,
                Date = prescription.Date,
                DueDate = prescription.DueDate,
                Medicaments = prescriptionCreateDTO.Medicaments.Select(m => new MedicamentQueryDTO
                {
                    IdMedicament = m.IdMedicament,
                    Name = _context.Medicaments.First(md => md.IdMedicament == m.IdMedicament).Name,
                    Dose = m.Dose,
                    Description = m.Description
                }).ToList(),
                Doctor = new DoctorQueryDTO
                {
                    IdDoctor = 1, // Assuming the doctor ID is provided or retrieved appropriately
                    FirstName = "DoctorFirstName", // Retrieve this appropriately
                    LastName = "DoctorLastName", // Retrieve this appropriately
                }
            };
    }
}