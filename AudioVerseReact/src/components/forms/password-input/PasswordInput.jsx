import { useId, useState, forwardRef } from "react";

import { PasswordEye } from "../../icons/PasswordEye.jsx";
import { PasswordEyeOff } from "../../icons/PasswordEyeOff.jsx";

import styles from "./PasswordInput.module.css";

export const PasswordInput = forwardRef(function ({content, name, onChange, error}, ref){
  const id = useId();
  const [showPassword, setShowPassword] = useState(false);

  function onChangeInputType(){
    setShowPassword((prevState) => !prevState);
  }

  return(
    <div className={`${styles.pwdInputGroup} input-group`}>
      <label className="label" htmlFor={id}>{content}</label>
      <input
        className={`input ${error && 'input-error'}`}
        type={showPassword ? "text" : "password"}
        id={id}
        placeholder={content}
        ref={ref}
        name={name}
        onChange={onChange}
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
})
