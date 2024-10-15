import { SearchIcon } from "../../icons/SearchIcon";
import styles from "./InputSearch.module.css";

export function InputSearch({onSubmit}){
    return (
    <form onSubmit={onSubmit} className={styles.formSearch} autoComplete="off">
      <input
        className={`${styles.InputSearch}`}
        id="search"
        type="search"
        name="search"
        placeholder="Pesquisar AudioBook"
      />
      <button type="submit" className={styles.buttonSearch}>
        <SearchIcon />
      </button>
    </form>
  )
}