using System.Data;
using CPUFramework;
using RecipeSystem;

namespace RecipeTest
{
    public class RecipeTest
    {
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString("server=.\\SQLExpress;Database=HeartyHearthDB;Trusted_Connection=true");
        }

        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, Can't run test");
            TestContext.WriteLine("Existing recipe with id " + recipeid);
            TestContext.WriteLine("Ensure that app loads recipe " + recipeid);

            DataTable dt = Recipe.LoadRecipe(recipeid);
            int loadedid = (int)dt.Rows[0]["recipeid"];
            Assert.IsTrue(loadedid == recipeid, loadedid + " <> " + recipeid);
            TestContext.WriteLine("Loaded recipe (" + loadedid + ")");
        }

        //[Test]
        //[TestCase("white bread", 99)]
        //[TestCase("Veg soup", 87)]
        //public void InsertNewRecipe(string recipename, int calories)
        //{
        //    DataTable dt = SQLUtility.GetDataTable("select * from recipe where recipeid = 0");
        //    DataRow r = dt.Rows.Add();
        //    Assume.That(dt.Rows.Count == 1);
        //    int usersid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 usersid from users");
        //    Assume.That(usersid > 0, "Can't run test, No users in DB");
        //    int cuisineid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 cuisineid from cuisine");
        //    Assume.That(cuisineid > 0, "Can't run test, No cuisines in DB");
        //    DateTime datetime = DateTime.Now;
        //    string newrecipename = recipename + " " + datetime.ToString("dd/MM/yyyy HH:mm:ss");
        //    TestContext.WriteLine("insert recipe with name = " + newrecipename);

        //    r["RecipeName"] = newrecipename;
        //    r["Calories"] = calories;
        //    r["usersid"] = usersid;
        //    r["cuisineid"] = cuisineid;
        //    r["DateCreated"] = datetime;
        //    Recipe.Save(dt);

        //    int newid = SQLUtility.GetFirstColumnFirstRowValue("select * from recipe where recipename = " + newrecipename);

        //    Assert.IsTrue(newid > 0, "Recipe with name = " + newrecipename + "is not found in DB");
        //    TestContext.WriteLine("Recipe Name " + newrecipename + "is found in db with pk value = " + newid);
        //}

        [Test]
        public void ChangeExistingRecipeName()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, Can't run test");
            DataTable dt = SQLUtility.GetDataTable("select recipename from recipe where recipeid = " + recipeid);
            string recipename = (string)dt.Rows[0]["recipename"];
            TestContext.WriteLine("recipe name for recipeid " + recipeid + "is " + recipename);
            //termstart = termstart + 1;
            //TestContext.WriteLine("Change termstart to " + termstart);
            //DataTable dt = President.Load(presidentid);
            //dt.Rows[0]["termstart"] = termstart;
            //President.Save(dt);
            //int newtermstart = SQLUtility.GetFirstColumnFirstRowValue("select termstart from president where presidentid = " + presidentid);
            //Assert.IsTrue(newtermstart == termstart, "term start for president (" + presidentid + ") = " + termstart);
            //TestContext.WriteLine("term start for president (" + presidentid + ") = " + newtermstart);
        }

        private int GetExistingRecipeId()
        {
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
        }
    }
}