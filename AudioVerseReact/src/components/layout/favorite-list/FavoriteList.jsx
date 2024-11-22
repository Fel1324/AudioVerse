import { useFavorite } from "../../../hooks/useFavorite.js";
import styles from "./FavoriteList.module.css";

export function FavoriteList(){
  const { favorites } = useFavorite();

  return (
    <div className="favorite-message">
      {favorites.length === 0 ? (
        <div className={styles.message}>
          <p className={styles.paragraph}>Você ainda não favoritou nenhum audiobook!</p>
        </div> 
      ) : (
        <div>
          <p>AudioBooks favoritados {favorites.length}</p>
        </div>
      )}
    </div>
  )
}