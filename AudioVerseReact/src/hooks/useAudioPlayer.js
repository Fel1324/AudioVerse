import { useEffect, useRef, useState } from "react";

export const useAudioPlayer = () => {
  const audioRef = useRef(null)
  const [metadata, setMetadata] = useState({
    isPlaying: false,
    duration: 0,
  })
  const [currentTime, setCurrentTime] = useState(0);
  const [volume, setVolume] = useState(50);
  const [isLoading, setIsLoading] = useState(false);

  useEffect(() => {
    const audioEl = audioRef.current;
    if (!audioEl) return;

    const onAudioMetadataLoad = () => {
      setMetadata(prevState => ({
        ...prevState,
        duration: audioEl.duration,
      }))
    }

    const onUpdateTime = () => {
      setCurrentTime(audioEl.currentTime);
    }

    const onAudioBookLoading = () => {
      setIsLoading(true);
    }

    const onAudioBookLoaded = () => {
      setIsLoading(false);
    }

    audioEl.addEventListener("loadedmetadata", onAudioMetadataLoad);
    audioEl.addEventListener("timeupdate", onUpdateTime);
    audioEl.addEventListener("loadstart", onAudioBookLoading);
    audioEl.addEventListener("canplaythrough", onAudioBookLoaded);

    return () => {
      audioEl.removeEventListener("loadedmetadata", onAudioMetadataLoad)
      audioEl.removeEventListener("timeupdate", onUpdateTime);
      audioEl.removeEventListener("loadstart", onAudioBookLoading);
      audioEl.removeEventListener("canplaythrough", onAudioBookLoaded);
    }
  }, [])

  const removeSound = () => {
    audioRef.current.muted = !audioRef.current.muted;
    if(audioRef.current.muted){
      setVolume(0);
      audioRef.current.volume = volume / 100;

    } else {
      setVolume(50);
      audioRef.current.volume = 50 / 100;
    }
  }

  const changeVolume = (e) => {
    const v = Number(e.target.value)
    setVolume(v);
    audioRef.current.volume = v / 100;

    if (v === 0) audioRef.current.muted = true;
    if (v !== 0) audioRef.current.muted = false;
  }

  const play = async () => {
    if (audioRef.current) {
      audioRef.current.volume = volume / 100;
      await audioRef.current.play();
      setMetadata(prevState => ({
        ...prevState,
        isPlaying: true,
      }));
    }
  }

  const pause = () => {
    if (audioRef.current) {
      audioRef.current.pause();
      setMetadata(prevState => ({
        ...prevState,
        isPlaying: false,
      }));
    }
  }

  const togglePlay = async () => {
    if (metadata.isPlaying) {
      pause();
    } else {
      await play();
    }
  }

  const formatZero = (num) => (num < 10 ? "0" + num : num);

  const formatCurrentTime = (time) => {
    const currentMinutes = Math.floor(time / 60);
    const currentSeconds = Math.floor(time % 60);
    return time = currentMinutes + ":" + formatZero(currentSeconds);
  }
  
  const formatDuration = (duration) => {
    const durationFormatted = isNaN(duration) ? 0 : duration;
    const durationMinutes = Math.floor(durationFormatted / 60);
    const durationSeconds = Math.floor(duration % 60);
    return duration = durationMinutes + ":" + formatZero(durationSeconds);
  }

  const jumpToTime = (time) => {
    audioRef.current.currentTime = time;
    setCurrentTime(time);
    play();
  }

  return {
    audioRef,
    duration: metadata.duration,
    currentTime,
    formattedDuration: formatDuration(metadata.duration),
    formattedCurrentTime: formatCurrentTime(currentTime),
    isPlaying: metadata.isPlaying,
    play,
    pause,
    togglePlay,
    jumpToTime,
    removeSound,
    changeVolume,
    volume,
    isLoading,
  }
}
