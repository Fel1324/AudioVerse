import { useAuth } from "../../../hooks/useAuth.js";
import { useFavorite } from "../../../hooks/useFavorite.js";
import { Link } from "react-router-dom";
import { BookMark } from "../../icons/BookMark.jsx";
import { BookMarkFill } from "../../icons/BookMarkFill.jsx";

import styles from "./AudioBook.module.css";

export function AudioBook({ id, name, audioBookCover, parentalRating, alternativeStyle, noParentalRating }) {
  const { isFavorited, favoriteAudioBook, unfavoriteAudioBook } = useFavorite();
  const { isLoggedIn } = useAuth();

  return (
    <li id={id}>
      <Link className={styles.audiobook} to={`/audiobook/${id}`}>
        <h3 className={styles.audiobook__title} title={name}>{name}</h3>
        <img src={audioBookCover} alt={`Capa do livro ${name} gerada por inteligência artificial.`} />
      </Link>

      {alternativeStyle ? (
          <div className={styles.audiobook__footer}>
            {isFavorited(id) ? (
              <button className={styles.bookMark} disabled={!isLoggedIn} onClick={() => unfavoriteAudioBook(id)}>
                <BookMarkFill />
              </button>
            ) : (
              <button className={styles.bookMark} disabled={!isLoggedIn} onClick={() => favoriteAudioBook(id)}>
                <BookMark />
              </button>
            )}
          
            <span className={`${styles.audiobook__parentalRating} ${styles.parentalRatingDesktop}`}>{parentalRating}</span>
          </div>

        ) : (

          <div className={styles.audiobook__footer}>
            {isFavorited(id) ? (
              <button disabled={!isLoggedIn} onClick={() => unfavoriteAudioBook(id)}>
                <BookMarkFill />
              </button>
            ) : (
              <button disabled={!isLoggedIn} onClick={() => favoriteAudioBook(id)}>
                <BookMark />
              </button>
            )}
            <span className={`${styles.audiobook__parentalRating} ${noParentalRating}`}>{parentalRating}</span>
          </div>
        )}
    </li>
  )
}
