import React from "react";
import ReactDOM from "react-dom/client";

import { App } from "./App.jsx";

import { AuthProvider } from "./contexts/AuthContext.jsx";
import { MessageProvider } from "./contexts/MessageContext.jsx";

import "./global.css";

ReactDOM.createRoot(document.getElementById("root")).render(
  <React.StrictMode>
    <AuthProvider>
      <MessageProvider>
        <App />
      </MessageProvider>
    </AuthProvider>
  </React.StrictMode>
)
