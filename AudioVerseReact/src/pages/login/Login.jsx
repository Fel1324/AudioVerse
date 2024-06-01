import { Link } from "react-router-dom";

import logo from "../../assets/logo.svg";
import styles from "./Login.module.css";

export function Login() {
  return (
    <>
      <header className="secondary-header">
        <Link to="/">
          <img className="secondary-logo" src={logo} alt="logo AudioVerse" />
        </Link>
      </header>

      <main className="main">
        <div className="secondary-container">
          <h1 className={styles.login__title}>Login</h1>
          <p className="paragraph">Explore clássicos em áudio: AudioVerse, sua porta de entrada para os principais audiobooks de domínio público.</p>

          <form>
            <h2>Formulário de login...</h2>
          </form>

          <p className={`${styles.login__paragraph} paragraph`}>Não tem uma conta ainda?</p>
          <Link to="/register">
            Criar conta
          </Link>
        </div>
      </main>
    </>
  )
}