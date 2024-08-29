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
  }, [recipe]);

  return (
    <>
      {/* <div class="progress">
  <div class="progress-bar progress-bar-striped progress-bar-animated" role="progressbar" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100" style="width: 75%;"></div>
</div> */}
      <div className="row bg-light">
        {recipe.map((r) => (
          <div className="col-4">
            <RecipeCard key={r.recipeId} recipe={r} />
          </div>
        ))}
      </div>
    </>
  );
}
