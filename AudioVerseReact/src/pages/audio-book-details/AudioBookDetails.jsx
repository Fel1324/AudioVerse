import { useEffect, useState } from "react";
import { useParams } from "react-router-dom"

import { Header } from "../../components/layout/header/Header.jsx";
import { Footer } from "../../components/layout/footer/Footer.jsx";
import { AudioBook } from "../../components/audio-books/audio-book/AudioBook.jsx";

import { api } from "../../lib/axios.js";
import styles from "./AudioBookDetails.module.css";

export function AudioBookDetails() {
  const { audioBookId } = useParams();
  const [audioBooks, setAudioBooks] = useState([]);

  function getAudioBookData(id) {
    api.get(`/audiobooks/${id}`)
      .then(response => {
        const audioBook = response.data;
        audioBook && setAudioBooks(audioBook);
      })
      .catch(err => console.log(err))
  }

  useEffect(() => {
    getAudioBookData(audioBookId);
  }, [audioBookId]);

  return (
    <>
      <Header />

      <main className={`${styles.details} main`}>
        <div className={`${styles.details__container} container`}>
          <h1 className={styles.details__name}>{audioBooks.name}</h1>
          <h4 className={styles.details__author}>{audioBooks.author}</h4>
          
          <AudioBook
            audiobookCover={audioBooks.audioBookCover}
          />

          <p className={`${styles.details__synopsis} paragraph`}>{audioBooks.synopsis}</p>

          <button className={styles.details__listen}>Ouvir</button>
          <a className={`${styles.details__download} link`} href="#">Download.pdf</a>

          <section className={styles.details__chapters}>
            <h2 className={styles.chapters__title}>Capítulos</h2>
          </section>
        </div>
      </main>

      <Footer />
    </>
  )
}
