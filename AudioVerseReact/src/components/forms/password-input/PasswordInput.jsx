import { useId, useState } from "react";

import { PasswordEye } from "../../icons/PasswordEye.jsx";
import { PasswordEyeOff } from "../../icons/PasswordEyeOff.jsx";

import styles from "./PasswordInput.module.css";

export function PasswordInput({name, content, autoComplete, value, onChange}){
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
        onChange={onChange}
        value={value}
      />
      <button onClick={onChangeInputType} type="button" className={styles.icon}>
        {showPassword ? (
          <PasswordEyeOff />
        ) : (
          <PasswordEye />
        )}
      </button>
    </div>
  )
}
