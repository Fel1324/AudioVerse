import { createBrowserRouter, RouterProvider } from "react-router-dom";

import { Home } from "./pages/home/Home.jsx";
import { AudioBookDetails } from "./pages/audio-book-details/AudioBookDetails.jsx";
import { Login } from "./pages/login/Login.jsx";
import { Register } from "./pages/register/Register.jsx";
import { Favorites } from "./pages/favorites/Favorites.jsx";

export function App() {
  const router = createBrowserRouter([
    {
      path: "/",
      element: <Home />,
    },
    {
      path: "/audiobook/:audioBookId",
      element: <AudioBookDetails />,
    },
    {
      path: "/login",
      element: <Login />,
    },
    {
      path: "/register",
      element: <Register />,
    },
    {
      path: "/favorites",
      element: <Favorites />,
    },
  ]);

  return <RouterProvider router={router} />
}
