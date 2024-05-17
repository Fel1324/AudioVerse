import { ChevronDown } from "../../components/icons/ChevronDown.jsx";

import styles from "./BookFilter.module.css";

export function BookFilter({ name }){
    return (
        <button className={styles.filter} aria-label={`Abrir filtro de ${name}`}>
            {name}
            <span>
                <ChevronDown />
            </span>
        </button>
    )
}
