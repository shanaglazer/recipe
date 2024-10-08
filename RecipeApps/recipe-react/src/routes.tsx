import { createBrowserRouter } from "react-router-dom";
import RecipePage from "./RecipePage";
import CookbookMainScreen from "./CookbookMainScreen";
import MealMainScreen from "./MealMainScreen";
import App from "./App";

const router = createBrowserRouter([
  {
    path: "/",
    element: <App />,
    children: [
      { path: "/", element: <RecipePage /> },
      { path: "/recipe", element: <RecipePage /> },
      { path: "/cookbook", element: <CookbookMainScreen /> },
      { path: "/meal", element: <MealMainScreen /> },
    ],
  },
]);

export default router;
