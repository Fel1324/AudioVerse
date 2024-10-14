import { useEffect, useState } from "react";
import { useNavigate, Link } from "react-router-dom";

import { useAuth } from "../../hooks/useAuth.js";
import { api } from "../../lib/axios.js";

import { DefaultInput } from "../../components/forms/default-input/DefaultInput";
import { PasswordInput } from "../../components/forms/password-input/PasswordInput";

import logo from "../../assets/logo.svg";
import styles from "./Login.module.css";

export function Login() {
  const { isLoggedIn, setIsLoggedIn} = useAuth();
  const [userName, setUserName] = useState('');
  const [password, setPassword] = useState('');
  const navigate = useNavigate();
  
  function onChangeUserName(e){
    setUserName(e.target.value);
  }

  function onChangePassword(e){
    setPassword(e.target.value);
  }

  function navigateToRegister(){
    navigate("/register");
  }

  function confirmLogin(e){
    e.preventDefault();

    api.post("/UserApp/login", {
        username: userName,
        password: password
      })
      .then(response => {
        setIsLoggedIn(true);
        localStorage.setItem("Token", response.data);
      })
      .catch(error => console.error(error));
  }

  useEffect(() => {
    if(isLoggedIn){
      navigate("/");
    }
  }, [isLoggedIn]);

  return (
    <div className="page-account">
      <header className="secondary-header">
        <Link to="/">
          <img className="secondary-logo" src={logo} alt="logo AudioVerse" />
        </Link>
      </header>

      <main className={`main`}>
        <div className="secondary-container">
          <h1 className={styles.login__title}>Login</h1>
          <p className="paragraph">Explore clássicos em áudio: AudioVerse, sua porta de entrada para os principais audiobooks de domínio público.</p>

          <form onSubmit={confirmLogin} className={styles.login__form} autoComplete="on">
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
                id="password"
                content="Senha"
                autoComplete="current-password"
                onChange={onChangePassword}
                value={password}
              />
            </div>
            <button className="submit" type="submit">Entrar</button>
          </form>

          <div className={styles.login__footer}>
            <p className={`${styles.login__paragraph} paragraph`}>Não tem uma conta ainda?</p>
            <button className={styles.login__button} onClick={navigateToRegister}>Criar conta</button>
          </div>
        </div>
      </main>
    </div>
  )
}