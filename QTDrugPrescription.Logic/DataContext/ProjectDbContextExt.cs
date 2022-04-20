using QTDrugPrescription.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QTDrugPrescription.Logic.Entities.App;

namespace QTDrugPrescription.Logic.DataContext
{
    partial class ProjectDbContext
    {
        public DbSet<Patient> PatientSet { get; set; }
        public DbSet<Drug> DrugSet { get; set; }
        public DbSet<Patient> PrescriptionSet { get; set; }

        partial void GetDbSet<E>(ref DbSet<E>? dbSet, ref bool handled) where E : IdentityEntity
        {
            if(typeof(E) == typeof(Drug))
            {
                dbSet = DrugSet as DbSet<E>;
            }
            else if(typeof(E) == typeof(Patient))
            {
                dbSet = PatientSet as DbSet<E>;
            }
            else if(typeof(E) == typeof(Prescription))
            {
                dbSet = PrescriptionSet as DbSet<E>;
            }
            else
            {
                handled = false;
            }
        }
    }
}
