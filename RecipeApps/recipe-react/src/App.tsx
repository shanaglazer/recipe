import "./assets/css/bootstrap.min.css";
import Navbar from "./Navbar";
import CuisineSidebar from "./CuisineSidebar";
import RecipeMainScrean from "./RecipeMainScrean";

function App() {
  return (
    <>
      <div className="container">
        <div className="row">
          <Navbar />
        </div>
        <div className="row">
          <div className="col-2">
            <CuisineSidebar />
          </div>
          <div className="col-10">
            <RecipeMainScrean />
          </div>
        </div>
      </div>
    </>
  );
}

export default App;
