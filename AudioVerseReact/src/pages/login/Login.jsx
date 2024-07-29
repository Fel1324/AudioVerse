import { useNavigate } from "react-router-dom";
import { Link } from "react-router-dom";

import { DefaultInput } from "../../components/forms/default-input/DefaultInput";
import { PasswordInput } from "../../components/forms/password-input/PasswordInput";

import logo from "../../assets/logo.svg";
import styles from "./Login.module.css";

export function Login() {
  const navigate = useNavigate();
  
  function navigateToRegister(){
    navigate("/register");
  }

  function navigateToHome(){
    navigate("/");
  }

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

          <form onSubmit={navigateToHome} className={styles.login__form} autoComplete="on">
            <div className="form-container">
              <DefaultInput
                type="email"
                name="email"
                id="email"
                content="Email"
                autoComplete="email"
              />
              <PasswordInput
                type="password"
                name="password"
                id="password"
                content="Senha"
                autoComplete="current-password"
              />
            </div>

            <Link className={styles.login__forgot} to="#">esqueceu sua senha?</Link>
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