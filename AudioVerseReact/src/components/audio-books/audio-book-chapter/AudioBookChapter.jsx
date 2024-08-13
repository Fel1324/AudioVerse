import styles from "./AudioBookChapter.module.css";

export function AudioBookChapter({name, source, onOpenTargetChapter, index, active}){
  return (
    <li className={`${styles.chapter} ${active ? styles.active : ''}`}>
      <button onClick={() => onOpenTargetChapter(index)} title={`Seção ${index + 1}`}>
        {name}
      </button>

      <a className="link" href={source} target="_blank">Download.mp3</a>
    </li>
  )
}
