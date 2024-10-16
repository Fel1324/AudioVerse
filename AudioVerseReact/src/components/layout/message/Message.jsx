import styles from "./Message.module.css";

export function Message({ text, onClick }) {
  return (
    <div className={styles.message}>
      <span>{text}</span>
    </div>
  )
}
