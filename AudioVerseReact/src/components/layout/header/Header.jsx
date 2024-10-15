import { useState } from "react";
import { useAuth } from "../../../hooks/useAuth.js";
import { Link } from "react-router-dom";

import { Menu } from "../menu/Menu.jsx";
import { OpenMenu } from "../../icons/OpenMenu.jsx";
import { SearchIcon } from "../../icons/SearchIcon.jsx";
import { InputSearch } from "../input-search/InputSearch.jsx";
import { CloseMenu } from "../../icons/CloseMenu";

import logo from "../../../assets/logo.svg";
import styles from "./Header.module.css";

export function Header({ headerBoxShadow, onSubmit }){
  const { isLoggedIn, setIsLoggedIn } = useAuth();
  const [isMenuOpen, setIsMenuOpen] = useState(false);

  function openMenu(){
    setIsMenuOpen(true);
  }

  function closeMenu(){
    setIsMenuOpen(false);
  }

  function closeSearch(){
    setSearchIsOpen(false);
  }

  function logOut(){
    localStorage.removeItem("Token");
    setIsLoggedIn(false);
  }

  return (
    <header className={`${styles.header} ${headerBoxShadow ? styles.headerBoxShadow : null}`}>
      <div className={styles.header__container}>
        <Link to="/">
          <img src={logo} alt="Logo AudioVerse" />
        </Link>

        <InputSearch onSubmit={onSubmit} />

        <div>
          <nav className={styles.navbar}>
            <ul>
              <li>
                <Link className={`${styles.navbar__link} primary-navbar-link`} to="/">
                  Início
                </Link>
              </li>
              <li>
                <Link className={`${styles.navbar__link} primary-navbar-link`} to="/favorites">
                  Favoritos
                </Link>
              </li>
              <li>
                {isLoggedIn ? (
                  <button onClick={logOut} className={`${styles.navbar__link} primary-navbar-link`}>Sair</button>
                ) : (
                  <Link className={`${styles.navbar__link} primary-navbar-link`} to="/login">
                    Entrar
                  </Link>
                )}
              </li>
            </ul>
          </nav>

          <button onClick={openMenu} className={`${styles.header__button} ${styles.openMenu}`} aria-label="Abrir menu lateral">
            <OpenMenu />
          </button>
        </div>
      </div>

      {isMenuOpen && <Menu closeMenu={closeMenu} />}
    </header>
  )
}
