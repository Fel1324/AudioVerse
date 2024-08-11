import { useEffect, useRef, useState } from "react"

export const useAudioPlayer = () => {
  const audioRef = useRef(null)
  const [metadata, setMetadata] = useState({
    isPlaying: false,
    duration: 0
  })
  const [currentTime, setCurrentTime] = useState(0);

  useEffect(() => {
    const audioEl = audioRef.current
    if (!audioEl) return

    const onAudioMetadataLoad = () => {
      setMetadata(prevState => ({
        ...prevState,
        duration: audioEl.duration
      }))
    }

    const onUpdateTime = () => {
      setCurrentTime(audioEl.currentTime);
    }

    audioEl.addEventListener("loadedmetadata", onAudioMetadataLoad);
    audioEl.addEventListener("timeupdate", onUpdateTime);

    return () => {
      audioEl.removeEventListener("loadedmetadata", onAudioMetadataLoad)
      audioEl.removeEventListener("timeupdate", onUpdateTime);
    }
  }, [])

  const play = async () => {
    if (audioRef.current) {
      await audioRef.current.play();
      setMetadata(prevState => ({
        ...prevState,
        isPlaying: true
      }));
    }
  }

  const pause = () => {
    if (audioRef.current) {
      audioRef.current.pause();
      setMetadata(prevState => ({
        ...prevState,
        isPlaying: false
      }));
    }
  }

  const togglePlay = async () => {
    if (metadata.isPlaying) {
      pause()
    } else {
      await play()
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

  return {
    audioRef,
    duration: metadata.duration,
    formattedDuration: formatDuration(metadata.duration),
    formattedCurrentTime: formatCurrentTime(currentTime),
    isPlaying: metadata.isPlaying,
    play,
    pause,
    togglePlay
  }
}
