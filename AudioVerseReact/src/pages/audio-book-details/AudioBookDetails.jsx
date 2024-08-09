import { useEffect, useState } from "react";
import { useParams } from "react-router-dom"

import { Header } from "../../components/layout/header/Header.jsx";
import { AudioBookListening } from "../../components/audio-books/audio-book-listening/AudioBookListening.jsx";
import { Footer } from "../../components/layout/footer/Footer.jsx"
import { AudioBook } from "../../components/audio-books/audio-book/AudioBook.jsx";

import { api } from "../../lib/axios.js";
import styles from "./AudioBookDetails.module.css";

export function AudioBookDetails() {
  const { audioBookId } = useParams();
  const [audioBooks, setAudioBooks] = useState([]);
  const [isListening, setIsListening] = useState(false);

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

  function listenAudioBook(){
    isListening ? setIsListening(false) : setIsListening(true);
  }

  return (
    <>
      <Header />

      <main className={`${styles.details} main`}>
        <div className={`${styles.details__container} container`}>
          <div>
            <div className={styles.col_b__row_a}>
              <h1 className={styles.details__name}>{audioBooks.name}</h1>
              <cite className={styles.details__author}>{audioBooks.author}</cite>
            </div>
            
            <div className={styles.col_a}>
              <AudioBook
                audioBookCover={audioBooks.audioBookCover}
                parentalRating={audioBooks.parentalRating}
                alternativeStyle
              />
            </div>

            <div className={styles.col_b__row_b}>
              <p className={`${styles.details__synopsis} paragraph`}>{audioBooks.synopsis}</p>
              <button onClick={listenAudioBook} className={styles.details__listen}>
                {isListening ? "Cancelar" : "Ouvir"}
              </button>
              <a className={`${styles.details__download} link`} href="#">Download.pdf</a>
            </div>
          </div>

          <section className={styles.details__chapters}>
            <h2 className={styles.chapters__title}>Capítulos</h2>
          </section>
        </div>
      </main>

      {isListening && <AudioBookListening name={audioBooks.name} author={audioBooks.author} />}
      
      <Footer />
    </>
  )
}
