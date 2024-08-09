import { useState } from "react";

import { Prev } from "../../icons/Prev";
import { Play } from "../../icons/Play";
import { Pause } from "../../icons/Pause";
import { Next } from "../../icons/Next";
import { VolumeX } from "../../icons/VolumeX";
import { Volume } from "../../icons/Volume";
import { Volume1 } from "../../icons/Volume1";
import { Volume2 } from "../../icons/Volume2";

import styles from "./AudioBookListening.module.css";

export function AudioBookListening({name, author}){
  const [volume, setVolume] = useState(25);
  const [progress, setProgress] = useState(0);

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
      <div className={styles.infos}>
        <span title={name}>{name}</span>
        <cite>{author}</cite>
      </div>

      <div className={styles.controls}>
        <input
          onChange={changeProgress}
          className={styles.progressBar}
          type="range"
          name="progress"
          id="progress"
          value={progress}
        />

        <div>
          <button>
            <Prev />
          </button>
          <button>
            <Play />
          </button>
          <button>
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