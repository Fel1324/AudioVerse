import { useState } from "react";

import { Link } from "react-router-dom";
import { Search } from "../../icons/Search.jsx";
import { OpenMenu } from "../../icons/OpenMenu.jsx";
import { CloseMenu } from "../../icons/CloseMenu.jsx";

import logo from "../../../assets/logo.svg";
import styles from "./Header.module.css";

export function Header(){
  const [isMenuOpen, setIsMenuOpen] = useState(false);

  function openMenu(){
    setIsMenuOpen(true);
  }

  function closeMenu(){
    setIsMenuOpen(false);
  }

  return (
    <header className={styles.header}>
      <div className={styles.header__container}>
        <Link to="/">
          <img src={logo} alt="Logo AudioVerse" />
        </Link>

        <div>
          <button className={`${styles.header__button} ${styles.openSearch}`} aria-label="Abrir barra de pesquisa">
            <Search />
          </button>

          <button onClick={openMenu} className={`${styles.header__button} ${styles.openMenu}`} aria-label="Abrir menu lateral">
            <OpenMenu />
          </button>
        </div>
      </div>

      {isMenuOpen && (
        <nav className={styles.menu}>
          <div className={styles.menu__header}>
            <Link to="/login">Entrar</Link>
            <button onClick={closeMenu}>
              <CloseMenu />
            </button>
          </div>

          <ul className={styles.menu__body}>
            <li>
              <Link to="/">Início</Link>
            </li>

            <li className={styles.fontInput}>
              <label htmlFor="font">Fonte: </label>
              <input type="number" defaultValue={12} min={12} max={24}/>
            </li>
          </ul>
        </nav>
      )}
    </header>
  )
}
