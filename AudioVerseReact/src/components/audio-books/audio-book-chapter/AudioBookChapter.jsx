import styles from "./AudioBookChapter.module.css";

export function AudioBookChapter({name, source}){
  return (
    <li className={styles.chapter}>
      <h3>{name}</h3>
      <a className="link" href={source} target="_blank">Download.mp3</a>
    </li>
  )
}