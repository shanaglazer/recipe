import { useEffect, useState } from "react";
import { fetchRecipe } from "./DataUtil";
import { IRecipe } from "./DataInterfaces";

export default function RecipeMainScrean() {
  const [recipe, setRecipe] = useState<IRecipe[]>([]);

  useEffect(() => {
    const fetchData = async () => {
      const data = await fetchRecipe(2);
      setRecipe(data);
    };
    fetchData();
  }, []);

  return (
    <>
      {/* add a key prop */}
      {recipe.map((r) => (
        <h2>{r.recipeName}</h2>
      ))}
    </>
  );
}
