import styles from "./Audiobook.module.css";

export function Audiobook({id, audiobookCover}){
  return (
    <li id={id} className={styles.audiobook}>
      <img src={audiobookCover} alt="" />
    </li>
  )
}
