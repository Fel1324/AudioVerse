import { BrowserRouter, Routes, Route } from "react-router-dom";

import { Home } from "./pages/home/Home.jsx";
import { AudioBookDetails } from "./pages/audio-book-details/AudioBookDetails.jsx";
import { Login } from "./pages/login/Login.jsx";
import { Register } from "./pages/register/Register.jsx";


export function Router() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/audiobook/:audioBookId" element={<AudioBookDetails />} />
        <Route path="/login" element={<Login />} />
        <Route path="/register" element={<Register />} />
      </Routes>
    </BrowserRouter>
  )
}
