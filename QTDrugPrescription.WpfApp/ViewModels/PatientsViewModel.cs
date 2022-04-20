using QTDrugPrescription.Logic.Entities.App;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QTDrugPrescription.WpfApp.ViewModels
{
    public class PatientsViewModel : BaseViewModel
    {
        public ObservableCollection<Patient> Patients
        {
            get
            {
                using (var patientsController = new Logic.Controllers.App.PatientsController())
                {
                    var models = Task.Run(async () => await patientsController.GetAllAsync()).Result;
                    models = models == null ? Array.Empty<Patient>() : models;
                    return new ObservableCollection<Patient>(models);
                }

            }
        }

        private ICommand? addCommand;
        public ICommand AddCommand
        {
            get
            {
                return RelayCommand.CreateCommand(ref addCommand, p => { Add(); }, p => true);
            }
        }

        private ICommand? commandDelete;
        public ICommand CommandDelete
        {
            get
            {
                return RelayCommand.CreateCommand(ref commandDelete, p => { Delete(Convert.ToInt32(p)); }, p => true);
            }
        }

        public void Add()
        {
            var addWindow = new AddPatientWindow();
            addWindow.ShowDialog();
            OnPropertyChanged(nameof(Patients));
        }
        public void Delete(int id)
        {
            string caption = "Patients";
            string messageBoxText = "Do you really wanna delete this item?";

            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Stop;

            var result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);

            if (result == MessageBoxResult.Yes)
            {
                Task.Run(async () =>
                {
                    using (var patientsController = new Logic.Controllers.App.PatientsController())
                    {
                        await patientsController.DeleteAsync(id);
                        await patientsController.SaveChangesAsync();
                    }

                }).Wait();
                OnPropertyChanged(nameof(Patients));
            }
        }
    }
}
