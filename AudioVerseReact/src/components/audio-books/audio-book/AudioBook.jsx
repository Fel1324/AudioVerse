import { useState } from "react";
import { BookMark } from "../../icons/BookMark.jsx";

import styles from "./AudioBook.module.css";
import { BookMarkFill } from "../../icons/BookMarkFill.jsx";

export function AudioBook({ id, name, audioBookCover, parentalRating, onOpenAudioBook, alternativeStyle }) {
  const [isFavorited, setIsFavorited] = useState(false);

  function favoriteAudioBook(){
    isFavorited ? setIsFavorited(false) : setIsFavorited(true);
  }

  return (
    <li id={id} className={styles.audiobook}>
      <h3 className={styles.audiobook__title} title={name}>{name}</h3>
      <img onClick={() => onOpenAudioBook(id)} src={audioBookCover} alt={`Capa do livro ${name} gerada por inteligência artificial.`} />
      
      {alternativeStyle ? (
        <div>
          <button onClick={() => favoriteAudioBook()} className={styles.bookMark}>
            {isFavorited ? <BookMarkFill /> : <BookMark />}
          </button>
          <span className={`${styles.audiobook__parentalRating} ${styles.parentalRatingDesktop}`}>{parentalRating}</span>
        </div>
      ) : (
        <div>
          <button className={styles.bookMarkHover} onClick={() => favoriteAudioBook()}>
            {isFavorited ? <BookMarkFill /> : <BookMark />}
          </button>
          <span className={styles.audiobook__parentalRating}>{parentalRating}</span>
        </div>
      )}
    </li>
  )
}
