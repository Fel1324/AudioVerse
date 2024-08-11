import { useEffect, useState } from "react";
import { useAudioPlayer } from "../../../hooks/useAudioPlayer";

import { Prev } from "../../icons/Prev";
import { Play } from "../../icons/Play";
import { Pause } from "../../icons/Pause";
import { Next } from "../../icons/Next";
import { VolumeX } from "../../icons/VolumeX";
import { Volume } from "../../icons/Volume";
import { Volume1 } from "../../icons/Volume1";
import { Volume2 } from "../../icons/Volume2";

import styles from "./AudioBookListening.module.css";

export function AudioBookListening({ chapters = [] }) {
  const { 
    audioRef,
    formattedDuration,
    formattedCurrentTime,
    play,
    isPlaying,
    togglePlay 
  } = useAudioPlayer()

  const [volume, setVolume] = useState(25);
  const [progress, setProgress] = useState(0);
  const [currentChapter, setCurrentChapter] = useState(0);

  useEffect(() => {
    play()
  }, [audioRef.current, currentChapter])

  function goToNextChapter() {
    audioRef.current.currentTime = 0
    if (currentChapter === chapters.length - 1) {
      setCurrentChapter(0);
      return;
    }
    setCurrentChapter(currentChapter + 1);
  }

  function backToPrevChapter() {
    audioRef.current.currentTime = 0
    if (currentChapter === 0) {
      setCurrentChapter(chapters.length - 1);
      return;
    }
    setCurrentChapter(currentChapter - 1);
  }

  function changeProgress(e) {
    const progressValue = Number(e.target.value);
    setProgress(progressValue);
  }

  function changeVolume(e) {
    const volumeValue = Number(e.target.value);
    setVolume(volumeValue);
  }

  function renderVolumeIcon() {
    if (volume === 0) return <VolumeX />
    if (volume < 25) return <Volume />
    if (volume < 65) return <Volume1 />
    return <Volume2 />
  }

  function removeSound() {
    volume != 0 ? setVolume(0) : setVolume(50);
  }

  return (
    <aside className={styles.listening}>
      <audio
        className={styles.audioRef}
        src={chapters[currentChapter].source}
        controls
        ref={audioRef}>
      </audio>

      <div className={styles.infos}>
        <span title={chapters[currentChapter].name}>{chapters[currentChapter].name}</span>
        <cite>lido por: <strong>{chapters[currentChapter].reader}</strong></cite>
      </div>

      <div className={styles.controls}>
        <div className={styles.progress}>
          <span>{formattedCurrentTime}</span>

          <input
            onChange={changeProgress}
            className={styles.progressBar}
            type="range"
            name="progress"
            id="progress"
            value={progress}
          />

          <span>{formattedDuration}</span>
        </div>

        <div className={styles.buttons}>
          <button type="button" onClick={backToPrevChapter}>
            <Prev />
          </button>

          <button type="button" onClick={togglePlay}>
            {isPlaying ? <Pause /> : <Play />}
          </button>

          <button type="button" onClick={goToNextChapter}>
            <Next />
          </button>
        </div>
      </div>

      <div className={styles.volume}>
        <button onClick={removeSound} type="button">
          {renderVolumeIcon()}
        </button>
        <input
          onChange={changeVolume}
          className={styles.volumeBar}
          type="range"
          name="volume"
          id="volume"
          value={volume}
        />
      </div>
    </aside>
  )
}