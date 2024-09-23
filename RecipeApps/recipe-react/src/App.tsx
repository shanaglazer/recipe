import "bootstrap/dist/css/bootstrap.min.css";
import "bootstrap/dist/js/bootstrap.bundle.min";

import "./assets/css/bootstrap.min.css";
import Navbar from "./Navbar";
import CuisineSidebar from "./CuisineSidebar";
import RecipeMainScrean from "./RecipeMainScrean";
import { useState } from "react";
import RecipeEdit from "./RecipeEdit";

function App() {
  const [selectedCuisineId, setSelectedCuisineId] = useState(0);
  const [isRecipeEdit, setIsRecipeEdit] = useState(false);

  const handleSelectedCuisin = (cuisineid: number) => {
    setSelectedCuisineId(cuisineid);
  };

  return (
    <>
      <div className="container-fluid">
        <div className="row">
          <Navbar />
        </div>
        <div className="row">
          <div className="col-md-2 col-3 border border-dark">
            <CuisineSidebar onCuisineSelected={handleSelectedCuisin} />
          </div>
          <div
            style={{ backgroundColor: "#D3D3D3" }}
            className="col-md-10 col-9 border border-dark"
          >
            {isRecipeEdit ? (
              <RecipeEdit />
            ) : (
              <div>
                <div className="row">
                  <button
                    className="col-3 mt-2 btn btn-outline-primary"
                    style={{ marginLeft: "30px" }}
                  >
                    Add New Recipe
                  </button>
                </div>
                <RecipeMainScrean cuisineid={selectedCuisineId} />
              </div>
            )}
          </div>
        </div>
      </div>
    </>
  );
}

export default App;
