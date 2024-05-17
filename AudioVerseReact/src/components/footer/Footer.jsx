import { Link } from "react-router-dom";
import { Copy } from "../../components/icons/Copy.jsx";

import styles from "./Footer.module.css";

export function Footer(){
  return (
    <footer className={styles.footer}>
      <p>AudioVerse - Utilização de AudioBooks de Domínio Público associados a
        <Link className={styles.link} to="https://librivox.org/" target="_blank"> LibriVox</Link>.
      </p>

      <div className={styles.footer__copyright}>
        <Copy />
        <span>Domínio público</span>
      </div>
    </footer>
  )
}