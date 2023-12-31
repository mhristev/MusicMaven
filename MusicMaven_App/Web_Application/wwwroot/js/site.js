﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
/*
const cardData = [
    {
        image: "images/tyler.jpeg",
        name: "Tyler The Creator",
        score: 8.5,
    },
    {
        image: "images/tyler.jpeg",
        name: "Tyler The Creator",
        score: 8.5,
    },
    {
        image: "images/tyler.jpeg",
        name: "Tyler The Creator",
        score: 8.5,
    },
    {
        image: "images/tyler.jpeg",
        name: "Tyler The Creator",
        score: 8.5,
    },
    {
        image: "images/tyler.jpeg",
        name: "Tyler The Creator",
        score: 8.5,
    },
    {
        image: "images/tyler.jpeg",
        name: "Tyler The Creator",
        score: 8.5,
    },
    {
        image: "images/tyler.jpeg",
        name: "Tyler The Creator",
        score: 8.5,
    },
    {
        image: "images/tyler.jpeg",
        name: "Tyler The Creator",
        score: 8.5,
    },
    {
        image: "images/tyler.jpeg",
        name: "Tyler The Creator",
        score: 8.5,
    },
    {
        image: "images/tyler.jpeg",
        name: "Tyler The Creator",
        score: 8.5,
    },
    {
        image: "images/tyler.jpeg",
        name: "Tyler The Creator",
        score: 8.5,
    },
];

const cardsPerPage = 4;
let numCardsShown = 0;

const cardRow = document.getElementById("card-row");
const seeMoreButton = document.getElementById("see-more");

function createCard(cardData) {
    const card = document.createElement("div");
    card.className = "col-md-auto mb-4";

    const cardInner = document.createElement("div");
    cardInner.className = "card mx-auto";
    card.appendChild(cardInner);

    const cardImage = document.createElement("img");
    cardImage.src = cardData.image;
    cardImage.className = "card-img-top";
    cardImage.alt = cardData.name;
    cardInner.appendChild(cardImage);

    const cardBody = document.createElement("div");
    cardBody.className = "card-body";
    cardInner.appendChild(cardBody);
        
    const cardTitle = document.createElement("h5");
    cardTitle.className = "card-title";
    cardTitle.innerText = cardData.name;
    cardBody.appendChild(cardTitle);

    const cardScore = document.createElement("p");
    cardScore.className = "card-text";
    cardScore.innerText = `Average Score: ${cardData.score}`;
    cardBody.appendChild(cardScore);

    return card;
}

function showMoreCards() {
    const startIndex = numCardsShown;
    const endIndex = numCardsShown + cardsPerPage;

    for (let i = startIndex; i < endIndex && i < cardData.length; i++) {
        const card = createCard(cardData[i]);
        cardRow.appendChild(card);
    }

    numCardsShown = endIndex;

    if (numCardsShown >= cardData.length) {
        seeMoreButton.style.display = "none";
    }
}

showMoreCards();
seeMoreButton.addEventListener("click", showMoreCards);

const paragraph = document.querySelector("#long-text");

const maxChars = 1500;

const fullText = paragraph.textContent;

if (fullText.length > maxChars) {
    const truncatedText = fullText.slice(0, maxChars) + "...";

    paragraph.textContent = truncatedText;

    const seeMoreButton = document.createElement("button");
    seeMoreButton.textContent = "See more";
    seeMoreButton.style.cssText =
        "display: block; margin: auto; text-align: center; text-transform: uppercase; color: #fff; text-decoration: none; font-weight: bold; transition: 0.5s max-width ease;background-color: #6e00a0; max-width: 34%; border-radius: 0px 0px 46px 46px";

    seeMoreButton.addEventListener("click", () => {
        paragraph.textContent = fullText;
        seeMoreButton.remove();
    });

    paragraph.insertAdjacentElement("afterend", seeMoreButton);
}
*/