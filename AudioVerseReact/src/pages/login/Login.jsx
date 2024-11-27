import { useEffect } from "react";
import { useForm } from "react-hook-form";
import { useNavigate, Link } from "react-router-dom";
import { useMessage } from "../../hooks/useMessage.js";

import { useAuth } from "../../hooks/useAuth.js";
import { api } from "../../lib/axios.js";

import { DefaultInput } from "../../components/forms/default-input/DefaultInput";
import { PasswordInput } from "../../components/forms/password-input/PasswordInput";
import { ArrowLeft } from "../../components/icons/ArrowLeft.jsx";
import { Message } from "../../components/layout/message/Message.jsx";

import logo from "../../assets/logo.svg";
import styles from "./Login.module.css";

export function Login() {
  const { message, setMessage, messageText, setMessageText } = useMessage();
  const { isLoggedIn, setIsLoggedIn, setUserInfo} = useAuth();
  const { register, handleSubmit, formState: {errors} } = useForm();
  const navigate = useNavigate();
  
  function navigateToRegister(){
    navigate("/register");
  }

  function navigateToHome(){
    navigate("/");
  }

  function confirmLogin(data){
    api.post("/UserApp/login", {
        username: data.username,
        password: data.password
      })
      .then(response => {
        setIsLoggedIn(true);
        localStorage.setItem("Token", response.data);
      })
      .catch(error => {
        setMessage(true);
        setMessageText(error.response.data);
      });
  }

  useEffect(() => {
    if(isLoggedIn){
      api.get("/UserApp/userinfo", {
        headers: {"Authorization": `Bearer ${localStorage.getItem("Token")}`},
      })
        .then(response => {
          setUserInfo({
            userId: localStorage.setItem("UserId", response.data.userId),
            userName: localStorage.setItem("UserName", response.data.username)
          });
        })
        .catch(error => {
          console.error(error);
        });
        
      navigate("/");
      setTimeout(() => {
        window.location.reload();
      }, 100)
    }
  }, [isLoggedIn]);

  return (
    <>
      {message && <Message text={messageText} />}

      <div className="page-account">
        <header className="secondary-header">
          <Link to="/" className="logo">
            <img className="secondary-logo" src={logo} alt="logo AudioVerse" />
          </Link>
        </header>

        <main className={`main`}>
          <div className="secondary-container">
            <div className="linkBack">
              <button onClick={navigateToHome} aria-label="Voltar para página inicial" title="Voltar para página inicial">
                <ArrowLeft />
              </button>
            </div>

            <h1 className={styles.login__title}>Login</h1>
            <p className="paragraph">Explore clássicos em áudio: AudioVerse, sua porta de entrada para os principais audiobooks de domínio público.</p>

            <form onSubmit={handleSubmit(confirmLogin)} className={styles.login__form} autoComplete="off">
              <div className="form-container">
                <div>
                  <DefaultInput
                    type="text"
                    name="name"
                    content="Nome de usuário"
                    {...register('username', {
                      required: { message: 'O nome de usuário é obrigatório!', value: true },
                    })}
                  />
                  {errors?.username?.message && <p className="error-message">{errors?.username?.message}</p>}
                </div>
                <div>
                  <PasswordInput
                    name="password"
                    id="password"
                    content="Senha"
                    {...register('password', {
                      required: { message: 'A senha é obrigatória!', value: true },
                    })}
                  />
                  {errors?.password?.message && <p className="error-message">{errors?.password?.message}</p>}
                </div>
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
    </>
  )
}