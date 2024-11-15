import { Link } from "react-router-dom";
import { BookMark } from "../../icons/BookMark.jsx";

import styles from "./AudioBook.module.css";

export function AudioBook({ id, name, audioBookCover, parentalRating, alternativeStyle }) {
  return (
    <li id={id}>
      <Link className={styles.audiobook} to={`/audiobook/${id}`}>
        <h3 className={styles.audiobook__title} title={name}>{name}</h3>
        <img src={audioBookCover} alt={`Capa do livro ${name} gerada por inteligência artificial.`} />
        
        {alternativeStyle ? (
          <div>
            <button className={styles.bookMark}>
              <BookMark />
            </button>
            <span className={`${styles.audiobook__parentalRating} ${styles.parentalRatingDesktop}`}>{parentalRating}</span>
          </div>
        ) : (
          <div>
            <button>
              <BookMark />
            </button>
            <span className={styles.audiobook__parentalRating}>{parentalRating}</span>
          </div>
        )}
      </Link>
    </li>
  )
}
