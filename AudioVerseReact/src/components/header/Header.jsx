import { Link } from "react-router-dom";
import logo from "../../assets/logo.svg";

export function Header(){
  return (
    <header>
      <Link to="/">
        <img src={logo} alt="Logo AudioVerse" />
      </Link>
    </header>
  )
}