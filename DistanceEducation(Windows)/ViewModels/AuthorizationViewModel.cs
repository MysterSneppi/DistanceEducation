using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceEducation_Windows_.ViewModels
{
    internal class AuthorizationViewModel : BaseViewModel
    {  
        public RelayCommand SendData { get; set; }

        private List<InstitutionsModel> _listInstitutions;

        public List<InstitutionsModel> ListInstitutions 
        {
            get { return _listInstitutions; }
            set { _listInstitutions = value; OnPropertyChanged(); }
        }

        private InstitutionsModel _currenntSelection;
        public InstitutionsModel CurrenntSelection { get { return _currenntSelection;} set { _currenntSelection = value; OnPropertyChanged(); } }

        private string _login;
        public string Login { get { return _login; } set { _login = value; OnPropertyChanged(); } }

        private string _password { get;set; }
        public string Password { get { return _password; } set { _password = value; OnPropertyChanged(); } }
        
        public  AuthorizationViewModel() 
        {
            try
            {
                list();
                SendData = new RelayCommand(async o =>
                {
                    if (Login is not null && Password is not null && CurrenntSelection is not null)
                    {
                        AuthorizationModel model = new AuthorizationModel(Login, Password, Convert.ToString(CurrenntSelection.Name));
                        GetAutorizationModel response = await SendAuthorizationData.SendData(model);

                        MessageBox.Show("LOG : " + Login
                            + "\nPass : " + Password
                            + "\nInstitutions : " + CurrenntSelection.Name
                            + "\nRole : " + response.Role
                            + "\nID : " + response.Id);

                        if (response.Role == 2)
                        {
                            Window window = new MainWindow();
                            window.Show();
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Не все данны заполнены пожалуйста введите их ");
                        return;
                    }
                });
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        public async void list() 
        {
            try
            {
                var list = await GetData.GetListInstitution();
                ListInstitutions = list.ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
               
        }

    }
}
