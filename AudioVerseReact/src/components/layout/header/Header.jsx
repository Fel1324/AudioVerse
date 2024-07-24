import { useState } from "react";
import { Link } from "react-router-dom";

import { Menu } from "../menu/Menu.jsx";
import { OpenMenu } from "../../icons/OpenMenu.jsx";
import { Search } from "../search/Search.jsx";
import { SearchIcon } from "../../icons/SearchIcon.jsx";

import logo from "../../../assets/logo.svg";
import styles from "./Header.module.css";

export function Header(){
  const [isMenuOpen, setIsMenuOpen] = useState(false);
  const [isSearchOpen, seSearchtIsOpen] = useState(false);

  function openMenu(){
    setIsMenuOpen(true);
  }

  function closeMenu(){
    setIsMenuOpen(false);
  }

  function openSearch(){
    seSearchtIsOpen(true);
  }

  function closeSearch(){
    seSearchtIsOpen(false);
  }

  return (
    <header className={styles.header}>
      <div className={styles.header__container}>
        <Link to="/">
          <img src={logo} alt="Logo AudioVerse" />
        </Link>

        <div>
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
