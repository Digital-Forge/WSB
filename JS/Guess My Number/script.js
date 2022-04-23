'use strict';

let number = 0;
let score = 20;

document.querySelector('.again').addEventListener('click', function () {
    number = Math.trunc(Math.random() * 20) + 1;
    score = 20;

    document.querySelector(".number").textContent = '?';
    document.querySelector('.score').textContent = score;
    document.querySelector('.message').textContent = "Start guessing...";

    document.querySelector('body').style.backgroundColor = '#222';

})

document.querySelector('.check').addEventListener('click', function () {
    const guess = Number(document.querySelector('.guess').value);
    console.log(guess, typeof guess);

    if (!guess) {
        document.querySelector('.message').textContent = '🛑 Please input number value';
    }
    else if (guess === number) {
        if (score > 0) {
            document.querySelector('.message').textContent = "👍 Victory";
            document.querySelector('.score').textContent = score;
            document.querySelector('body').style.backgroundColor = "green";
            document.querySelector(".number").textContent = number;

            if (score > Number(document.querySelector('.highscore').textContent)) {
                document.querySelector('.highscore').textContent = score;
            }
        }
        else {
            document.querySelector('.message').textContent = "💫 GAME OVER";
            document.querySelector('.score').textContent = 0;
        }
    }
    else {
        if (score > 0) {
            document.querySelector('.message').textContent = `${guess < number ? 'To low...' : 'To high...'}`;
            score--;
            document.querySelector('.score').textContent = score;
        }
        else {
            document.querySelector('.message').textContent = "💫 GAME OVER";
            document.querySelector('.score').textContent = 0;
        }
    }
})

document.querySelector('.again').click();