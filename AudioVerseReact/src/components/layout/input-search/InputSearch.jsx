import styles from "./InputSearch.module.css";

export function InputSearch({className}){
  return (
    <input 
      className={`${styles.InputSearch} ${className}`}
      type="search"
      name="search"
      id="search"
      placeholder="Pesquisar AudioBook"
    />
  )
}