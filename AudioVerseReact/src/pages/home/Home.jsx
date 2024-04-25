import { useEffect, useState } from "react";
import { ChevronDown } from "lucide-react";

import { Header } from "../../components/header/Header.jsx";
import { Book } from "../../components/book/Book.jsx";
import { Footer } from "../../components/footer/Footer.jsx"; 

import styles from "./Home.module.css";

export function Home(){
  const [books, setBooks] = useState([]);

  useEffect(() => {
    fetch(`./src/data/books.json`)
      .then(response => response.json())
      .then(data => setBooks(data))

  }, []);

  return (
    <>
      <Header />

      <main className={styles.home}>
        <div className={styles.home__container}>
          <div className={styles.home__filters}>
            <button className={styles.filters__button}>
              <span>Gênero</span>
              <ChevronDown color="var(--second-special-light-color)" />
            </button>
            <button className={styles.filters__button}>
              <span>Autor</span>
              <ChevronDown color="var(--second-special-light-color)" />
            </button>
          </div>

          <div className={styles.home__books}>
            <section className={styles.home__books_section}>
              <h2 className={styles.books_section__title}>Populares</h2>

              <ul className={styles.books_list}>
                {books.map(book => {
                  return (
                    <Book key={book.id} image={book.image} />
                  );
                })}
              </ul>
            </section>

            <section className={styles.home__books_section}>
              <h2 className={styles.books_section__title}>Recentes</h2>

              <ul className={styles.books_list}>
                {books.map(book => {
                    return (
                      <Book key={book.id} image={book.image} />
                    );
                })}
              </ul>
            </section>

            <section className={styles.home__books_section}>
              <h2 className={styles.books_section__title}>Terminar</h2>

              <ul className={styles.books_list}>
                {books.map(book => {
                    return (
                      <Book key={book.id} image={book.image} />
                    );
                })}
              </ul>
            </section>
          </div>
        </div>
      </main>
    
      <Footer />
    </>
  )
}
