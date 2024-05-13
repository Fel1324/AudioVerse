import { Link } from "react-router-dom";

import logo from "../../assets/img/logo.svg";
import icons from "../../assets/icons.js";
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
            <img src={icons.search} alt="" />
          </button>

          <button className={`${styles.header__button} ${styles.openMenu}`} aria-label="Abrir menu lateral">
            <img src={icons.openmenu} alt="" />
          </button>
        </div>
      </div>
    </header>
  )
}
