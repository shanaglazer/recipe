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
        <div className="row">
          <div className="col-12">
            <h2 id="hmsg"></h2>
          </div>
        </div>
        <div className="row">
          <div className="col-12">
            <form id="frm" action="" method="post" className="needs-validation">
              <div className="mb-3">
                <label htmlFor="recipeId" className="form-label">
                  Recipe ID:
                </label>
                <input type="text" id="recipeId" name="recipeId" />
              </div>

              <div className="mb-3">
                <label htmlFor="userId" className="form-label">
                  User ID:
                </label>
                <input type="text" id="userId" name="userId" />
              </div>

              <div className="mb-3">
                <label htmlFor="cuisineId" className="form-label">
                  Cuisine ID:
                </label>
                <input type="text" id="cuisineId" name="cuisineId" />
              </div>

              <div className="mb-3">
                <label htmlFor="recipeName" className="form-label">
                  Recipe Name:
                </label>
                <input type="text" id="recipeName" name="recipeName" />
              </div>

              <div className="mb-3">
                <label htmlFor="calories" className="form-label">
                  Calories:
                </label>
                <input type="number" id="calories" name="calories" />
              </div>

              <div className="mb-3">
                <label htmlFor="dateCreated" className="form-label">
                  Date Created:
                </label>
                <input type="date" id="dateCreated" name="dateCreated" />
              </div>

              <div className="mb-3">
                <label htmlFor="datePublished" className="form-label">
                  Date Published:
                </label>
                <input type="date" id="datePublished" name="datePublished" />
              </div>

              <div className="mb-3">
                <label htmlFor="dateArchived" className="form-label">
                  Date Archived:
                </label>
                <input type="date" id="dateArchived" name="dateArchived" />
              </div>

              <div className="mb-3">
                <label htmlFor="recipeStatus" className="form-label">
                  Recipe Status:
                </label>
                <input type="text" id="recipeStatus" name="recipeStatus" />
              </div>

              <div className="mb-3">
                <label htmlFor="vegan" className="form-label">
                  Vegan:
                </label>
                <input type="checkbox" id="vegan" name="vegan" />
              </div>

              <button type="submit">Submit</button>
            </form>
          </div>
        </div>
      </div>
    </>
  );
}
