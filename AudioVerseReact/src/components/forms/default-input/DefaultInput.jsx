export function DefaultInput({type, name, id, content}){
  return(
    <div className="input-group">
      <label className="label" htmlFor={id}>{content}</label>
      <input
        className="input"
        type={type}
        name={name}
        id={id}
        placeholder={content}
        autoComplete="email"
        minLength="14"
        maxLength="60"
        required />
    </div>
  )
}
