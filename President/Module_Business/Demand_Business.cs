using System.Windows.Forms;

namespace Module_Business
{
    public partial class Demand_Business : Form
    {
        public Demand_Business(string mode)
        {
            InitializeComponent();

            demandParam.StartParam(this, mode);
        }
    }
}
