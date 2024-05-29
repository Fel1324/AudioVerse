import { BookMarkFill } from "../../icons/BookMarkFill.jsx";

import styles from "./AudioBook.module.css";

export function AudioBook({ id, audiobookCover, onOpenAudioBook }) {
  return (
    <li id={id} className={styles.audiobook} onClick={() => onOpenAudioBook(id)}>
      <img src={audiobookCover} alt="" />

      <div>
        <BookMarkFill />
        <span className={styles.audiobook__parentalRating}>15</span>
      </div>
    </li>
  )
}
