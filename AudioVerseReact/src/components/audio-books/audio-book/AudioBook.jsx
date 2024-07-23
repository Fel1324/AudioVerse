import { BookMark } from "../../icons/BookMark.jsx";

import styles from "./AudioBook.module.css";

export function AudioBook({ id, name, audioBookCover, parentalRating, onOpenAudioBook }) {
  return (
    <li id={id} className={styles.audiobook}>
      <h3 className={styles.audiobook__title} title={name}>{name}</h3>
      <img onClick={() => onOpenAudioBook(id)} src={audioBookCover} alt={`Capa do livro ${name} gerada por inteligência artificial.`} />
      
      <div>
        <BookMark />
        <span className={styles.audiobook__parentalRating}>{parentalRating}</span>
      </div>
    </li>
  )
}
