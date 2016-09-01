var canvas = document.getElementById('canvas');
var ctx = canvas.getContext('2d');





var player = new Paddle(100,400, 150, 20,20);
var game = new Game();
game.appendChild(player);
canvas.onmousemove = player.setDirection;
game.playGame();
