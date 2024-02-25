[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/K3KogrY4)

```mermaid
classDiagram
    class Authors {
        + Primary Key int AuthorID
        + string FirstName
        + string LastName
    }

    class Books {
        + Primary Key int BookID
        + string ISBN
        + string Title
        + string Author
        + string Genre
    }

    class Genres {
        + Primary Key int GenreID
        + string Genre
    }

Authors --> Books : has
Books --> Genres : belongs to

```