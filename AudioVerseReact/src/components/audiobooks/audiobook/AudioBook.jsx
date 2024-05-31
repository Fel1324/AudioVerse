import { BookMark } from "../../icons/book-mark/BookMark.jsx";

import styles from "./AudioBook.module.css";

export function AudioBook({ id, audiobookCover, onOpenAudioBook }) {
  return (
    <li id={id} className={styles.audiobook}>
      <img onClick={() => onOpenAudioBook(id)} src={audiobookCover} alt="" />

      <div>
        <BookMark />
        <span className={styles.audiobook__parentalRating}>15</span>
      </div>
    </li>
  )
}
