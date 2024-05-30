using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital.Migrations
{
    /// <inheritdoc />
    public partial class addedDataToTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "SampleDoctor@gmail.com", "Sample", "Doctor" },
                    { 2, "JakubBiologist@gmail.com", "Jakub", "Biologist" },
                    { 3, "MichalPediatrician@gmail.com", "Michal", "Pediatrician" },
                    { 4, "SergioPsychiatrist@gmail.com", "Sergio", "Psychiatrist" },
                    { 5, "PabloAnesthesiologist@gmail.com", "Pablo", "Anesthesiologist" },
                    { 6, "AzucarDiabetes@gmail.com", "Azucar", "Diabetes" }
                });

            migrationBuilder.InsertData(
                table: "Medicaments",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Painkiller, 200mg 3 times a day.", "Ibuprofène", "Anti inflamatory pills" },
                    { 2, "From 10 to 1000 times a day.", "Happyness", "Anti sadness pills" },
                    { 3, "CAN HARM YOUR HEALTH.", "Sadness", "Anti happyness pills" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "IdPatient", "BirthDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1999, 5, 30, 11, 39, 47, 147, DateTimeKind.Local).AddTicks(586), "Jakub", "Nowak" },
                    { 2, new DateTime(2003, 5, 30, 11, 39, 47, 147, DateTimeKind.Local).AddTicks(641), "Michal", "Kowalski" },
                    { 3, new DateTime(1997, 5, 30, 11, 39, 47, 147, DateTimeKind.Local).AddTicks(644), "Patient", "Patientowich" },
                    { 4, new DateTime(2002, 5, 30, 11, 39, 47, 147, DateTimeKind.Local).AddTicks(647), "Sergio", "Kotowich" },
                    { 5, new DateTime(1974, 5, 30, 11, 39, 47, 147, DateTimeKind.Local).AddTicks(649), "Ala", "Peronska" },
                    { 6, new DateTime(1995, 5, 30, 11, 39, 47, 147, DateTimeKind.Local).AddTicks(652), "Kot", "Zygmund" },
                    { 7, new DateTime(1970, 5, 30, 11, 39, 47, 147, DateTimeKind.Local).AddTicks(654), "Natiel", "Patient" },
                    { 8, new DateTime(1957, 5, 30, 11, 39, 47, 147, DateTimeKind.Local).AddTicks(656), "Jas", "Profase" }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 30, 11, 39, 47, 147, DateTimeKind.Local).AddTicks(7793), new DateTime(2024, 6, 29, 11, 39, 47, 147, DateTimeKind.Local).AddTicks(7812), 1, 1 },
                    { 2, new DateTime(2024, 5, 30, 11, 39, 47, 147, DateTimeKind.Local).AddTicks(7817), new DateTime(2024, 6, 29, 11, 39, 47, 147, DateTimeKind.Local).AddTicks(7818), 2, 2 },
                    { 3, new DateTime(2024, 5, 30, 11, 39, 47, 147, DateTimeKind.Local).AddTicks(7821), new DateTime(2024, 6, 29, 11, 39, 47, 147, DateTimeKind.Local).AddTicks(7822), 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Prescription_Medicament",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[,]
                {
                    { 1, 1, "2 pills in am and pm", 200 },
                    { 2, 1, "2 pills in am and pm", 250 },
                    { 2, 2, "2 pills in am and pm", 250 },
                    { 3, 3, "2 pills in am and pm", 250 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 3);
        }
    }
}
