import { useState } from "react";
import { useAuth } from "../../../hooks/useAuth.js";
import { useMessage } from "../../../hooks/useMessage.js";
import { Link, useLocation } from "react-router-dom";

import { Menu } from "../menu/Menu.jsx";
import { OpenMenu } from "../../icons/OpenMenu.jsx";
import { InputSearch } from "../input-search/InputSearch.jsx";
import { Message } from "../../../components/layout/message/Message.jsx";

import logo from "../../../assets/logo.svg";
import styles from "./Header.module.css";

export function Header({ headerBoxShadow, onSubmit }){
  const { message, setMessage, messageText, setMessageText } = useMessage();
  const { isLoggedIn, setIsLoggedIn } = useAuth();
  const [isMenuOpen, setIsMenuOpen] = useState(false);
  const { pathname } = useLocation();

  function openMenu(){
    setIsMenuOpen(true);
  }

  function closeMenu(){
    setIsMenuOpen(false);
  }

  function logOut(){
    localStorage.removeItem("Token");
    setIsLoggedIn(false);
    setMessage(true);
    setMessageText("Você saiu de sua conta!");
  }

  function logIn(){
    message && setMessage(false);
  }

  return (
    <>
      {message && <Message text={messageText} />}

      <header className={`${styles.header} ${headerBoxShadow ? styles.headerBoxShadow : null}`}>
        <div className={styles.header__container}>
          <Link to="/" className="logo">
            <img src={logo} alt="Logo AudioVerse" />
          </Link>

          <InputSearch onSubmit={onSubmit} />

          <div>
            <nav className={styles.navbar}>
              <ul>
                <li>
                  { pathname === "/" ? (
                    <Link className={`primary-navbar-link link--active`} to="/">
                      Início
                    </Link>
                  ) : (
                    <Link className={`primary-navbar-link`} to="/">
                      Início
                    </Link>
                  )}
                </li>
                <li>
                  { pathname === "/favorites" ? (
                    <Link className={`primary-navbar-link link--active`} to="/favorites">
                      Favoritos
                    </Link>
                  ) : (
                    <Link className={`primary-navbar-link`} to="/favorites">
                      Favoritos
                    </Link>
                  )}
                </li>
                <li className={styles.account}>
                  {isLoggedIn ? (
                    <button onClick={logOut} className={`primary-navbar-link`}>Sair</button>
                  ) : (
                    <Link onClick={logIn} className={`primary-navbar-link`} to="/login">
                      Entrar
                    </Link>
                  )}
                </li>
              </ul>
            </nav>

            <button onClick={openMenu} className={`${styles.header__button} ${styles.openMenu}`} aria-label="Abrir menu lateral">
              <OpenMenu />
            </button>
          </div>
        </div>

        {isMenuOpen && <Menu closeMenu={closeMenu} />}
      </header>
    </>
  )
}
