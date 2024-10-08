import { NavLink } from "react-router-dom";

export default function Navbar() {
  return (
    <>
      <nav
        className="col-12 navbar navbar-expand-lg navbar-toggleable-sm bg-primary"
        data-bs-theme="dark"
      >
        <div className="container-fluid">
          <NavLink to="/recipe">
            {/* <a className="navbar-brand" href="#"> */}
            <img src="/img/logo.svg" alt="brand img" width="50" height="50" />
            Hearty Hearth
            {/* </a> */}
          </NavLink>
          <button
            className="navbar-toggler collapsed"
            type="button"
            data-bs-toggle="collapse"
            data-bs-target="#navbarNav"
            aria-controls="navbarNav"
            aria-expanded="false"
            aria-label="Toggle navigation"
          >
            <span className="navbar-toggler-icon"></span>
          </button>

          <div
            className="navbar-collapse collapse d-lg-inline-flex justify-content-between"
            id="navbarNav"
          >
            <ul className="navbar-nav me-auto">
              <li className="nav-item">
                <NavLink to="/recipe" className="nav-link">
                  {/* <a className="nav-link active" href="#"> */}
                  Recipes
                  <span className="visually-hidden">(current)</span>
                  {/* </a> */}
                </NavLink>
              </li>
              <li className="nav-item">
                <NavLink to="/meal" className="nav-link">
                  {/* <a className="nav-link" href="#"> */}
                  Meals
                  {/* </a> */}
                </NavLink>
              </li>
              <li className="nav-item">
                <NavLink to="/cookbook" className="nav-link">
                  {/* <a className="nav-link" href="#"> */}
                  Cookbooks
                  {/* </a> */}
                </NavLink>
              </li>
            </ul>
          </div>
        </div>
      </nav>
    </>
  );
}
