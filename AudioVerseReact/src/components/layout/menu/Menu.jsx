import { useAuth } from "../../../hooks/useAuth.js";
import { useMessage } from "../../../hooks/useMessage.js";
import { Link } from "react-router-dom";

import { Message } from "../../../components/layout/message/Message.jsx";
import { CloseMenu } from "../../icons/CloseMenu";

import styles from "./Menu.module.css";

export function Menu({closeMenu}) {
  const { isLoggedIn, setIsLoggedIn } = useAuth();
  const { message, setMessage } = useMessage();

  function logOut(){
    localStorage.removeItem("Token");
    setIsLoggedIn(false);
    setMessage(true);
  }

  return (
    <>
      {message && <Message text={"Você saiu de sua conta!"} />}

      <nav className={styles.menu}>
        <div className={styles.menu__header}>
          {isLoggedIn ? (
            <button onClick={logOut} className={`primary-navbar-link`}>Sair</button>
          ) : (
            <Link className={`primary-navbar-link`} to="/login">
              Entrar
            </Link>
          )}
          <button onClick={closeMenu} className="button-close">
            <CloseMenu />
          </button>
        </div>

        <ul className={styles.menu__body}>
          <li>
            <Link to="/">Início</Link>
          </li>

          <li>
            <Link to="/favorites">Favoritos</Link>
          </li>
        </ul>
      </nav>
    </>
  )
}
