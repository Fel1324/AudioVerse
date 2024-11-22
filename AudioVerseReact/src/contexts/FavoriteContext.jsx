import { createContext, useEffect, useState } from "react";
import { useAuth } from "../hooks/useAuth";
import { api } from "../lib/axios";

export const FavoriteContext = createContext();

export function FavoriteProvider({ children }){
  const { userInfo, isLoggedIn } = useAuth();
  const [favorites, setFavorites] = useState([]);

  useEffect(() => {
    if(isLoggedIn){
      api.get(`/Favorito/byuser/${userInfo.userId}`)
        .then(response => {
          setFavorites(response.data ?? []);
        })
        .catch(error => {
          console.log(error);
        });
    }
  }, [isLoggedIn])

  const isFavorited = (id) => {
    const foundFavorite = favorites.find(favorite => favorite.book.id === id);
    return !!foundFavorite;
  }

  const favoriteAudioBook = async (audioBookId) => {
    if (!isLoggedIn) return;
    
    try {
      await api.post("/Favorito", {
        userAppId: userInfo.userId,
        bookId: audioBookId,
        dateAdded: new Date().toISOString(),
      });
  
      const response = await api.get(`/Favorito/byuser/${userInfo.userId}`);
      setFavorites(response.data ?? []);

    } catch (error) {
      console.error(error);
    }
  }

  const unfavoriteAudioBook = async (audioBookId) => {
    if (!isLoggedIn) return

    const favorite = favorites.find(f => f.book.id === audioBookId);
    await api.delete(`/Favorito/${favorite.favoritoId}`)

    setFavorites(prev => prev.filter(fav => fav.favoritoId !== favorite.favoritoId));
  }

  return (
    <FavoriteContext.Provider value={{isFavorited, favoriteAudioBook, unfavoriteAudioBook, favorites}}>
      {children}
    </FavoriteContext.Provider>
  )
}