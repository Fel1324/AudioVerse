import { useEffect, useState } from "react";

import { Header } from "../../components/header/Header.jsx";
import { Footer } from "../../components/footer/Footer.jsx";
import { Book } from "../../components/book/Book.jsx";
import { BookFilter } from "../../components/book-filter/BookFilter.jsx";
import { Star } from "../../components/icons/Star.jsx";
import { OpenBook } from "../../components/icons/OpenBook.jsx";
import { HeadPhones } from "../../components/icons/HeadPhones.jsx";

import styles from "./Home.module.css";

export function Home(){
  const audiobooks = [
    {
      id: 1,
      name: "Dom casmurro",
      bookCover: "https://ia801802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_2102.jpg",
      author: "Machado de Assis",
      synopsis: "Dom Casmurro é um dos mais famosos romances escritos por Machado de Assis, publicado em 1899. Ele conta a história de Bento Santiago, o narrador da história que, como em uma autobiografia, se compõe de relatos desde sua mocidade até os dias em que está escrevendo o livro. Entre esses dois momentos, Bento escreve sobre suas reminiscências da juventude, sua vida no seminário, seu caso com Capitu e o ciúme desse relacionamento, que se torna o enredo central da trama. - Resumo escrito por Leni",
      parentalRating: 15
    },
    {
      id: 2,
      name: "Senhora",
      bookCover: "https://ia800204.us.archive.org/32/items/LibrivoxCdCoverArt20/Senhora_1206.jpg",
      author: "José de Alencar",
      synopsis: "Senhora é um dos mais importantes clássicos da literatura brasileira, e o terceiro livro do mesmo autor que analisa a situação da mulher na sociedade brasileira do século XIX. Através da história de amor e separação entre Aurélia e Fernando, o autor critica a decadência da elite cortesã, a importância dada ao dinheiro e os casamentos por interesse. O romance, dividido em quatro partes, reflete este objetivo em sua própria estrutura, em que imita uma transação comercial: preço, quitação, posse, resgate.",
      parentalRating: 15
    },
    {
      id: 3,
      name: "Senhora",
      bookCover: "https://ia800204.us.archive.org/32/items/LibrivoxCdCoverArt20/Senhora_1206.jpg",
      author: "José de Alencar",
      synopsis: "Senhora é um dos mais importantes clássicos da literatura brasileira, e o terceiro livro do mesmo autor que analisa a situação da mulher na sociedade brasileira do século XIX. Através da história de amor e separação entre Aurélia e Fernando, o autor critica a decadência da elite cortesã, a importância dada ao dinheiro e os casamentos por interesse. O romance, dividido em quatro partes, reflete este objetivo em sua própria estrutura, em que imita uma transação comercial: preço, quitação, posse, resgate.",
      parentalRating: 15
    },
    {
      id: 4,
      name: "Dom casmurro",
      bookCover: "https://ia801802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_2102.jpg",
      author: "Machado de Assis",
      synopsis: "Dom Casmurro é um dos mais famosos romances escritos por Machado de Assis, publicado em 1899. Ele conta a história de Bento Santiago, o narrador da história que, como em uma autobiografia, se compõe de relatos desde sua mocidade até os dias em que está escrevendo o livro. Entre esses dois momentos, Bento escreve sobre suas reminiscências da juventude, sua vida no seminário, seu caso com Capitu e o ciúme desse relacionamento, que se torna o enredo central da trama. - Resumo escrito por Leni",
      parentalRating: 15
    },
    {
      id: 5,
      name: "Dom casmurro",
      bookCover: "https://ia801802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_2102.jpg",
      author: "Machado de Assis",
      synopsis: "Dom Casmurro é um dos mais famosos romances escritos por Machado de Assis, publicado em 1899. Ele conta a história de Bento Santiago, o narrador da história que, como em uma autobiografia, se compõe de relatos desde sua mocidade até os dias em que está escrevendo o livro. Entre esses dois momentos, Bento escreve sobre suas reminiscências da juventude, sua vida no seminário, seu caso com Capitu e o ciúme desse relacionamento, que se torna o enredo central da trama. - Resumo escrito por Leni",
      parentalRating: 15
    },
    {
      id: 6,
      name: "Senhora",
      bookCover: "https://ia800204.us.archive.org/32/items/LibrivoxCdCoverArt20/Senhora_1206.jpg",
      author: "José de Alencar",
      synopsis: "Senhora é um dos mais importantes clássicos da literatura brasileira, e o terceiro livro do mesmo autor que analisa a situação da mulher na sociedade brasileira do século XIX. Através da história de amor e separação entre Aurélia e Fernando, o autor critica a decadência da elite cortesã, a importância dada ao dinheiro e os casamentos por interesse. O romance, dividido em quatro partes, reflete este objetivo em sua própria estrutura, em que imita uma transação comercial: preço, quitação, posse, resgate.",
      parentalRating: 15
    }
  ];

  const [audiobook, setAudiobook] = useState([]);

  useEffect(() => {
    setAudiobook(audiobooks);
  }, [])

  return (
    <>
      <Header />

      <main className={`${styles.home} main`}>
        <section className={styles.home__banner}>
          <div className={styles.banner__container}>
            <h1>O melhor da literatura nacional em forma de áudio</h1>
            <div>
              <OpenBook />
            </div>
          </div>
        </section>

        <div className={`${styles.home__container} container`}>
          <div className={styles.home__filter}>
            <BookFilter name="Gênero" />
            <BookFilter name="Autor" />
          </div>

          <section className={styles.home__audiobooks}>
            <div className={styles.audiobooks__container}>
              <h2>
                ÁudioBooks
                <Star />
              </h2>

              <ul className={styles.audiobooks__list}>
                {
                  audiobook.map((adbk) => {
                    return(
                      <Book
                        key={adbk.id}
                        id={adbk.id}
                        bookCover={adbk.bookCover}
                      />
                    )
                  })
                }
              </ul>

              <button className={styles.audiobooks__listenMore}>
                <div className={styles.listenMore__line} />
                <span>
                  Ouvir mais
                  <HeadPhones />
                </span>
                <div className={styles.listenMore__line} />
              </button>
            </div>
          </section>
        </div>
      </main>

      <Footer />
    </>
  )
}
