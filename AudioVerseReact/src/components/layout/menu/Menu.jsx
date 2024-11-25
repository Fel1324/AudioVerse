import { useAuth } from "../../../hooks/useAuth.js";
import { useMessage } from "../../../hooks/useMessage.js";
import { Link, useLocation } from "react-router-dom";

import { Message } from "../../../components/layout/message/Message.jsx";
import { CloseMenu } from "../../icons/CloseMenu";

import styles from "./Menu.module.css";

export function Menu({closeMenu}) {
  const { isLoggedIn, setIsLoggedIn } = useAuth();
  const { message, setMessage, messageText, setMessageText } = useMessage();
  const { pathname } = useLocation();

  function logOut(){
    api.post("/UserApp/logout", {}, {
      headers: {"Authorization": `Bearer ${localStorage.getItem("Token")}`},
    })
      .then(response => {
        console.log(response);
        localStorage.removeItem("Token");
        localStorage.removeItem("UserName");
        localStorage.removeItem("UserId");
        setIsLoggedIn(false);
        setMessage(true);
        setMessageText("Você saiu de sua conta!");
      })
      .catch(error => {
        console.error(error);
      });
  }

  return (
    <>
      {message && <Message text={messageText} />}

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
            {pathname === "/" ? (
              <Link className="link--active" to="/">Início</Link>
            ) : (
              <Link to="/">Início</Link>
            )}
          </li>

          <li>
            {pathname === "/favorites" ? (
              <Link className="link--active" to="/favorites">Favoritos</Link>
            ) : (
              <Link to="/favorites">Favoritos</Link>
            )}
          </li>
        </ul>
      </nav>
    </>
  )
}
