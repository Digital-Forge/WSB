'use strict';
// Selecting elements
const totalScoreV = [
    document.getElementById('score--0'),
    document.getElementById('score--1')
];

const scoreV = [
    document.getElementById('current--0'),
    document.getElementById('current--1')
];

const View = [
    document.querySelector('.player--0'),
    document.querySelector('.player--1')
];

const diceV = document.querySelector('.dice');

const btnNew = document.querySelector('.btn--new');
const btnRoll = document.querySelector('.btn--roll');
const btnHold = document.querySelector('.btn--hold');

//additional variables
let player = 0;
let totalScore = [0,0];
let buffScore = 0;

// Rolling dice functionality
//btnRoll
btnRoll.addEventListener('click', function(){
    let sc = Math.trunc(Math.random() * 6) + 1;
    console.log(sc);

    diceV.src = `dice-${sc}.png`;
    diceV.classList.remove('hidden');

    if (sc == 1)
    {
        btnRoll.classList.add('hidden');
        buffScore = 0;
        scoreV[player].textContent = buffScore;
    }
    else
    { 
        buffScore += sc;
        scoreV[player].textContent = buffScore;

        if (buffScore + totalScore[player] > 100)
        {
            btnRoll.classList.add('hidden');
            btnHold.classList.add('hidden');
            View[player].classList.add('player--winner')

            alert(`Wygrał player${player + 1}`)
        }
    }
})

//btnHold
btnHold.addEventListener('click', function(){
    totalScore[player] += buffScore;
    totalScoreV[player].textContent = totalScore[player];
    buffScore = 0;
    scoreV[player].textContent = 0;

    player = player == 0 ? 1 : 0;
    View[0].classList.toggle('player--active');
    View[1].classList.toggle('player--active');

    btnRoll.classList.remove('hidden');
    diceV.classList.add('hidden');
})

//btnNew
btnNew.addEventListener('click', function(){
    player = 0;
    totalScore = [0,0];
    buffScore = 0;
    diceV.classList.add('hidden');
    scoreV[0].textContent = 0;
    scoreV[1].textContent = 0;
    totalScoreV[0].textContent = 0;
    totalScoreV[1].textContent = 0;
    View[0].classList.remove('player--winner');
    View[1].classList.remove('player--winner');    
    View[0].classList.remove('player--active');
    View[1].classList.remove('player--active');
    View[0].classList.add('player--active');
    btnRoll.classList.remove('hidden');
    btnHold.classList.remove('hidden');
})

// Starting conditions
btnNew.dispatchEvent(new Event('click'));