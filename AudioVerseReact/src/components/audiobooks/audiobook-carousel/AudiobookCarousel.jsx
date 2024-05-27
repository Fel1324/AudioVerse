import { ChevronLeft } from "../../icons/ChevronLeft.jsx";
import { ChevronRight } from "../../icons/ChevronRight.jsx";
import { Audiobook } from "../audiobook/Audiobook.jsx";

import { audiobooks } from "../../../data/audiobooks.js";
import styles from "./AudiobookCarousel.module.css"
import { useEffect, useState } from "react";

export function AudiobookCarousel() {
  const [audiobook, setAudiobook] = useState([]);

  useEffect(() => {
    setAudiobook(audiobooks);
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
            audiobook.map((adbk) => {
              return (
                <Audiobook
                  key={adbk.id}
                  id={adbk.id}
                  audiobookCover={adbk.audiobookCover}
                />
              )
            })
          }
        </ul>
      </div>
    </section>
  )
}
