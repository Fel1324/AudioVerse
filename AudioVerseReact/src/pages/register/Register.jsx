import { Link, useNavigate } from "react-router-dom";

import { DefaultInput } from "../../components/forms/default-input/DefaultInput";
import { PasswordInput } from "../../components/forms/password-input/PasswordInput";

import logo from "../../assets/logo.svg";
import styles from "./Register.module.css";

export function Register() {
  const navigate = useNavigate();

  function navigateToLogin(){
    navigate("/login");
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
          <p className="paragraph">Mergulhe em audiobooks de obras de domínio público, disponíveis para ouvir a qualquer momento, em qualquer lugar.</p>
          <h1 className={styles.register__title}>Crie sua conta</h1>
        
          <form onSubmit={navigateToLogin} className={styles.register__form} autoComplete="on">
            <div className="form-container">
              <DefaultInput
                type="email"
                name="email"
                id="email"
                content="Email"
                autoComplete="email"
              />
              <DefaultInput
                type="text"
                name="name"
                id="name"
                content="Nome"
                autoComplete="name"
              />
              <PasswordInput
                type="password"
                name="password"
                id="password"
                content="Senha"
                autoComplete="new-password"
              />
              <PasswordInput
                type="password"
                name="password"
                id="password"
                content="Confirme a Senha"
                autoComplete="new-password"
              />
            </div>

            <button className={`submit ${styles.register__submit}`} type="submit">
              Criar
            </button>
          </form>
        </div>
      </main>
    </>
  )
}