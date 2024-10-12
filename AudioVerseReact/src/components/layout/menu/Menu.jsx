import { Link } from "react-router-dom";

import { CloseMenu } from "../../icons/CloseMenu";
import styles from "./Menu.module.css";

export function Menu({closeMenu}) {
  return (
    <nav className={styles.menu}>
      <div className={styles.menu__header}>
        <Link className="primary-navbar-link" to="/login">Entrar</Link>
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
