import { ChevronDown } from "../../icons/chevron-down/ChevronDown.jsx";

import styles from "./AudioBookFilter.module.css";

export function AudioBookFilter({ name }) {
  return (
    <button className={styles.filter} aria-label={`Abrir filtro de ${name}`}>
      {name}
      <span>
        <ChevronDown />
      </span>
    </button>
  )
}
