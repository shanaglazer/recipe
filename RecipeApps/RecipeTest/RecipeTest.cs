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
            DBManager.SetConnectionString("server=.\\SQLExpress;Database=HeartyHearthDB;Trusted_Connection=true", false);
        }

        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, Can't run test");
            TestContext.WriteLine("Existing recipe with id " + recipeid);
            TestContext.WriteLine("Ensure that app loads recipe " + recipeid);

            bizRecipe recipe = new();
            recipe.Load(recipeid);
            int loadedid = recipe.RecipeId;
            string recipename = recipe.RecipeName;
            Assert.IsTrue(loadedid == recipeid, loadedid + " <> " + recipeid);
            TestContext.WriteLine("Loaded recipe (" + loadedid + ") " + recipename);
        }

        [Test]
        [TestCase("white bread", 99)]
        [TestCase("Veg soup", 87)]
        public void InsertNewRecipe(string recipename, int calories)
        {
            int usersid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 usersid from users");
            Assume.That(usersid > 0, "Can't run test, No users in DB");
            int cuisineid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 cuisineid from cuisine");
            Assume.That(cuisineid > 0, "Can't run test, No cuisines in DB");
            DateTime datetime = DateTime.Now;
            string newrecipename = recipename + " " + datetime.ToString("dd/MM/yyyy HH:mm:ss");
            TestContext.WriteLine("insert recipe with name = " + newrecipename);
            bizRecipe recipe = new();

            recipe.UsersId = usersid;
            recipe.CuisineId = cuisineid;
            recipe.RecipeName = newrecipename;
            recipe.Calories = calories;
            recipe.DateCreated = datetime;

            recipe.Save();

            int newid = recipe.RecipeId;

            Assert.IsTrue(newid > 0, "Recipe with name = " + newrecipename + "is not found in DB");
            TestContext.WriteLine("Recipe Name " + newrecipename + "is found in db with pk value = " + newid);
        }

        [Test]
        public void ChangeExistingRecipeName()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, Can't run test");
            DataTable dt = SQLUtility.GetDataTable("select recipename from recipe where recipeid = " + recipeid);
            string recipename = (string)dt.Rows[0]["recipename"];
            TestContext.WriteLine("recipe name for recipeid " + recipeid + " is " + recipename);
            recipename = "New " + recipename;
            TestContext.WriteLine("Change recipename to " + recipename);
            DataTable dtnew = Recipe.LoadRecipe(recipeid);
            dtnew.Rows[0]["recipename"] = recipename;

            bizRecipe recipe = new();
            recipe.Save(dtnew);
            string newrecipename = dtnew.Rows[0]["recipename"].ToString(); //SQLUtility.GetFirstColumnFirstRowValue("select recipename from recipe where recipeid = " + recipeid);
            Assert.IsTrue(newrecipename == recipename, "recipename for recipe (" + recipeid + ") = " + recipename);
            TestContext.WriteLine("Recipe name for recipe (" + recipeid + ") = " + newrecipename);
        }

        [Test]
        public void ChangeCalories()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, Can't run test");
            int calories = SQLUtility.GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("Calories in recipe recipeid " + recipeid + " is " + calories);
            calories = calories + 1;
            TestContext.WriteLine("Change calories to " + calories);
            DataTable dt = Recipe.LoadRecipe(recipeid);
            dt.Rows[0]["calories"] = calories;
            Recipe.Save(dt);
            int newcalories = SQLUtility.GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            Assert.IsTrue(newcalories == calories, "calories in recipe (" + recipeid + ") = " + calories);
            TestContext.WriteLine("calories in recipe (" + recipeid + ") = " + newcalories);
        }

        //[Test]
        //public void ChangeExistingUser()
        //{
        //    int recipeid = GetExistingRecipeId();
        //    Assume.That(recipeid > 0, "No recipes in DB, Can't run test");
        //    DataTable dt = SQLUtility.GetDataTable("select u.username from Recipe r join Users u on r.UsersID = u.UsersID where r.RecipeID = " + recipeid);
        //    string username = (string)dt.Rows[0]["username"];
        //    TestContext.WriteLine("user name for recipeid " + recipeid + " is " + username);
        //    DataTable dtnew = SQLUtility.GetDataTable("select top 1 username from users where username <> '" + username + "'");
        //    username = dtnew.Rows[0]["username"].ToString();
        //    TestContext.WriteLine("Change username to " + username);
        //    DataTable dtupdate = Recipe.LoadRecipe(recipeid);
        //    dtupdate.Rows[0]["username"] = username;
        //    Recipe.Save(dtupdate);
        //    string newuser = dtupdate.Rows[0]["username"].ToString();
        //    Assert.IsTrue(newuser == username, "user for recipe (" + recipeid + ") = " + username);
        //    TestContext.WriteLine("user name for recipe (" + recipeid + ") = " + newuser);
        //}

        //[Test]
        //public void ChangeExistingCuisine()
        //{
        //    int recipeid = GetExistingRecipeId();
        //    Assume.That(recipeid > 0, "No recipes in DB, Can't run test");
        //    DataTable dt = SQLUtility.GetDataTable("select c.cuisinetype from Recipe r join cuisine c on r.cuisineID = c.cuisineID where r.RecipeID = " + recipeid);
        //    string cuisinetype = (string)dt.Rows[0]["cuisinetype"];
        //    TestContext.WriteLine("cuisine type for recipeid " + recipeid + " is " + cuisinetype);
        //    DataTable dtnew = SQLUtility.GetDataTable("select top 1 cuisinetype from cuisine where cuisinetype <> '" + cuisinetype + "'");
        //    cuisinetype = dtnew.Rows[0]["cuisinetype"].ToString();
        //    TestContext.WriteLine("Change cuisinetype to " + cuisinetype);
        //    DataTable dtupdate = Recipe.LoadRecipe(recipeid);
        //    dtupdate.Rows[0]["cuisinetype"] = cuisinetype;
        //    Recipe.Save(dtupdate);
        //    string newcuisine = dtupdate.Rows[0]["cuisinetype"].ToString();
        //    Assert.IsTrue(newcuisine == cuisinetype, "cuisine for recipe (" + recipeid + ") = " + cuisinetype);
        //    TestContext.WriteLine("cuisine type for recipe (" + recipeid + ") = " + newcuisine);
        //}

        [Test]
        public void ChangeDateCreated()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, Can't run test");
            DataTable dtcreated = SQLUtility.GetDataTable("select datecreated from recipe where recipeid = " + recipeid);
            DateTime datecreated = (DateTime)dtcreated.Rows[0]["datecreated"];
            TestContext.WriteLine("Datecreated for recipe recipeid " + recipeid + " is " + datecreated);
            datecreated = datecreated.AddDays(1);
            TestContext.WriteLine("Change datecreated to " + datecreated);
            DataTable dt = Recipe.LoadRecipe(recipeid);
            dt.Rows[0]["datecreated"] = datecreated;
            Recipe.Save(dt);
            DataTable dtnew = SQLUtility.GetDataTable("select datecreated from recipe where recipeid = " + recipeid);
            DateTime newdatecreated = (DateTime)dtnew.Rows[0]["datecreated"];
            Assert.IsTrue(newdatecreated == datecreated, "datecreated for recipe (" + recipeid + ") = " + datecreated);
            TestContext.WriteLine("datecreated for recipe (" + recipeid + ") = " + newdatecreated);
        }

        [Test]
        public static void DeleteRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 * from recipe r left join IngredientRecipe i on i.recipeid = r.recipeid where i.amount is null");
            int recipeid = 0;
            string recipename = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipename = dt.Rows[0]["recipename"].ToString();
            }
            Assume.That(recipeid > 0, "No recipes in DB, Can't run test");
            TestContext.WriteLine("Chosen recipe id " + recipeid + " " + recipename);
            TestContext.WriteLine("Ensure that app can delete " + recipeid);

            bizRecipe recipe = new();
            recipe.Load(recipeid);
            recipe.Delete();
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + "exists in DB");
            TestContext.WriteLine("Record with recipeid " + recipeid + " does not exist in DB");
        }

        [Test]
        public static void DeleteRecipeById()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 * from recipe r left join IngredientRecipe i on i.recipeid = r.recipeid where i.amount is null");
            int recipeid = 0;
            string recipename = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipename = dt.Rows[0]["recipename"].ToString();
            }
            Assume.That(recipeid > 0, "No recipes in DB, Can't run test");
            TestContext.WriteLine("Chosen recipe id " + recipeid + " " + recipename);
            TestContext.WriteLine("Ensure that app can delete " + recipeid);

            bizRecipe recipe = new();
            recipe.Delete(recipeid);
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + "exists in DB");
            TestContext.WriteLine("Record with recipeid " + recipeid + " does not exist in DB");
        }

        [Test]
        public static void DeleteRecipeBasedOnDT()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 * from recipe r left join IngredientRecipe i on i.recipeid = r.recipeid where i.amount is null");
            int recipeid = 0;
            string recipename = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipename = dt.Rows[0]["recipename"].ToString();
            }
            Assume.That(recipeid > 0, "No recipes in DB, Can't run test");
            TestContext.WriteLine("Chosen recipe id " + recipeid + " " + recipename);
            TestContext.WriteLine("Ensure that app can delete " + recipeid);

            bizRecipe recipe = new();
            recipe.Delete(dt);
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + "exists in DB");
            TestContext.WriteLine("Record with recipeid " + recipeid + " does not exist in DB");
        }

        //[Test]
        //public void GetListOfUsers()
        //{
        //    int usercount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from users");
        //    Assume.That(usercount > 0, "No users in DB, Can't test.");
        //    TestContext.WriteLine("num of users in DB is " + usercount);
        //    TestContext.WriteLine("Ensure that num of rows return by app matches " + usercount);

        //    DataTable dt = Recipe.GetUserList();

        //    Assert.IsTrue(dt.Rows.Count == usercount, "num rows returned by app " + dt.Rows.Count + " <> " + usercount);

        //    TestContext.WriteLine("Num of rows in users return by app " + dt.Rows.Count);
        //}

        //[Test]
        //public void GetListOfCuisines()
        //{
        //    int cuisinecount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from cuisine");
        //    Assume.That(cuisinecount > 0, "No cuisines in DB, Can't test.");
        //    TestContext.WriteLine("num of cuisines in DB is " + cuisinecount);
        //    TestContext.WriteLine("Ensure that num of rows return by app matches " + cuisinecount);

        //    DataTable dt = Recipe.GetCuisineList();

        //    Assert.IsTrue(dt.Rows.Count == cuisinecount, "num rows returned by app " + dt.Rows.Count + " <> " + cuisinecount);

        //    TestContext.WriteLine("Num of rows in cuisines return by app " + dt.Rows.Count);
        //}

        private int GetExistingRecipeId()
        {
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
        }

        [Test]
        public static void DeleteRecipeWithIngredient()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 r.recipeid, r.recipename from IngredientRecipe i join recipe r on r.recipeid = i.recipeid");
            int recipeid = 0;
            string recipename = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipename = dt.Rows[0]["recipename"].ToString();
            }
            Assume.That(recipeid > 0, "No recipes with ingredients in DB, Can't run test");
            TestContext.WriteLine("Existing recipe with ingredient, with id " + recipeid + " " + recipename);
            TestContext.WriteLine("Ensure that app cannot delete " + recipeid);

            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt));

            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void ChangeExistingRecipeNameToInvalid()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, Can't run test");
            DataTable dt = SQLUtility.GetDataTable("select recipename from recipe where recipeid <> " + recipeid);
            string recipename = (string)dt.Rows[0]["recipename"];
            TestContext.WriteLine("tring to change recipe name for recipeid " + recipeid + " to " + recipename+ " which exists.");
         
            DataTable dtnew = Recipe.LoadRecipe(recipeid);
            dtnew.Rows[0]["recipename"] = recipename;
            Exception ex = Assert.Throws<Exception>(()=> Recipe.Save(dtnew));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void ChangeCaloriesToInvalid()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, Can't run test");
            int calories = SQLUtility.GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("Calories in recipe recipeid " + recipeid + " is " + calories);
            calories = -5;
            TestContext.WriteLine("Change calories to " + calories);
            DataTable dt = Recipe.LoadRecipe(recipeid);
            dt.Rows[0]["calories"] = calories;
            Exception ex = Assert.Throws<Exception> (()=> Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public static void DeleteRecipeWithRecipeBook()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 r.recipeid, r.recipename from BookRecipe b join recipe r on r.recipeid = b.recipeid");
            int recipeid = 0;
            string recipename = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipename = dt.Rows[0]["recipename"].ToString();
            }
            Assume.That(recipeid > 0, "No recipes in cookbooks in DB, Can't run test");
            TestContext.WriteLine("Existing recipe in cookbook, with id " + recipeid + " " + recipename);
            TestContext.WriteLine("Ensure that app cannot delete " + recipeid);

            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt));

            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public static void DeleteDraftRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 r.recipeid, r.recipename from Recipe r where r.recipestatus = 'Draft'");
            int recipeid = 0;
            string recipename = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipename = dt.Rows[0]["recipename"].ToString();
            }
            Assume.That(recipeid > 0, "No recipes with ingredients in DB, Can't run test");
            TestContext.WriteLine("Existing draft recipe , with id " + recipeid + " " + recipename);
            TestContext.WriteLine("Ensure that app cannot delete " + recipeid);

            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt));

            TestContext.WriteLine(ex.Message);
        }

        [Test]
        [TestCase(false)]
        [TestCase(true)]
        public void GetListOfRecipes(bool includeblank)
        {
            int recipecount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from recipe");
            if (includeblank == true)
            {
                recipecount = recipecount + 1;
            }
            Assume.That(recipecount > 0, "No recipes in DB, Can't test.");
            TestContext.WriteLine("num of recipes in DB is " + recipecount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + recipecount);
            bizRecipe r = new();
            var lst = r.GetList(includeblank);

            Assert.IsTrue(lst.Count == recipecount, "num rows returned by app " + lst.Count + " <> " + recipecount);

            TestContext.WriteLine("Num of rows in recipe returned by app " + lst.Count);
        }

        [Test]
        public void SearchForRecipe()
        {
            string recipename = "e";
            int recipecount = SQLUtility.GetFirstColumnFirstRowValue($"select total = count(*) from recipe where recipename like '%{recipename}%'");
            TestContext.WriteLine("Num of search results in DB = " + recipecount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + recipecount);
            bizRecipe r = new();
            List<bizRecipe> lst = r.Search(recipename);
            Assert.IsTrue(lst.Count == recipecount, "num rows returned by search (" + lst.Count + ") <> " + recipecount);
            TestContext.WriteLine("Number of rows in search results returned by app = " + lst.Count);
        }

        [Test]
        [TestCase(false)]
        [TestCase(true)]
        public void GetListOfIngredients(bool includeblank)
        {
            int ingredientcount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from ingredient");
            if (includeblank == true)
            {
                ingredientcount = ingredientcount + 1;
            }
            Assume.That(ingredientcount > 0, "No ingredients in DB, Can't test.");
            TestContext.WriteLine("num of ingredients in DB is " + ingredientcount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + ingredientcount);
            bizIngredient i = new();
            var lst = i.GetList(includeblank);

            Assert.IsTrue(lst.Count == ingredientcount, "num rows returned by app " + lst.Count + " <> " + ingredientcount);

            TestContext.WriteLine("Num of rows in ingredient return by app " + lst.Count);
        }

        [Test]
        public void SearchIngredient()
        {
            string ingredienttype = "e";
            int ingredientcount = SQLUtility.GetFirstColumnFirstRowValue($"select total = count(*) from ingredient where ingredienttype like '%{ingredienttype}%'");
            TestContext.WriteLine("Num of search results in DB = " + ingredientcount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + ingredientcount);
            bizIngredient i = new();
            List<bizIngredient> lst = i.Search(ingredienttype);
            Assert.IsTrue(lst.Count == ingredientcount, "num rows returned by search (" + lst.Count + ") <> " + ingredientcount);
            TestContext.WriteLine("Number of rows in search results return by app = " + lst.Count);
        }
    }
}