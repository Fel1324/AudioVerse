import { useContext } from "react";
import { FavoriteContext } from "../contexts/FavoriteContext";

export const useFavorite = () => {
  const context = useContext(FavoriteContext);
  return context;
}
