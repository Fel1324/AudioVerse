import { Header } from "../../components/header/Header.jsx";
import { Footer } from "../../components/footer/Footer.jsx";
import { BookFilter } from "../../components/book-filter/BookFilter.jsx";

import icons from "../../assets/icons.js";
import styles from "./Home.module.css";

export function Home(){
  return (
    <>
      <Header />

      <main className={`${styles.home} main`}>
        <section className={styles.home__banner}>
          <div className={styles.banner__content}>
            <h1>O melhor da literatura nacional em forma de áudio</h1>
            <img src={icons.openbook} alt="" />
          </div>
        </section>

        <div className={`${styles.home__container} container`}>
          <section>
            <BookFilter name="Gênero" />
            <BookFilter name="Autor" />
          </section>
        </div>
      </main>

      <Footer />
    </>
  )
}
