import { useEffect, useState } from "react";
import { useParams } from "react-router-dom"

import { Header } from "../../components/layout/header/Header.jsx";
import { Footer } from "../../components/layout/footer/Footer.jsx";
import { AudioBook } from "../../components/audio-books/audio-book/AudioBook.jsx";

import { audioBooks } from "../../data/audioBooks.js";
import styles from "./AudioBookDetails.module.css";

export function AudioBookDetails() {
  const { audioBookId } = useParams();
  const [name, setName] = useState("");
  const [author, setAuthor] = useState("");
  const [audioBookCover, setAudioBookCover] = useState("");
  const [synopsis, setSynopsis] = useState("");

  function getAudioBookData(id) {
    // Faz Get na API

    const audioBook = audioBooks.find((ab) => ab.id === parseInt(id));

    if(audioBook){
      setName(audioBook.name);
      setAuthor(audioBook.author);
      setAudioBookCover(audioBook.audiobookCover);
      setSynopsis(audioBook.synopsis);
    }
  }

  useEffect(() => {
    getAudioBookData(audioBookId);
  }, [audioBookId]);

  return (
    <>
      <Header />

      <main className={`${styles.details} main`}>
        <div className={`${styles.details__container} container`}>
          <h1 className={styles.details__name}>{name}</h1>
          <h4 className={styles.details__author}>{author}</h4>
          
          <AudioBook
            audiobookCover={audioBookCover}
          />

          <p className={`${styles.details__synopsis} paragraph`}>{synopsis}</p>

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
