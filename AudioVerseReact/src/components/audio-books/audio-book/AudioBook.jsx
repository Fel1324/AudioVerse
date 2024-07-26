import { BookMark } from "../../icons/BookMark.jsx";

import styles from "./AudioBook.module.css";

export function AudioBook({ id, name, audioBookCover, parentalRating, onOpenAudioBook, alternativeStyle }) {
  return (
    <li id={id} className={styles.audiobook}>
      <h3 className={styles.audiobook__title} title={name}>{name}</h3>
      <img onClick={() => onOpenAudioBook(id)} src={audioBookCover} alt={`Capa do livro ${name} gerada por inteligência artificial.`} />
      
      {alternativeStyle ? (
        <div>
          <BookMark className={styles.bookMark} />
          <span className={`${styles.audiobook__parentalRating} ${styles.parentalRatingDesktop}`}>{parentalRating}</span>
        </div>
      ) : (
        <div>
          <BookMark />
          <span className={styles.audiobook__parentalRating}>{parentalRating}</span>
        </div>
      )}
    </li>
  )
}
