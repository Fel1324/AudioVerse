import { useEffect, useState } from "react";
import { useParams } from "react-router-dom"
import { audioBooks } from "../../data/audioBooks.js";

export function AudioBookDetails() {
  const { audioBookId } = useParams();
  const [name, setName] = useState("");
  const [author, setAuthor] = useState("");
  const [synopsis, setSynopsis] = useState("");

  function getAudioBookData(id) {
    // Faz Get na API

    const audioBook = audioBooks.find((ab) => ab.id === parseInt(id));

    if(audioBook){
      setName(audioBook.name);
      setAuthor(audioBook.author);
      setSynopsis(audioBook.synopsis);
    }
  }

  useEffect(() => {
    getAudioBookData(audioBookId);
  }, [audioBookId]);

  return (
    <>
      <h1>{name}</h1>
      <h2>{author}</h2>
      <h3>{synopsis}</h3>
    </>
  )
}
