import { createContext, useState } from "react";

export const MessageContext = createContext();

export function MessageProvider({ children }) {
  const [message, setMessage] = useState(false);
  const [messageText, setMessageText] = useState('');

  setTimeout(() => {
    if (message) {
      setMessage(false)
    }
    clearTimeout();
  }, 2500)

  return (
    <MessageContext.Provider value={{message, setMessage, messageText, setMessageText}}>
      {children}
    </MessageContext.Provider>
  )
}