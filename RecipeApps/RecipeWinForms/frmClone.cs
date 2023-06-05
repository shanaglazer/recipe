using CPUWindowsFormFramework;
using RecipeSystem;

namespace RecipeWinForms
{
    public partial class frmClone : Form
    {
        public frmClone()
        {
            InitializeComponent();
            this.Activated += FrmClone_Activated;
            btnClone.Click += BtnClone_Click;
        }

        private void BtnClone_Click(object? sender, EventArgs e)
        {
            //proc clone
            //this.close
            //openform recipe by pk
        }

        private void FrmClone_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            //eih lsader amuda mesuyemet sheyaale bacombobox?
            WindowsFormUtility.SetListBinding(lstRecipe, DataMaintenance.GetDataList("Recipe", true), null, "Recipe");
        }
    }
}
