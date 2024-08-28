import { useEffect, useState } from "react";
import { fetchRecipe } from "./DataUtil";
import { IRecipe } from "./DataInterfaces";
import RecipeCard from "./RecipeCard";

export default function RecipeMainScrean() {
  const [recipe, setRecipe] = useState<IRecipe[]>([]);

  useEffect(() => {
    const fetchData = async () => {
      const data = await fetchRecipe(6);
      setRecipe(data);
    };
    fetchData();
  }, []);

  return (
    <>
      <div className="row">
        {recipe.map((r) => (
          <RecipeCard key={r.recipeId} recipe={r} />
        ))}
      </div>
    </>
  );
}
