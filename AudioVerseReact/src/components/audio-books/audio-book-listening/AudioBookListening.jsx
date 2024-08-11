import { useEffect, useRef, useState } from "react";

import { Prev } from "../../icons/Prev";
import { Play } from "../../icons/Play";
import { Pause } from "../../icons/Pause";
import { Next } from "../../icons/Next";
import { VolumeX } from "../../icons/VolumeX";
import { Volume } from "../../icons/Volume";
import { Volume1 } from "../../icons/Volume1";
import { Volume2 } from "../../icons/Volume2";

import styles from "./AudioBookListening.module.css";

export function AudioBookListening({name, author, chapters = []}){
  const audioRef = useRef(null);
  const [volume, setVolume] = useState(25);
  const [progress, setProgress] = useState(0);
  const [currentChapter, setCurrentChapter] = useState(0);
  const [isPlaying, setIsPlaying] = useState(false);
  
  useEffect(() => {
    if(audioRef.current){
      audioRef.current.play();
      setIsPlaying(true);
    }
  }, [audioRef.current, currentChapter])

  function goToNextChapter(){
    if(currentChapter === chapters.length - 1){
      setCurrentChapter(0);
      return;
    }
    setCurrentChapter(currentChapter + 1);
  }

  function backToPrevChapter(){
    if(currentChapter === 0){
      setCurrentChapter(chapters.length - 1);
      return;
    }
    setCurrentChapter(currentChapter - 1);
  }

  function pauseOrPlayAudioBook(){
    if(isPlaying){
      audioRef.current.pause();
      setIsPlaying(false);

    } else {
      audioRef.current.play();
      setIsPlaying(true);
    }
  }

  // function updateDuration(){

  // }

  function changeProgress(e){
    const progressValue = Number(e.target.value);
    setProgress(progressValue);
  }
  
  function changeVolume(e){
    const volumeValue = Number(e.target.value);
    setVolume(volumeValue);
  }

  function renderVolumeIcon(){
    if(volume === 0) return <VolumeX />
    if(volume < 25) return <Volume />
    if(volume < 65) return <Volume1 />
    return <Volume2 />
  }

  function removeSound(){
    volume != 0 ? setVolume(0) : setVolume(50);
  }

  return (
    <aside className={styles.listening}>
      <audio className={styles.audioRef} src={chapters[currentChapter].source} controls ref={audioRef}></audio>

      <div className={styles.infos}>
        <span title={name}>{name}</span>
        <cite>{author}</cite>
      </div>

      <div className={styles.controls}>
        <span className={styles.nameChapter}>{chapters[currentChapter].name}</span>

        <div className={styles.progress}>
          <span>0:00</span>

          <input
            onChange={changeProgress}
            className={styles.progressBar}
            type="range"
            name="progress"
            id="progress"
            value={progress}
          />

          <span>{chapters[currentChapter].duration}</span>
        </div>

        <div className={styles.buttons}>
          <button type="button" onClick={backToPrevChapter}>
            <Prev />
          </button>

          <button type="button" onClick={pauseOrPlayAudioBook}>
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