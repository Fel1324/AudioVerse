import { BookMarkFill } from "../../icons/BookMarkFill.jsx";

import styles from "./AudioBook.module.css";

export function AudioBook({id, audiobookCover}){
  return (
    <li id={id} className={styles.audiobook}>
      <img src={audiobookCover} alt="" />

      <div>
        <BookMarkFill />
        <span className={styles.audiobook__parentalRating}>15</span>
      </div>
    </li>
  )
}
