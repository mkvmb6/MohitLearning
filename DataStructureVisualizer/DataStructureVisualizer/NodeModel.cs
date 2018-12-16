using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace DataStructureVisualizer
{
    public class NodeModel : INotifyPropertyChanged
    {
        public string MyLabelText { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public NodeModel()
        {
            ChangeLabelText();
        }

        private async void ChangeLabelText()
        {
            var i = 0;
            while (true)
            {
                await Task.Delay(100);
                MyLabelText = i++.ToString();
                OnPropertyChanged(nameof(MyLabelText));
            }
        }
    }
}