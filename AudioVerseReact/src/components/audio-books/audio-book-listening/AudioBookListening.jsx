import { useEffect } from "react";
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

export function AudioBookListening({ chapter, onGoToNextChapter, onBackToNextChapter }) {
  const { 
    audioRef,
    formattedDuration,
    formattedCurrentTime,
    play,
    isPlaying,
    togglePlay,
    duration,
    currentTime,
    jumpToTime,
    removeSound,
    changeVolume,
    volume,
  } = useAudioPlayer();

  useEffect(() => {
    play()
  }, [audioRef.current, chapter]);

  function goToNextChapter() {
    audioRef.current.currentTime = 0
    onGoToNextChapter();
  }

  function backToPrevChapter() {
    audioRef.current.currentTime = 0
    onBackToNextChapter();
  }

  function renderVolumeIcon() {
    if (volume === 0) return <VolumeX />;
    if (volume < 25) return <Volume />;
    if (volume < 65) return <Volume1 />;
    return <Volume2 />;
  }

  useEffect(() => {
    if(duration !== 0 && currentTime === duration){
      goToNextChapter();
    }
  }, [currentTime, duration]);

  return (
    <aside className={styles.listening}>
      <audio
        className={styles.audioRef}
        src={chapter.chapterUrl}
        controls
        ref={audioRef}>
      </audio>

      <div className={styles.infos}>
        <span title={`Capítulos: ${chapter.chapterName}`}>
          Capítulos: {chapter.chapterName}
        </span>
        
        <cite title={`lido por: ${chapter.reader}`}>
          lido por: <strong>{chapter.reader}</strong>
        </cite>
      </div>

      <div className={styles.controls}>
        <div className={styles.progress}>
          <span>{formattedCurrentTime}</span>

          <input
            className={styles.progressBar}
            onChange={e => jumpToTime(Number(e.target.value))}
            type="range"
            name="progress"
            id="progress"
            value={currentTime}
            step={1}
            max={duration}
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
          step={1}
          min={0}
          max={100}
        />
      </div>
    </aside>
  )
}