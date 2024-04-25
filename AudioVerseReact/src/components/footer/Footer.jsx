import { Copyright } from "lucide-react";

import styles from "./Footer.module.css"

export function Footer(){
  return (
    <footer className={styles.footer}>
      <p>Copyright <Copyright width={`${1}rem`} /></p>
    </footer>
  )
}