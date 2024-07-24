import { CloseMenu } from "../../icons/CloseMenu";

import styles from "./Search.module.css";

export function Search({closeSearch}){
  return (
    <aside className={styles.search}>
      <input type="search" name="search" id="search" placeholder="Pesquisar AudioBook" />
      <button onClick={closeSearch} className="buttonClose">
          <CloseMenu />
      </button>
    </aside>
  )
}
