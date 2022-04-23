'use strict';

/////////////////////////////////////////////////
/////////////////////////////////////////////////
// BANKIST APP

// Data
const account1 = {
  owner: 'Jonas Schmedtmann',
  movements: [200, 450, -400, 3000, -650, -130, 70, 1300],
  interestRate: 1.2, // %
  pin: 1111,
};

const account2 = {
  owner: 'Jessica Davis',
  movements: [5000, 3400, -150, -790, -3210, -1000, 8500, -30],
  interestRate: 1.5,
  pin: 2222,
};

const account3 = {
  owner: 'Steven Thomas Williams',
  movements: [200, -200, 340, -300, -20, 50, 400, -460],
  interestRate: 0.7,
  pin: 3333,
};

const account4 = {
  owner: 'Sarah Smith',
  movements: [430, 1000, 700, 50, 90],
  interestRate: 1,
  pin: 4444,
};

const accounts = [account1, account2, account3, account4];

// Elements
const labelWelcome = document.querySelector('.welcome');
const labelDate = document.querySelector('.date');
const labelBalance = document.querySelector('.balance__value');
const labelSumIn = document.querySelector('.summary__value--in');
const labelSumOut = document.querySelector('.summary__value--out');
const labelSumInterest = document.querySelector('.summary__value--interest');
const labelTimer = document.querySelector('.timer');

const containerApp = document.querySelector('.app');
const containerMovements = document.querySelector('.movements');

const btnLogin = document.querySelector('.login__btn');
const btnTransfer = document.querySelector('.form__btn--transfer');
const btnLoan = document.querySelector('.form__btn--loan');
const btnClose = document.querySelector('.form__btn--close');
const btnSort = document.querySelector('.btn--sort');

const inputLoginUsername = document.querySelector('.login__input--user');
const inputLoginPin = document.querySelector('.login__input--pin');
const inputTransferTo = document.querySelector('.form__input--to');
const inputTransferAmount = document.querySelector('.form__input--amount');
const inputLoanAmount = document.querySelector('.form__input--loan-amount');
const inputCloseUsername = document.querySelector('.form__input--user');
const inputClosePin = document.querySelector('.form__input--pin');


//const movements = [200, 450, -400, 3000, -650, -130, 70, 1300];

const displayMovements = function (movements) {
  containerMovements.innerHTML = '';
  movements.forEach(function(mov, i) {
    containerMovements.insertAdjacentHTML('afterbegin', `<div class="movements__row">
    <div class="movements__type movements__type--${mov > 0 ? 'deposit' : 'withdrawal'}">${i + 1} ${mov > 0 ? 'deposit' : 'withdrawal'}</div>
    <div class="movements__date">${i + 1} days ago</div>
    <div class="movements__value">${mov}€</div>
  </div>`);
  });
}

const createUserName = function (user){
  return user.toLowerCase().split(' ').reduce((total, character,) => total + character[0], '');
}

const calcDisplayBalance = function(movements){
  labelBalance.textContent = `${movements.reduce((acc, mov) => acc + mov, 0).toFixed(2)} PLN`;
}

const calcDisplaySummary = function(movements, interestRate){
  labelSumIn.textContent = `${movements.filter(x => x > 0).reduce((acc, mov) => acc + mov, 0).toFixed(2)} PLN`;

  labelSumOut.textContent = `${movements.filter(x => x < 0).reduce((acc, mov) => acc + mov, 0).toFixed(2)} PLN`;

  labelSumInterest.textContent = `${movements.filter(x => x > 0).map(deposit => deposit * interestRate / 100).reduce((acc, mov) => acc + mov, 0).toFixed(2)} PLN`;
}

let currentAccount;

btnLogin.addEventListener('click', function(e){
  e.preventDefault();
  currentAccount = accounts.find(acc => createUserName(acc.owner) === inputLoginUsername.value);

  if(currentAccount.pin === Number(inputLoginPin.value)){
    console.log('PIN OK');

    // display UI
    containerApp.style.opacity = 100;

    labelWelcome.textContent = `Welcome back, ${currentAccount.owner.split(' ')[0]}`;

    // display movements
    displayMovements(currentAccount.movements);

    // display balance
    calcDisplayBalance(currentAccount.movements);
    calcDisplaySummary(currentAccount.movements, currentAccount.interestRate);

    inputLoginUsername.value = inputLoginPin.value = '';

  }
  else
    console.log('Inwalid operation');
});

btnTransfer.addEventListener('click', function(e){
  e.preventDefault();
  
  const reciverAccount = account.find(acc => createUserName(acc) === inputTransferTo.value);
  const amount = Number(inputTransferAmount.value);

  if () {
    
  }


  currentAccount.movements.add(-amount);

})





