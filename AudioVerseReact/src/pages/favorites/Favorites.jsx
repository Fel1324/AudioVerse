import { useState } from "react";
import { Link } from "react-router-dom";

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
            <div>
              <p>
                Você ainda não está logado em sua conta! Para acessar seus audiobooks favoritos faça <Link to="/login">login</Link> agora mesmo!
              </p>
              <p>
                Se não criou uma conta ainda não perca tempo, se <Link to="/register">cadastre</Link> imediatamente!
              </p>
            </div>
          </div>
        )}
      </main>

      <Footer />
    </>
  )
}