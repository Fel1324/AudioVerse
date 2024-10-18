import { useState } from "react";
import { Link, useNavigate } from "react-router-dom";

import { Header } from "../../components/layout/header/Header.jsx";
import { Footer } from "../../components/layout/footer/Footer.jsx";
import { FavoriteList } from "../../components/layout/favorite-list/FavoriteList.jsx";
import { Message } from "../../components/layout/message/Message.jsx";

import styles from "./Favorites.module.css";
import { api } from "../../lib/axios.js";
import { useAuth } from "../../hooks/useAuth.js";

export function Favorites(){
  const { isLoggedIn } = useAuth();
  const navigate = useNavigate();
  const [message, setMessage] = useState(false);

  function filterAudioBook(e){
    e.preventDefault();
    const inputValue = e.target.children[0].value;

    if(inputValue.length > 0){
      api.get(`/Book/detailed/filter/${inputValue}`)
        .then(response => {
          response.data.id ? navigate(`/audiobook/${response.data.id}`) : setMessage(true);
        })
        .catch(err => console.log(err));
  
      e.target.reset();
    }

    return;
  }

  setTimeout(() => {
    if(message){
      setMessage(false)
    }
    clearTimeout();
  }, 3000)

  return (
    <>
      {message && <Message text={"Nenhum resultado encontrado!"} />}

      <Header headerBoxShadow onSubmit={filterAudioBook} />

      <main className={`${styles.favorites} main main-pd-bottom`}>
        {isLoggedIn ? (
          <FavoriteList />
        ) : (
          <div className="favorite-message">
            <div>
              <p>
                Você ainda não está logado em sua conta! Para acessar seus audiobooks favoritos faça <Link to="/login">login</Link> agora mesmo!
              </p>
              <p>
                Se não criou uma conta ainda não perca tempo, se <Link to="/register">cadastre</Link> imediatamente!
              </p>
            </div>
          </div>
        )}
      </main>

      <Footer />
    </>
  )
}