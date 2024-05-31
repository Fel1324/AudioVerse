import { BrowserRouter, Routes, Route } from "react-router-dom";

import { Home } from "./pages/home/Home.jsx";
import { AudioBookDetails } from "./pages/audio-book-details/AudioBookDetails.jsx";

export function Router() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path='/' element={<Home />} />
        <Route path='/audiobook/:audioBookId' element={<AudioBookDetails />} />
      </Routes>
    </BrowserRouter>
  )
}
