import { useAuth } from "../../../hooks/useAuth.js";
import { AudioBook } from "../../audio-books/audio-book/AudioBook.jsx";
import { useFavorite } from "../../../hooks/useFavorite.js";

import styles from "./FavoriteList.module.css";

export function FavoriteList(){
  const { favorites } = useFavorite();
  const { userInfo } = useAuth();

  return (
    <>
      {favorites.length === 0 ? (
        <div className="favorite-message">
          <div className={styles.message}>
            <p className={styles.paragraph}><strong>{userInfo.userName}</strong>, você ainda não favoritou nenhum audiobook!</p>
          </div>
        </div>
      ) : (
        <div className={styles.favoritesContent}>
          <div className={styles.favoritesHeader}>
            <h1>{userInfo.userName}</h1>
            <span>Número de favoritos: <strong>{favorites.length}</strong></span>
          </div>

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