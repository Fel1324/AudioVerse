import { Link } from "react-router-dom";
import { useAuth } from "../../../hooks/useAuth.js";

import { CloseMenu } from "../../icons/CloseMenu";
import styles from "./Menu.module.css";

export function Menu({closeMenu}) {
  const { isLoggedIn, setIsLoggedIn } = useAuth();

  function logOut(){
    localStorage.removeItem("Token");
    setIsLoggedIn(false);
  }

  return (
    <nav className={styles.menu}>
      <div className={styles.menu__header}>
        {isLoggedIn ? (
          <button onClick={logOut} className={`${styles.navbar__link} primary-navbar-link`}>Sair</button>
        ) : (
          <Link className={`${styles.navbar__link} primary-navbar-link`} to="/login">
            Entrar
          </Link>
        )}
        <button onClick={closeMenu} className="button-close">
          <CloseMenu />
        </button>
      </div>

      <ul className={styles.menu__body}>
        <li>
          <Link to="/">Início</Link>
        </li>

        <li>
          <Link to="/favorites">Favoritos</Link>
        </li>
      </ul>
    </nav>
  )
}
