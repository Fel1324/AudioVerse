import { createContext, useState } from 'react';

export const AuthContext = createContext();

export function AuthProvider({ children }){
  const [isLoggedIn, setIsLoggedIn] = useState(() => {
    const token = localStorage.getItem("Token");

    return !!token;
  });

  const [userInfo, setUserInfo] = useState({
    userId: localStorage.getItem("UserId"),
    userName: localStorage.getItem("UserName")
  });

  return (
    <AuthContext.Provider value={{isLoggedIn, setIsLoggedIn, userInfo, setUserInfo}}>
      {children}
    </AuthContext.Provider>
  )
}
