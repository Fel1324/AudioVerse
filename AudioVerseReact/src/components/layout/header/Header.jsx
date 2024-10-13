import { useState } from "react";
import { useAuth } from "../../../hooks/useAuth.js";
import { Link, useNavigate } from "react-router-dom";

import { Menu } from "../menu/Menu.jsx";
import { OpenMenu } from "../../icons/OpenMenu.jsx";
import { Search } from "../search/Search.jsx";
import { SearchIcon } from "../../icons/SearchIcon.jsx";
import { InputSearch } from "../input-search/InputSearch.jsx";

import logo from "../../../assets/logo.svg";
import styles from "./Header.module.css";

export function Header({ headerBoxShadow }){
  const { isLoggedIn } = useAuth();
  const [isMenuOpen, setIsMenuOpen] = useState(false);
  const [isSearchOpen, setSearchIsOpen] = useState(false);
  const navigate = useNavigate();

  function openMenu(){
    setIsMenuOpen(true);
  }

  function closeMenu(){
    setIsMenuOpen(false);
  }

  function openSearch(){
    setSearchIsOpen(true);
  }

  function closeSearch(){
    setSearchIsOpen(false);
  }

  function logOut(){
    navigate("/login");
  }

  return (
    <header className={`${styles.header} ${headerBoxShadow ? styles.headerBoxShadow : null}`}>
      <div className={styles.header__container}>
        <Link to="/">
          <img src={logo} alt="Logo AudioVerse" />
        </Link>

        <InputSearch />

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

          <button onClick={openSearch} className={`${styles.header__button} ${styles.openSearch}`} aria-label="Abrir barra de pesquisa">
            <SearchIcon />
          </button>

          <button onClick={openMenu} className={`${styles.header__button} ${styles.openMenu}`} aria-label="Abrir menu lateral">
            <OpenMenu />
          </button>
        </div>
      </div>

      {isSearchOpen && <Search closeSearch={closeSearch} />}
      {isMenuOpen && <Menu closeMenu={closeMenu} />}
    </header>
  )
}
