var canvas = document.getElementById('canvas');
var ctx = canvas.getContext('2d');





var player = new Paddle(100,400, 100, 50,20);
var game = new Game();
game.appendChild(player);
canvas.onmousemove = player.setDirection;
game.playGame();