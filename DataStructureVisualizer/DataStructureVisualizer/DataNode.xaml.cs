using System.Windows.Controls;

namespace DataStructureVisualizer
{
    /// <summary>
    /// Interaction logic for DataNode.xaml
    /// </summary>
    public partial class DataNode : UserControl
    {
        public string LabelText
        {
            get
            {
                return LabelData.Text;
            }
            set
            {
                LabelData.Text = value;
            }
        }
        public DataNode()
        {
            InitializeComponent();
            DataContext = new NodeModel();
        }
    }
}
