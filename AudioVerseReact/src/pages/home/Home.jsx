import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";

import { Header } from "../../components/layout/header/Header.jsx";
import { Footer } from "../../components/layout/footer/Footer.jsx";
import { AudioBook } from "../../components/audiobooks/audiobook/AudioBook.jsx";
import { AudioBookFilter } from "../../components/audiobooks/audiobook-filter/AudioBookFilter.jsx";
import { AudioBookCarousel } from "../../components/audiobooks/audiobook-carousel/AudioBookCarousel.jsx";
import { OpenBook } from "../../components/icons/OpenBook.jsx";
import { OpenBookDesktop } from "../../components/icons/OpenBookDesktop.jsx";
import { HeadPhones } from "../../components/icons/head-phones/HeadPhones.jsx";

import { audioBooks } from "../../data/audioBooks.js";
import styles from "./Home.module.css";

export function Home() {
  const navigate = useNavigate();
  const [audioBook, setAudioBook] = useState([]);

  function openAudioBook(id) {
    navigate(`/audiobook/${id}`);
  }

  useEffect(() => {
    setAudioBook(audioBooks);
  }, [])

  return (
    <>
      <Header />

      <main className={`${styles.home} main`}>
        <section className={styles.home__banner}>
          <div className={styles.banner__container}>
            <div className={styles.openBookDesktop}>
              <OpenBookDesktop />
            </div>

            <h1>O melhor da literatura nacional em forma de áudio</h1>

            <div className={styles.openBookDesktop}>
              <OpenBookDesktop />
            </div>

            <div className={styles.openBookMobile}>
              <OpenBook />
            </div>
          </div>
        </section>

        <div className={`${styles.home__container} container`}>
          <div className={styles.home__filter}>
            <AudioBookFilter name="Gênero" />
            <AudioBookFilter name="Autor" />
          </div>

          <section className={styles.home__audiobooks}>
            <div className={styles.audiobooks__container}>
              <h2>ÁudioBooks</h2>

              <ul className={`${styles.audiobooks__list} display-grid`}>
                {
                  audioBook.map((adbk) => (
                    <AudioBook
                      key={adbk.id}
                      id={adbk.id}
                      audiobookCover={adbk.audiobookCover}
                      onOpenAudioBook={openAudioBook}
                    />
                  ))
                }
              </ul>

              <button className={styles.audiobooks__listenMore}>
                <div className={styles.listenMore__line} />
                <span>
                  Ouvir mais
                  <HeadPhones />
                </span>
                <div className={styles.listenMore__line} />
              </button>
            </div>
          </section>

          <AudioBookCarousel />
        </div>
      </main>

      <Footer />
    </>
  )
}
