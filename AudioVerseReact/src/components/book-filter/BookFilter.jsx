import icons from "../../assets/icons.js";

export function BookFilter({ name }){
    return (
        <button aria-label={`Abrir filtro de ${name}`}>
            {name}
            <span>
                <img src={icons.chevrondown} alt="" />
            </span>
        </button>
    )
}
