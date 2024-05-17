import { Header } from "../../components/header/Header.jsx";
import { Footer } from "../../components/footer/Footer.jsx";
import { BookFilter } from "../../components/book-filter/BookFilter.jsx";
import { Star } from "../../components/icons/Star.jsx";

import openBook from "../../assets/img/openbook.svg";
import styles from "./Home.module.css";

export function Home(){
  return (
    <>
      <Header />

      <main className={`${styles.home} main`}>
        <section className={styles.home__banner}>
          <div className={styles.banner__content}>
            <h1>O melhor da literatura nacional em forma de áudio</h1>
            <img src={openBook} alt="" />
          </div>
        </section>

        <div className={`${styles.home__container} container`}>
          <div className={styles.home__filter}>
            <BookFilter name="Gênero" />
            <BookFilter name="Autor" />
          </div>

          <section className={styles.home__audiobooks}>
            <h2>
              ÁudioBooks
              <Star />
            </h2>
          </section>
        </div>
      </main>

      <Footer />
    </>
  )
}
