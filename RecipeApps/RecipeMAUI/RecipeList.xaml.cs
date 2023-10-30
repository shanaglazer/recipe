using System.Data;
using RecipeSystem;

namespace RecipeMAUI;

public partial class RecipeList : ContentPage
{
	public RecipeList()
	{
		InitializeComponent();
	}

    private void SearchRecipe()
    {
        DataTable dt = Recipe.SearchRecipe(RecipeNameTxt.Text);
        RecipeLst.ItemsSource = dt.Rows;
    }

    private void SearchBtn_Clicked(object sender, EventArgs e)
	{
        SearchRecipe();
	}
}