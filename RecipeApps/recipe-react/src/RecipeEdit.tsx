import { useEffect, useState } from "react";
import { FieldValues, useForm } from "react-hook-form";
import { ICuisine, IRecipe, IUsers } from "./DataInterfaces";
import {
  blankrecipe,
  deleteRecipe,
  fetchCuisine,
  fetchUsers,
  postRecipe,
} from "./DataUtil";

interface Props {
  recipe: IRecipe;
}

export default function RecipeEdit({ recipe }: Props) {
  const [users, setUsers] = useState<IUsers[]>([]);
  const [cuisines, setCuisines] = useState<ICuisine[]>([]);
  const { register, handleSubmit, reset } = useForm({ defaultValues: recipe });
  const [errormsg, setErrormsg] = useState("");

  // const [loading, setLoading] = useState(true);

  useEffect(() => {
    const fetchData = async () => {
      const data = await fetchUsers();
      setUsers(data);
      // setLoading(false);
    };
    fetchData();
  }, []);

  // useEffect(() => {
  //   console.log(users); // Logs the updated users whenever users state changes
  // }, [users]);

  useEffect(() => {
    const fetchData = async () => {
      const data = await fetchCuisine();
      setCuisines(data);
    };
    fetchData();
  }, []);

  useEffect(() => {
    reset(recipe);
  }, [recipe, reset]);

  const submitForm = async (data: FieldValues) => {
    const r = await postRecipe(data);
    setErrormsg(r.errorMessage);
    reset(r);
    //console.log(data);
  };

  const handleDelete = async () => {
    const r = await deleteRecipe(recipe.recipeId);
    setErrormsg(r.errorMessage);
    if (r.errorMessage == "") {
      reset(blankrecipe);
    }
  };

  return (
    <>
      <div className="container">
        <div className="row">
          <div className="col-12">
            <h2 id="hmsg">{errormsg}</h2>
          </div>
        </div>
        <div className="row">
          <div className="col-12">
            <form
              onSubmit={handleSubmit(submitForm)}
              className="needs-validation"
            >
              <div className="mb-3">
                <label htmlFor="recipeId" className="form-label">
                  Recipe ID:
                </label>
                <input
                  type="number"
                  {...register("recipeId")}
                  className="form-control"
                  required
                />
              </div>

              <div className="mb-3">
                <label htmlFor="usersId">User:</label>
                {/* {loading ? (
                  <p>Loading...</p>
                ) : ( */}
                <select {...register("usersId")} className="form-select">
                  {users.map((u) => (
                    <option key={u.usersId} value={u.usersId}>
                      {u.userName}
                    </option>
                  ))}
                </select>
                {/* )} */}
              </div>

              <div className="mb-3">
                <label htmlFor="cuisineID">Cuisine:</label>
                <select {...register("cuisineId")} className="form-select">
                  {cuisines.map((c) => (
                    <option key={c.cuisineID} value={c.cuisineID}>
                      {c.cuisineType}
                    </option>
                  ))}
                </select>
              </div>

              <div className="mb-3">
                <label htmlFor="recipeName">Recipe Name:</label>
                <input
                  type="text"
                  {...register("recipeName")}
                  className="form-control"
                />
              </div>

              <div className="mb-3">
                <label htmlFor="calories">Calories:</label>
                <input
                  type="number"
                  {...register("calories")}
                  className="form-control"
                />
              </div>

              {/* <label htmlFor="numIngredient">Number of Ingredients:</label>
            <input type="number" id="numIngredient" name="numIngredient" value="0" /> */}

              <div className="mb-3">
                <label htmlFor="dateCreated">Date Created:</label>
                <input
                  type="datetime-local"
                  {...register("dateCreated")}
                  className="form-control"
                />
              </div>

              <div className="mb-3">
                <label htmlFor="datePublished">Date Published:</label>
                <input
                  type="datetime-local"
                  {...register("datePublished")}
                  className="form-control"
                />
              </div>

              <div className="mb-3">
                <label htmlFor="dateArchived">Date Archived:</label>
                <input
                  type="datetime-local"
                  {...register("dateArchived")}
                  className="form-control"
                />
              </div>

              <div className="mb-3">
                <label htmlFor="recipeStatus">Recipe Status:</label>
                <input
                  type="text"
                  {...register("recipeStatus")}
                  className="form-control"
                />
              </div>

              <div className="mb-3 col-1">
                <label htmlFor="vegan">Vegan:</label>
                <input
                  type="checkbox"
                  {...register("vegan")}
                  className="form-control"
                  defaultChecked={true}
                />
              </div>

              <div className="mb-3">
                <input
                  type="hidden"
                  {...register("errorMessage")}
                  value="a"
                  className="form-control"
                ></input>
              </div>

              <button type="submit" id="btnsubmit" className="btn btn-info">
                Submit
              </button>
              <button
                onClick={handleDelete}
                type="button"
                id="btndelete"
                className="btn btn-warning"
              >
                Delete
              </button>
            </form>
          </div>
        </div>
      </div>
    </>
  );
}
