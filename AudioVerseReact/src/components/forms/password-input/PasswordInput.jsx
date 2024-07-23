import { PasswordEye } from "../../icons/PasswordEye.jsx";

import styles from "./PasswordInput.module.css";

export function PasswordInput({type, name, id, content, autoComplete}){
  return(
    <div className={`${styles.pwdInputGroup} input-group`}>
      <label className="label" htmlFor={id}>{content}</label>
      <input
        className="input"
        type={type}
        name={name}
        id={id}
        placeholder={content}
        autoComplete={autoComplete}
        minLength="7"
        maxLength="32"
        required
      />
      <button className={styles.icon}>
        <PasswordEye />
      </button>
    </div>
  )
}
