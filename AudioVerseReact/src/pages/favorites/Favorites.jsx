import { useState } from "react";

import { Header } from "../../components/layout/header/Header.jsx";
import { Footer } from "../../components/layout/footer/Footer.jsx";

import styles from "./Favorites.module.css";

export function Favorites(){
  const [favorites, setFavorites] = useState([]);

  return (
    <>
      <Header />

      <main className={`${styles.favorites} main main-pd-bottom`}>
        {favorites.length === 0 && (
          <div className={styles.message}>
            <p>Você ainda não favoritou nenhum audiobook!</p>
          </div>
        )}
      </main>

      <Footer />
    </>
  )
}