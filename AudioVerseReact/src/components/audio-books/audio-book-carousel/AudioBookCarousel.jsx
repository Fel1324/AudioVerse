import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";

import { ChevronLeft } from "../../icons/ChevronLeft.jsx";
import { ChevronRight } from "../../icons/ChevronRight.jsx";
import { AudioBook } from "../audio-book/AudioBook.jsx";

import { api } from "../../../lib/axios.js";
import styles from "./AudioBookCarousel.module.css";

export function AudioBookCarousel() {
  const [audioBook, setAudioBook] = useState([]);
  const navigate = useNavigate();

  function openAudioBook(id) {
    navigate(`/audiobook/${id}`);
  }

  useEffect(() => {
    api.get("/audiobooks")
      .then(response => setAudioBook(response.data))
      .catch(err => console.log(err))
  }, []);

  return (
    <section className={styles.audiobookCarousel}>
      <div className={styles.audiobookCarousel__container}>
        <div className={styles.audiobookCarousel__header}>
          <h2 className={styles.audiobookCarousel__title}>Terminar</h2>
          <div>
            <button>
              <ChevronLeft />
            </button>

            <button>
              <ChevronRight />
            </button>
          </div>
        </div>

        <ul className={`${styles.AudiobookCarousel__list} display-grid`}>
          {
            audioBook.map((adbk) => (
              <AudioBook
                key={adbk.id}
                id={adbk.id}
                name={adbk.name}
                audioBookCover={adbk.audioBookCover}
                parentalRating={adbk.parentalRating}             
                onOpenAudioBook={openAudioBook}   
              />
            ))
          }
        </ul>
      </div>
    </section>
  )
}
