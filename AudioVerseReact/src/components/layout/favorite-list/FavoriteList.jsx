import styles from "./FavoriteList.module.css";

export function FavoriteList(){
  return (
    <div className="favorite-message">
      {favorites.length === 0 ? (
        <div className={styles.message}>
          <p className={styles.paragraph}>Você ainda não favoritou nenhum audiobook!</p>
        </div> 
      ) : (
        <div>
          <p>Favoritos :D</p>
        </div>
      )}
    </div>
  )
}