import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";

import { Header } from "../../components/layout/header/Header.jsx";
import { Footer } from "../../components/layout/footer/Footer.jsx";
import { AudioBook } from "../../components/audio-books/audio-book/AudioBook.jsx";
import { AudioBookCarousel } from "../../components/audio-books/audio-book-carousel/AudioBookCarousel.jsx";
import { OpenBook } from "../../components/icons/OpenBook.jsx";
import { OpenBookDesktop } from "../../components/icons/OpenBookDesktop.jsx";
import { HeadPhones } from "../../components/icons/HeadPhones.jsx";

import { api } from "../../lib/axios.js";
import styles from "./Home.module.css";

export function Home() {
  const navigate = useNavigate();
  const [audioBook, setAudioBook] = useState([]);

  function openAudioBook(id) {
    navigate(`/audiobook/${id}`);
  }

  useEffect(() => {
    api.get("/Book/detailed/")
      .then(response => setAudioBook(response.data))
      .catch(err => console.log(err))
  }, []);

  return (
    <>
      <Header headerBoxShadow={false} />

      <main className={`${styles.home} main main-pd-bottom`}>
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
          <section className={styles.home__audiobooks}>
            <div className={styles.audiobooks__container}>
              <h2>ÁudioBooks</h2>

              <ul className={`${styles.audiobooks__list} display-grid`}>
                {audioBook.map((adbk) => (
                  <AudioBook
                    key={adbk.id}
                    id={adbk.id}
                    name={adbk.title}
                    audioBookCover={adbk.bookImage}
                    parentalRating={adbk.parentalRating}
                    onOpenAudioBook={openAudioBook}
                  />
                ))}
              </ul>
            </div>
          </section>

          {/* <AudioBookCarousel /> */}
        </div>
      </main>

      <Footer />
    </>
  )
}
