import { useEffect, useState } from "react";
import { fetchRecipe } from "./DataUtil";
import { IRecipe } from "./DataInterfaces";
import RecipeCard from "./RecipeCard";

interface Props {
  cuisineid: number;
}

export default function RecipeMainScrean({ cuisineid }: Props) {
  const [recipe, setRecipe] = useState<IRecipe[]>([]);

  useEffect(() => {
    const fetchData = async () => {
      const data = await fetchRecipe(cuisineid);
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
