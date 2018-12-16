using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ViewModelConcept.Commands;

namespace ViewModelConcept
{
    internal class MyButtonViewModel : INotifyPropertyChanged

    {
        private string myVmContent = "Mohit";

        public string VmContent
        {
            get { return myVmContent; }
            set
            {
                myVmContent = value;
                OnPropertyChanged();
            }
        }

        public int ButtonWidth { get; set; } = 250;
        public int ButtonHeight { get; set; } = 200;
        public BaseCommand ChangeWidthHeightCommand {get;}

        public MyButtonViewModel()
        {
            ChangeButtonText();
            ChangeWidthHeightCommand = new BaseCommand(ChangeWidthHeight);
        }

        private async void ChangeButtonText()
        {
            var i = 0;
            while (i < 1000)
            {
                await Task.Delay(200);
                VmContent = i++.ToString();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ChangeWidthHeight()
        {
            ButtonWidth -= 10;
            ButtonHeight -= 10;
            OnPropertyChanged(nameof(ButtonWidth));
            OnPropertyChanged(nameof(ButtonHeight));

        }

    }
}
