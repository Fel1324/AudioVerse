import { Header } from "../../components/header/Header.jsx";
import { Footer } from "../../components/footer/Footer.jsx";

import openBook from "../../assets/img/icons/openbook.svg";
import styles from "./Home.module.css";

export function Home(){
  return (
    <>
      <Header />

      <main className={`${styles.home} main`}>
        <section className={styles.home__banner}>
          <h1>O melhor da literatura nacional em forma de áudio</h1>
          <img src={openBook} alt="" />
        </section>

        <div className={`${styles.home__container} container`}>

        </div>
      </main>

      <Footer />
    </>
  )
}
