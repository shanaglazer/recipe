import "./assets/css/bootstrap.min.css";
import Navbar from "./Navbar";
import CuisineSidebar from "./CuisineSidebar";
import RecipeMainScrean from "./RecipeMainScrean";
import { useState } from "react";

function App() {
  const [selectedCuisineId, setSelectedCuisineId] = useState(0);
  const handleSelectedCuisin = (cuisineid: number) => {
    setSelectedCuisineId(cuisineid);
  };

  return (
    <>
      <div className="container">
        <div className="row">
          <Navbar />
        </div>
        <div className="row">
          <div className="col-2">
            <CuisineSidebar onCuisineSelected={handleSelectedCuisin} />
          </div>
          <div className="col-10">
            <RecipeMainScrean cuisineid={selectedCuisineId} />
          </div>
        </div>
      </div>
    </>
  );
}

export default App;
