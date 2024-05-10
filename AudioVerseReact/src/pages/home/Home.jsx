import { Header } from "../../components/header/Header.jsx";
import { Footer } from "../../components/footer/Footer.jsx";

export function Home(){
  return (
    <>
      <Header />

      <main className="main">
        <h1>Hello World!</h1>
      </main>

      <Footer />
    </>
  )
}
