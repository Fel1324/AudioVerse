import { Link } from "react-router-dom";
import { Search } from "../../components/icons/Search.jsx";
import { OpenMenu } from "../../components/icons/OpenMenu.jsx";


import logo from "../../assets/img/logo.svg";
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
            <Search />
          </button>

          <button className={`${styles.header__button} ${styles.openMenu}`} aria-label="Abrir menu lateral">
            <OpenMenu />
          </button>
        </div>
      </div>
    </header>
  )
}
