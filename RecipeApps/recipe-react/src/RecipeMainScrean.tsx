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
      <div className="container">
        <div className="row d-flex">
          {recipe.map((r) => (
            <div className="col-xl-4 col-md-6 col-sm-12 d-flex align-items-stretch">
              <RecipeCard key={r.recipeId} recipe={r} />
            </div>
          ))}
        </div>
      </div>
    </>
  );
}
