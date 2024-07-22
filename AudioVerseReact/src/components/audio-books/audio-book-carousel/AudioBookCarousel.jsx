import { useEffect, useState } from "react";
import { ChevronLeft } from "../../icons/ChevronLeft.jsx";
import { ChevronRight } from "../../icons/ChevronRight.jsx";
import { AudioBook } from "../audiobook/AudioBook.jsx";

import { audioBooks } from "../../../data/audioBooks.js";
import styles from "./AudioBookCarousel.module.css";

export function AudioBookCarousel() {
  const [audioBook, setAudioBook] = useState([]);

  useEffect(() => {
    setAudioBook(audioBooks);
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
                audiobookCover={adbk.audiobookCover}
              />
            ))
          }
        </ul>
      </div>
    </section>
  )
}
