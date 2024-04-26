import { BrowserRouter, Routes, Route } from "react-router-dom";

import { Home } from "./pages/home/Home";
import { BookSection } from "./pages/book-section/BookSection";

export function Router(){
  return (
    <BrowserRouter>
      <Routes>
        <Route path='/' element={<Home />} />
        <Route path="/audiobook" element={<BookSection />} />
      </Routes>
    </BrowserRouter>
  )
}
