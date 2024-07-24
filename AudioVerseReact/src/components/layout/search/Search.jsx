import { InputSearch } from "../input-search/InputSearch.jsx";
import { CloseMenu } from "../../icons/CloseMenu";

import styles from "./Search.module.css";

export function Search({closeSearch}){
  return (
    <aside className={styles.search}>
      <InputSearch className="input-search--fgrow" />
      <button onClick={closeSearch} className="button-close">
          <CloseMenu />
      </button>
    </aside>
  )
}
