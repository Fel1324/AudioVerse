import { ChevronDown } from "../../icons/ChevronDown.jsx";

import styles from "./AudiobookFilter.module.css";

export function AudiobookFilter({ name }){
    return (
        <button className={styles.filter} aria-label={`Abrir filtro de ${name}`}>
            {name}
            <span>
                <ChevronDown />
            </span>
        </button>
    )
}
