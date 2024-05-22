import styles from "./Book.module.css";

export function Book({id, bookCover}){
  return (
    <li id={id} className={styles.book}>
      <img src={bookCover} alt="" />
    </li>
  )
}
