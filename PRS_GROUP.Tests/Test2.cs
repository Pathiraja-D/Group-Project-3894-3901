using FluentAssertions;
using PRS_GROUP.Models;
using PRS_GROUP.ViewModels;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PRS_GROUP.Tests
{
    public class Test2
    {

        [Fact]
        public void Pcreate_ShouldAddNewPatientToDatabase()
        {
            
            var patientMenuVM = new PatientMenuVM();
            patientMenuVM.PNICs = "1234567890";
            patientMenuVM.PFNames = "John";
            patientMenuVM.PLNames = "Doe";
            patientMenuVM.PAdd = "123 Main St";
            patientMenuVM.PNo = "555-1234";
            patientMenuVM.PDate = "2023-07-16";

            
            patientMenuVM.Pcreate();

            
            patientMenuVM.DatabasePatients.Should().NotBeNull();
            patientMenuVM.DatabasePatients.Should().ContainSingle();
            var patient = patientMenuVM.DatabasePatients[0];
            patient.PNIC.Should().Be("1234567890");
            patient.PatientFirstName.Should().Be("John");
            patient.PatientLastName.Should().Be("Doe");
            patient.Address.Should().Be("123 Main St");
            patient.T_Number.Should().Be("555-1234");
            patient.Date.Should().Be("2023-07-16");
        }

        [Fact]
        public void PUpdate_ShouldUpdateExistingPatientInDatabase()
        {
            
            var patientMenuVM = new PatientMenuVM();
            var existingPatient = new Patient
            {
                PNIC = "1234567890",
                PatientFirstName = "Jane",
                PatientLastName = "Smith",
                Address = "456 Elm St",
                T_Number = "555-5678",
                Date = "2023-07-18"
            };
            patientMenuVM.context.Patients.Add(existingPatient);
            patientMenuVM.context.SaveChanges();

            patientMenuVM.PfindNICs = "1234567890";
            patientMenuVM.pFNames = "John";
            patientMenuVM.pLNames = "Doe";
            patientMenuVM.pAdd = "123 Main St";
            patientMenuVM.pNo = "555-1234";
            patientMenuVM.pDate = "2023-07-16";

            
            patientMenuVM.PUpdate();

            
            var updatedPatient = patientMenuVM.context.Patients.Find("1234567890");
            updatedPatient.Should().NotBeNull();
            updatedPatient.PatientFirstName.Should().Be("John");
            updatedPatient.PatientLastName.Should().Be("Doe");
            updatedPatient.Address.Should().Be("123 Main St");
            updatedPatient.T_Number.Should().Be("555-1234");
            updatedPatient.Date.Should().Be("2023-07-16");
        }

        [Fact]
        public void PDelete_ShouldRemoveExistingPatientFromDatabase()
        {
            
            var patientMenuVM = new PatientMenuVM();
            var existingPatient = new Patient { PNIC = "1234567890" };
            patientMenuVM.context.Patients.Add(existingPatient);
            patientMenuVM.context.SaveChanges();

            patientMenuVM.PfindNICs = "1234567890";

            
            patientMenuVM.PDelete();

            
            var deletedPatient = patientMenuVM.context.Patients.Find("1234567890");
            deletedPatient.Should().BeNull();
        }
    }

}

