using QTDrugPrescription.Logic.Entities.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QTDrugPrescription.WpfApp.ViewModels
{
    public class PatientAddViewModel : BaseViewModel
    {
        public DateTime Birthday { get; set; } = DateTime.Today;
        public string SocialSecurityNumber { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;

        private ICommand? addCommand;

        public ICommand AddCommand
        {
            get
            {
                return RelayCommand.CreateCommand(ref addCommand, p => { Add(); } , p => true);
            }
        }

        private void Add()
        {
            var model = new Patient()
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                Birthday = this.Birthday,
                SocialSecurityNumber = this.SocialSecurityNumber
            };
            Task.Run(async () =>
            {
                try
                {
                    using ( var patientsController = new Logic.Controllers.App.PatientsController() )
                    {
                        await patientsController.InsertAsync(model);
                        await patientsController.SaveChangesAsync();
                        FirstName = String.Empty;
                        LastName = String.Empty;
                        SocialSecurityNumber = String.Empty;
                        Birthday = default(DateTime);
                        OnPropertyChanged(nameof(FirstName));
                        OnPropertyChanged(nameof(LastName));
                        OnPropertyChanged(nameof(Birthday));
                        OnPropertyChanged(nameof(SocialSecurityNumber));
                    }
                }
                catch (Exception ex)
                {
                    string caption = "Patients";
                    string messageBoxText = ex.Message;

                    MessageBoxButton button = MessageBoxButton.OK;
                    MessageBoxImage icon = MessageBoxImage.Stop;

                    MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
                }
            }).Wait();
        }
    }
}
