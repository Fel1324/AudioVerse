import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import { useParams } from "react-router-dom"
import { useMessage } from "../../hooks/useMessage.js";

import { Header } from "../../components/layout/header/Header.jsx";
import { Footer } from "../../components/layout/footer/Footer.jsx"
import { AudioBook } from "../../components/audio-books/audio-book/AudioBook.jsx";
import { AudioBookListening } from "../../components/audio-books/audio-book-listening/AudioBookListening.jsx";
import { AudioBookChapter } from "../../components/audio-books/audio-book-chapter/AudioBookChapter.jsx";
import { ChevronDown } from "../../components/icons/ChevronDown.jsx";
import { Message } from "../../components/layout/message/Message.jsx";

import { api } from "../../lib/axios.js";
import styles from "./AudioBookDetails.module.css";

export function AudioBookDetails() {
  const navigate = useNavigate();
  const { message, setMessage } = useMessage();
  const { audioBookId } = useParams();
  const [audioBook, setAudioBook] = useState({});
  const [isListening, setIsListening] = useState(false);
  const [isChaptersOpen, setIsChaptersOpen] = useState(false);
  const [currentChapter, setCurrentChapter] = useState(0);

  function getAudioBookData(id) {
    api.get(`/Book/detailed/${id}`)
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

  function openChapters(){
    isChaptersOpen ? setIsChaptersOpen(false) : setIsChaptersOpen(true);
  }

  function listenTargetAudioBook(index){
    if(isListening && currentChapter === index){
      setIsListening(false);
    } else {
      setIsListening(true);
      setCurrentChapter(index);
    }
  }

  function onGoToNextChapter(){
    if (currentChapter === audioBook.chapters.length - 1) {
      setCurrentChapter(0);
      return;
    }
    setCurrentChapter(currentChapter + 1);
  }

  function onBackToNextChapter(){
    if (currentChapter === 0) {
      setCurrentChapter(audioBook.chapters.length - 1);
      return;
    }
    setCurrentChapter(currentChapter - 1);
  }

  function filterAudioBook(e){
    e.preventDefault();
    const inputValue = e.target.children[0].value;

    if(inputValue.length > 0){
      api.get(`/Book/detailed/filter/${inputValue}`)
        .then(response => {
          response.data.id ? navigate(`/audiobook/${response.data.id}`) : setMessage(true);;
        })
        .catch(err => console.log(err));
  
      e.target.reset();
    }

    return;
  }

  return (
    <>
      {message && <Message text={"Nenhum resultado encontrado!"} />}

      <Header headerBoxShadow onSubmit={filterAudioBook} />

      <main className={`${styles.details} main`}>
        <div className={`${styles.details__container} container`}>
          <section className={styles.details__audiobook}>
            <div className={styles.col_b__row_a}>
              <div className={styles.details__audiobookheader}>
                <h1 className={styles.details__name}>
                  {audioBook.title}
                  <span className={styles.details__yearpublication}>({audioBook.yearPublication})</span>
                </h1>
              </div>

              <cite className={styles.details__author}>
                {audioBook.authorBooks?.map((at) => at.author.authorName)}
              </cite>

              <div className={styles.details__genre}>
                {audioBook.genreBooks?.map((ge) => {
                  return (
                    <span key={ge.genre.id}>{ge.genre.genreName}</span>
                  )
                })}
              </div>
            </div>
            
            <div className={styles.col_a}>
              <AudioBook
                audioBookCover={audioBook.bookImage}
                parentalRating={audioBook.parentalRating}
                alternativeStyle
              />
            </div>

            <div className={styles.col_b__row_b}>
              <p className={`${styles.details__synopsis} paragraph`}>{audioBook.synopsis}</p>

              <button onClick={listenAudioBook} className={styles.details__listen}>
                {isListening ? "Cancelar" : "Ouvir"}
              </button>

              <a className={`${styles.details__download} link`} href={audioBook.pdfLink} target="_blank">Download.pdf</a>
            </div>
          </section>

          <hr className="line" />

          <section className={styles.details__chapters}>
            <button onClick={openChapters} className={styles.chapters__title}>
              Capítulos
              {isChaptersOpen ? (
                <ChevronDown className={"chevron-up"} />
              ) : (
                <ChevronDown />
              )}
            </button>

            {isChaptersOpen && (
              <div className={styles.chapters__container}>
                <ul className={styles.chapters__list}>
                  {audioBook.chapters && (
                    audioBook.chapters.map((chapter, index) => (
                      <AudioBookChapter
                        key={chapter.id}
                        index={index}
                        name={chapter.chapterName}
                        source={chapter.chapterUrl}
                        onOpenTargetChapter={listenTargetAudioBook}
                        active={isListening && currentChapter === index}
                      />
                    ))
                  )}
                </ul>
              </div>
            )}
          </section>
        </div>
      </main>
      
      {isListening &&
        <AudioBookListening
          chapter={audioBook.chapters[currentChapter]}
          onGoToNextChapter={onGoToNextChapter}
          onBackToNextChapter={onBackToNextChapter}
        />
      }
      
      {isListening ? (
        <Footer className="footer-mg-top" />
      ) : (
        <Footer />
      )}
    </>
  )
}
