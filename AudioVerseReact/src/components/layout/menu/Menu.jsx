import { Link } from "react-router-dom";

import { CloseMenu } from "../../icons/CloseMenu";
import styles from "./Menu.module.css";

export function Menu({closeMenu}) {
  return (
    <nav className={styles.menu}>
      <div className={styles.menu__header}>
        <Link to="/login">Entrar</Link>
        <button onClick={closeMenu} className="buttonClose">
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
  )
}
