import { AudioBook } from "../../audio-books/audio-book/AudioBook.jsx";
import { useFavorite } from "../../../hooks/useFavorite.js";

import styles from "./FavoriteList.module.css";

export function FavoriteList(){
  const { favorites } = useFavorite();

  return (
    <>
      {favorites.length === 0 ? (
        <div className="favorite-message">
          <div className={styles.message}>
            <p className={styles.paragraph}>Você ainda não favoritou nenhum audiobook!</p>
          </div>
        </div>
      ) : (
        <div className={styles.favoritesContent}>
          <ul className="display-grid">
            {favorites.map((fav) => (
              <AudioBook
                key={fav.book.id}
                id={fav.book.id}
                name={fav.book.title}
                audioBookCover={fav.book.bookImage}
                noParentalRating="favorite-parental-rating"
              />
            ))}
          </ul>
        </div>
      )}
    </>
  )
}