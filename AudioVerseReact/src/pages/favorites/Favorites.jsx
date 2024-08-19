import { Header } from "../../components/layout/header/Header.jsx";
import { Footer } from "../../components/layout/footer/Footer.jsx";

import styles from "./Favorites.module.css";

export function Favorites(){
  return (
    <>
      <Header />

      <main className={`${styles.favorites} main`}>

      </main>

      <Footer />
    </>
  )
}