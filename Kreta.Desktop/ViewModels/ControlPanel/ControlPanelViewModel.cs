using CommunityToolkit.Mvvm.ComponentModel;
using Kreta.Desktop.ViewModels.Base;
using Kreta.HttpService;
using System;
using System.Threading.Tasks;

namespace Kreta.Desktop.ViewModels.ControlPanel
{
    public partial class ControlPanelViewModel: BaseViewModel
    {
        private readonly IStudentHttpService _studentHttpService;

        public ControlPanelViewModel()
        {
            _studentHttpService = new StudentHttpService();
        }
        public ControlPanelViewModel(IStudentHttpService? studentHttpService)
        {
            _studentHttpService = studentHttpService ?? throw new ArgumentException(nameof(studentHttpService));
        }

        [ObservableProperty]
        private int _numberOfStudent;

        public async override Task InitializeAsync()
        {
            await UpdateAsync();
            await base.InitializeAsync();
        }

        private async Task UpdateAsync()
        {
            NumberOfStudent = await _studentHttpService.GetNumberOfStudentAsync();
        }
    }
}
