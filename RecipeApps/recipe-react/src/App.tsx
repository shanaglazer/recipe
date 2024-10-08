// import Navbar from "./Navbar";
// import CuisineSidebar from "./CuisineSidebar";
// import RecipeMainScrean from "./RecipeMainScrean";
// import { useState } from "react";
// import RecipeEdit from "./RecipeEdit";
// import { IRecipe } from "./DataInterfaces";
// import { blankrecipe } from "./DataUtil";

import { Outlet } from "react-router-dom";
import Navbar from "./Navbar";

function App() {
  // const [selectedCuisineId, setSelectedCuisineId] = useState(0);
  // const [isRecipeEdit, setIsRecipeEdit] = useState(false);

  // const [recipeForEdit, setRecipeForEdit] = useState(blankrecipe);

  // const handleSelectedCuisin = (cuisineid: number) => {
  //   setSelectedCuisineId(cuisineid);
  //   setIsRecipeEdit(false);
  // };

  // const handleRecipeSelectedForEdit = (recipe: IRecipe) => {
  //   setRecipeForEdit(recipe);
  //   setIsRecipeEdit(true);
  // };

  return (
    <>
      <Navbar />
      <Outlet />
    </>
    // <>
    //   <div className="container-fluid">
    //     <div className="row">
    //       <Navbar />
    //     </div>
    //     <div className="row">
    //       <div className="col-md-2 col-3 border border-dark">
    //         <CuisineSidebar onCuisineSelected={handleSelectedCuisin} />
    //       </div>
    //       <div
    //         style={{ backgroundColor: "#D3D3D3" }}
    //         className="col-md-10 col-9 border border-dark"
    //       >
    //         {isRecipeEdit ? (
    //           <RecipeEdit recipe={recipeForEdit} />
    //         ) : (
    //           <div>
    //             <div className="row">
    //               <button
    //                 className="col-3 mt-2 btn btn-outline-primary"
    //                 style={{ marginLeft: "30px" }}
    //                 onClick={() => handleRecipeSelectedForEdit(blankrecipe)}
    //               >
    //                 Add New Recipe
    //               </button>
    //             </div>
    //             <RecipeMainScrean
    //               cuisineid={selectedCuisineId}
    //               onRecipeSelectedForEdit={handleRecipeSelectedForEdit}
    //             />
    //           </div>
    //         )}
    //       </div>
    //     </div>
    //   </div>
    // </>
  );
}

export default App;
