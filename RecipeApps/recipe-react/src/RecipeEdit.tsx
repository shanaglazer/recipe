export default function RecipeEdit() {
  return (
    /*   to create an empty form - 
    recipeId: '',
    userId: '',
    cuisineId: '',
    recipeName: '',
    calories: '',
    dateCreated: '',
    datePublished: '',
    dateArchived: '',
    recipeStatus: '',
    vegan: false, */

    <>
      <div className="container">
        <form>
          <div>
            <label htmlFor="recipeId">Recipe ID:</label>
            <input type="text" id="recipeId" name="recipeId" />
          </div>

          <div>
            <label htmlFor="userId">User ID:</label>
            <input type="text" id="userId" name="userId" />
          </div>

          <div>
            <label htmlFor="cuisineId">Cuisine ID:</label>
            <input type="text" id="cuisineId" name="cuisineId" />
          </div>

          <div>
            <label htmlFor="recipeName">Recipe Name:</label>
            <input type="text" id="recipeName" name="recipeName" />
          </div>

          <div>
            <label htmlFor="calories">Calories:</label>
            <input type="number" id="calories" name="calories" />
          </div>

          <div>
            <label htmlFor="dateCreated">Date Created:</label>
            <input type="date" id="dateCreated" name="dateCreated" />
          </div>

          <div>
            <label htmlFor="datePublished">Date Published:</label>
            <input type="date" id="datePublished" name="datePublished" />
          </div>

          <div>
            <label htmlFor="dateArchived">Date Archived:</label>
            <input type="date" id="dateArchived" name="dateArchived" />
          </div>

          <div>
            <label htmlFor="recipeStatus">Recipe Status:</label>
            <input type="text" id="recipeStatus" name="recipeStatus" />
          </div>

          <div>
            <label htmlFor="vegan">Vegan:</label>
            <input type="checkbox" id="vegan" name="vegan" />
          </div>

          <button type="submit">Submit</button>
        </form>
      </div>
    </>
  );
}
