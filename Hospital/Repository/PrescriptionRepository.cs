﻿using Hospital.Model;
using Microsoft.EntityFrameworkCore;

public class PrescriptionRepository(MyContext context) : IPrescriptionRepository
{
    public Task<int> AddPrescriptionAsync(Prescription prescription)
    {
        return Task.FromResult(1);
    }

    public async Task<IEnumerable<Prescription>> GetPrescriptionsByPatientsIdAsync(int patientId)
    {
        return await context.Prescriptions.Where(p => p.IdPatient == patientId)
            .Include(p => p.PrescriptionMedicaments)
            .ThenInclude(pm => pm.IdMedicamentNav)
            .ToListAsync();
    }
}