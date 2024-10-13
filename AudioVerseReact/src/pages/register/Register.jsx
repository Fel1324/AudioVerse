import { useState } from "react";
import { Link, useNavigate } from "react-router-dom";

import { DefaultInput } from "../../components/forms/default-input/DefaultInput";
import { PasswordInput } from "../../components/forms/password-input/PasswordInput";

import logo from "../../assets/logo.svg";
import { api } from "../../lib/axios";
import styles from "./Register.module.css";

export function Register() {
  const [userName, setUserName] = useState('');
  const [password, setPassword] = useState('');
  const [confirmPassword, setConfirmPassword] = useState('');
  const navigate = useNavigate();

  function onChangeUserName(e){
    setUserName(e.target.value);
  }

  function onChangePassword(e){
    setPassword(e.target.value);
  }

  function onChangeConfirmPassword(e){
    setConfirmPassword(e.target.value)
  }

  function createAccount(e){
    e.preventDefault();

    if(password === confirmPassword){
      api.post("/UserApp/cadastro", {
        username: userName,
        password: password,
        rePassword: confirmPassword
      })
      .then(response => {
        if(response.status === 200){
          navigate("/login");
        }
      })
      .catch(error => console.error(error));

    } else {
      alert("Senhas diferentes!");
    }
  }

  return (
    <div className="page-account">
      <header className="secondary-header">
        <Link to="/">
          <img className="secondary-logo" src={logo} alt="logo AudioVerse" />
        </Link>
      </header>

      <main className="main">
        <div className="secondary-container">
          <p className="paragraph">Mergulhe em audiobooks de obras de domínio público, disponíveis para ouvir a qualquer momento, em qualquer lugar.</p>
          <h1 className={styles.register__title}>Crie sua conta</h1>
        
          <form onSubmit={createAccount} className={styles.register__form} autoComplete="on">
            <div className="form-container">
              <DefaultInput
                type="text"
                name="name"
                content="Nome de usuário"
                autoComplete="name"
                onChange={onChangeUserName}
                value={userName}
              />
              <PasswordInput
                name="password"
                content="Senha"
                autoComplete="new-password"
                onChange={onChangePassword}
                value={password}
              />
              <PasswordInput
                name="confirm-password"
                content="Confirme a Senha"
                autoComplete="new-password"
                onChange={onChangeConfirmPassword}
                value={confirmPassword}
              />
            </div>

            <button className={`submit ${styles.register__submit}`} type="submit">
              Criar
            </button>
          </form>
        </div>
      </main>
    </div>
  )
}