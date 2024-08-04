import { useId, useState } from "react";
import { PasswordEye } from "../../icons/PasswordEye.jsx";

import styles from "./PasswordInput.module.css";

export function PasswordInput({name, content, autoComplete}){
  const id = useId();
  const [showPassword, setShowPassword] = useState(false);

  function onChangeInputType(){
    setShowPassword((prevState) => !prevState);
  }

  return(
    <div className={`${styles.pwdInputGroup} input-group`}>
      <label className="label" htmlFor={id}>{content}</label>
      <input
        className="input"
        type={showPassword ? "text" : "password"}
        name={name}
        id={id}
        placeholder={content}
        autoComplete={autoComplete}
        minLength="7"
        maxLength="32"
        required
      />
      <button onClick={onChangeInputType} type="button" className={styles.icon}>
        <PasswordEye />
      </button>
    </div>
  )
}
