import { useId, forwardRef } from "react"

export const DefaultInput = forwardRef(function ({content, name, onChange, error}, ref){
  const id = useId();
  
  return(
    <div className="input-group">
      <label className="label" htmlFor={id}>{content}</label>
      <input
        id={id}
        type="text"
        className={`input ${error && 'input-error'}`}
        placeholder={content}
        ref={ref}
        name={name}
        onChange={onChange}
      />
    </div>
  )
})
