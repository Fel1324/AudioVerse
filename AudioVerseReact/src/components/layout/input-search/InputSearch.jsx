import styles from "./InputSearch.module.css";

export function InputSearch({className, value, onChange}){
  function handleChange(e){
    onChange(e.target.value);
  }
  
  return (
    <input 
      className={`${styles.InputSearch} ${className}`}
      id="search"
      type="search"
      name="search"
      placeholder="Pesquisar AudioBook"
      value={value}
      onChange={handleChange}
    />
  )
}