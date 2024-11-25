import { Link, useNavigate } from "react-router-dom";
import { useMessage } from "../../hooks/useMessage.js";
import { useFavorite } from "../../hooks/useFavorite.js";

import { Header } from "../../components/layout/header/Header.jsx";
import { Footer } from "../../components/layout/footer/Footer.jsx";
import { FavoriteList } from "../../components/layout/favorite-list/FavoriteList.jsx";
import { Message } from "../../components/layout/message/Message.jsx";

import { api } from "../../lib/axios.js";
import { useAuth } from "../../hooks/useAuth.js";

export function Favorites(){
  const { message, setMessage, messageText, setMessageText } = useMessage();
  const { isLoggedIn, userInfo } = useAuth();
  const { favorites } = useFavorite();
  const navigate = useNavigate();

  function filterAudioBook(e){
    e.preventDefault();
    const inputValue = e.target.children[0].value;

    if(inputValue.length > 0){
      api.get(`/Book/detailed/filter/${inputValue}`)
        .then(response => {
          if(response.data.id){
            navigate(`/audiobook/${response.data.id}`)  
          } else {
            setMessage(true);
            setMessageText("Nenhum resultado encontrado!");
          }
        })
        .catch(err => console.log(err));
  
      e.target.reset();
    }

    return;
  }

  return (
    <>
      {message && <Message text={messageText} />}

      <Header headerBoxShadow onSubmit={filterAudioBook} />

      <main className={`main main-pd-bottom`}>
        <div className="container">
          {isLoggedIn && (
            <div>
              <h1>{userInfo.userName}</h1>
              <span>Número de favoritos {favorites.length}</span>
            </div>
          )}

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
        </div>
      </main>

      <Footer />
    </>
  )
}