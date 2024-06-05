import { useNavigate } from "react-router-dom";
import { Link } from "react-router-dom";

import logo from "../../assets/logo.svg";
import styles from "./Login.module.css";

export function Login() {
  const navigate = useNavigate();
  
  function navigateFromRegister(){
    navigate("/register");
  }

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

          <div className={styles.login__footer}>
            <p className={`${styles.login__paragraph} paragraph`}>Não tem uma conta ainda?</p>
            <button className={styles.login__button} onClick={navigateFromRegister}>Criar conta</button>
          </div>
        </div>
      </main>
    </>
  )
}