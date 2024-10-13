import { useId } from "react"

export function DefaultInput({type, name, content, autoComplete, value, onChange}){
  const id = useId();
  
  return(
    <div className="input-group">
      <label className="label" htmlFor={id}>{content}</label>
      <input
        id={id}
        className="input"
        type={type}
        name={name}
        placeholder={content}
        autoComplete={autoComplete}
        minLength="8"
        maxLength="32"
        required
        onChange={onChange}
        value={value}
      />
    </div>
  )
}
