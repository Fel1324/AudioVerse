import { useEffect, useState } from "react";
import { useParams } from "react-router-dom"

import { Header } from "../../components/layout/header/Header.jsx";
import { AudioBookListening } from "../../components/audio-books/audio-book-listening/AudioBookListening.jsx";
import { Footer } from "../../components/layout/footer/Footer.jsx"
import { AudioBook } from "../../components/audio-books/audio-book/AudioBook.jsx";
import { AudioBookChapter } from "../../components/audio-books/audio-book-chapter/AudioBookChapter.jsx";

import { api } from "../../lib/axios.js";
import styles from "./AudioBookDetails.module.css";

export function AudioBookDetails() {
  const { audioBookId } = useParams();
  const [audioBook, setAudioBook] = useState({});
  const [isListening, setIsListening] = useState(false);

  function getAudioBookData(id) {
    api.get(`/audiobooks/${id}`)
      .then(response => {
        response.data && setAudioBook(response.data);
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
          <section className={styles.details__audiobook}>
            <div className={styles.col_b__row_a}>
              <h1 className={styles.details__name}>{audioBook.name}</h1>
              <cite className={styles.details__author}>{audioBook.author}</cite>
            </div>
            
            <div className={styles.col_a}>
              <AudioBook
                audioBookCover={audioBook.audioBookCover}
                parentalRating={audioBook.parentalRating}
                alternativeStyle
              />
            </div>

            <div className={styles.col_b__row_b}>
              <p className={`${styles.details__synopsis} paragraph`}>{audioBook.synopsis}</p>
              <button onClick={listenAudioBook} className={styles.details__listen}>
                {isListening ? "Cancelar" : "Ouvir"}
              </button>
              <a className={`${styles.details__download} link`} href={audioBook.pdf} target="_blank">Download.pdf</a>
            </div>
          </section>

          <section className={styles.details__chapters}>
            <h2 className={styles.chapters__title}>Capítulos</h2>

            <div className={styles.chapters__container}>
              <ul className={styles.chapters__list}>
                {audioBook.chapters && (
                  audioBook.chapters.map((chapter) => (
                    <AudioBookChapter
                      key={chapter.name}
                      name={chapter.name}
                      source={chapter.source}
                    />
                  ))
                )}
              </ul>
            </div>
          </section>
        </div>
      </main>
      
      {isListening &&
        <AudioBookListening
          chapters={audioBook.chapters}
        />
      }
      
      <Footer />
    </>
  )
}
