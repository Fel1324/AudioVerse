import { Link } from "react-router-dom";
import { Search, Menu } from "lucide-react";

import logo from "../../assets/logo.svg";
import styles from "./Header.module.css";

export function Header(){
  return (
    <header className={styles.header}>
      <div className={styles.header__container}>
        <Link to="/">
          <img src={logo} alt="Logo AudioVerse" />
        </Link>

        <div>
          <button className={`${styles.header__button} ${styles.openSearch}`} aria-label="Abrir barra de pesquisa">
            <Search color="var(--icon-light-color)" strokeWidth={2.5} />
          </button>

          <button className={`${styles.header__button} ${styles.openMenu}`} aria-label="Abrir menu lateral">
            <Menu color="var(--icon-light-color)" strokeWidth={2.5} />
          </button>
        </div>
      </div>
    </header>
  )
}
