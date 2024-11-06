import { createContext, useState } from 'react';

export const AuthContext = createContext();

export function AuthProvider({ children }){
  const [isLoggedIn, setIsLoggedIn] = useState(() => {
    const token = localStorage.getItem("Token");

    return !!token;
  });

  return (
    <AuthContext.Provider value={{isLoggedIn, setIsLoggedIn}}>
      {children}
    </AuthContext.Provider>
  )
}
