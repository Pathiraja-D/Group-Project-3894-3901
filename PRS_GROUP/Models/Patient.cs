using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS_GROUP.Models
{
    public class Patient
    {
        [Key]
        public string? PNIC { get; set; }
        public string? PatientFirstName { get; set; }
        public string? PatientLastName { get; set; }
        public string? Address { get; set; }
        public string? T_Number { get; set; }
        public string? Date { get; set; }
        public double MedicineFee { get; set; }
        public double HospitalFee { get; set; }
        public double DoctorFee { get; set; }
        public double Discount { get; set; }
        public double TotalFee { get; set; }

        public double tamount()
        {
            TotalFee = (MedicineFee + HospitalFee + DoctorFee) - (((MedicineFee + HospitalFee + DoctorFee) * Discount) / 100);
            return TotalFee;
        }

        
    }
}

