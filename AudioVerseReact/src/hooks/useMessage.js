import { useContext } from "react";
import { MessageContext } from "../contexts/MessageContext";

export const useMessage = () => {
  const context = useContext(MessageContext);
  return context;
}
