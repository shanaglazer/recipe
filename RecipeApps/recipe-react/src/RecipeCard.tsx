import { IRecipe } from "./DataInterfaces";

interface Props {
  recipe: IRecipe;
}

export default function RecipeCard({ recipe }: Props) {
  const formattedDate = new Date(recipe.dateCreated).toLocaleDateString(
    "he-IL",
    {
      year: "numeric",
      month: "numeric",
      day: "numeric",
    }
  );
  return (
    <>
      <div className="card m-1">
        <img
          src={`/img/recipe-images/${recipe.recipeName.toLowerCase()}.jpeg`}
          className="card-img-top"
          alt="Recipe Image"
        />
        <div className="card-body">
          <h2 className="text-secondary">{recipe.recipeName}</h2>
          <h6 className="text-primary">Created By: {recipe.userName}</h6>
          <p className="card-text">
            The recipe for {recipe.recipeName} was created on {formattedDate}.
            The recipe consists of {recipe.numIngredient} ingredients and
            contains {recipe.calories} calories.
            <br />
            <span className="text-danger">
              Recipe status: {recipe.recipeStatus}
            </span>
          </p>
        </div>
        <div>
          <button className="btn btn-outline-primary">Edit</button>
        </div>
      </div>
    </>
  );
}
