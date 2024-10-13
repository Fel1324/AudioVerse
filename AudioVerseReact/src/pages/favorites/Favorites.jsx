import { Link } from "react-router-dom";

import { Header } from "../../components/layout/header/Header.jsx";
import { Footer } from "../../components/layout/footer/Footer.jsx";
import { FavoriteList } from "../../components/layout/favorite-list/FavoriteList.jsx";

import styles from "./Favorites.module.css";
import { useAuth } from "../../hooks/useAuth.js";

export function Favorites(){
  const { isLoggedIn } = useAuth();

  return (
    <>
      <Header headerBoxShadow />

      <main className={`${styles.favorites} main main-pd-bottom`}>
        {isLoggedIn ? (
          <FavoriteList />
        ) : (
          <div className="favorite-message">
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