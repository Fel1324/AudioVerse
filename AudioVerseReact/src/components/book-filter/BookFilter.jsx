import { ChevronDown } from "../../components/icons/ChevronDown.jsx";

export function BookFilter({ name }){
    return (
        <button aria-label={`Abrir filtro de ${name}`}>
            {name}
            <span>
                <ChevronDown />
            </span>
        </button>
    )
}
