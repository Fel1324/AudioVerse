import { BookMark } from "../../icons/BookMark.jsx";

import styles from "./AudioBook.module.css";

export function AudioBook({ id, name, audiobookCover, onOpenAudioBook }) {
  return (
    <li id={id} className={styles.audiobook}>
      <h3 className={styles.audiobook__title} title={name}>{name}</h3>
      <img onClick={() => onOpenAudioBook(id)} src={audiobookCover} alt={``} />
      
      <div>
        <BookMark />
        <span className={styles.audiobook__parentalRating}>15</span>
      </div>
    </li>
  )
}
