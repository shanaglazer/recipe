using CPUWindowsFormFramework;
using RecipeSystem;
using System.Xml.Linq;

namespace RecipeWinForms
{
    public partial class frmMeal : Form
    {
        public frmMeal()
        {
            InitializeComponent();
            this.Activated += FrmMeal_Activated;
        }

        private void FrmMeal_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            gMeal.DataSource = MealSummary.GetMealSummary();
            WindowsFormUtility.FormatGrid(gMeal, "Meal");
        }

    }
}
