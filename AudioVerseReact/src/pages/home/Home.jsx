import { useEffect, useState } from "react";

import { Header } from "../../components/header/Header.jsx";
import { Footer } from "../../components/footer/Footer.jsx";
import { Audiobook } from "../../components/audiobooks/audiobook/Audiobook.jsx";
import { AudiobookFilter } from "../../components/audiobooks/audiobook-filter/AudiobookFilter.jsx";
import { AudiobookCarousel } from "../../components/audiobooks/audiobook-carousel/AudiobookCarousel.jsx";
import { OpenBook } from "../../components/icons/OpenBook.jsx";
import { HeadPhones } from "../../components/icons/HeadPhones.jsx";

import { audiobooks } from "../../data/audiobooks.js";
import styles from "./Home.module.css";

export function Home(){
  const [audiobook, setAudiobook] = useState([]);

  useEffect(() => {
    setAudiobook(audiobooks);
  }, [])

  return (
    <>
      <Header />

      <main className={`${styles.home} main`}>
        <section className={styles.home__banner}>
          <div className={styles.banner__container}>
            <h1>O melhor da literatura nacional em forma de áudio</h1>
            <div>
              <OpenBook />
            </div>
          </div>
        </section>

        <div className={`${styles.home__container} container`}>
          <div className={styles.home__filter}>
            <AudiobookFilter name="Gênero" />
            <AudiobookFilter name="Autor" />
          </div>

          <section className={styles.home__audiobooks}>
            <div className={styles.audiobooks__container}>
              <h2>ÁudioBooks</h2>

              <ul className={`${styles.audiobooks__list} display-grid`}>
                {
                  audiobook.map((adbk) => {
                    return(
                      <Audiobook
                        key={adbk.id}
                        id={adbk.id}
                        audiobookCover={adbk.audiobookCover}
                      />
                    )
                  })
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

          <AudiobookCarousel />
        </div>
      </main>

      <Footer />
    </>
  )
}
