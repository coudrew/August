var canvas = document.getElementById('canvas');
var ctx = canvas.getContext('2d');


//constructor for game
function Game(){
  var self = this;
  //get refernce to canvas dimensions for clear screen
  self.width = document.getElementById('canvas').width;
  self.height = document.getElementById('canvas').height;
  //array of all game objects, functions to add and remove
  self.children = [];
  self.appendChild = function(child){
    child.id = self.children.length;
    self.children.push(child);
  }
  self.removeChild = function(child){
    self.children[child.id] = null;
    self.children.filter(function(el){return el.id !== null});
    self.children.forEach(function(el, i){el.id = i});
  }
  //call update on all child game objects
  self.update = function(){
    self.children.forEach(function(el){
      console.log(el);
      el.update();
    });
    self.renderFrame();
  }
  self.renderFrame = function(){
    //figure self shit out guy
    //clear screen
    ctx.fillStyle = '#000000';
    ctx.fillRect(0, 0, self.width, self.height);
    //iterate through children, draw themselves
    self.children.forEach(function(el){el.draw()});
  }
  self.playGame = function(){
    setInterval(function(){
      self.update();
      self.renderFrame();
    }, 50);
  }
}
  //constructor to make the player paddle
  function Paddle(xPos, yPos, pLength, thickness){
    var self = this;
    self.id = null;
    self.position = {x: xPos, y: yPos};
    self.pLength = pLength;
    self.thickness = thickness;
    self.setPosition = function(e){
      console.log(self.position);
      self.position.x = e.clientX;
      //self.position.y = e.clientY;
    }
    self.getPosition = function(){
      return [self.position.x, self.position.y];
    }
    self.draw = function(){
      console.log('draw player');
      ctx.fillStyle = '#468ade'
      ctx.fillRect(self.position.x, self.position.y, self.pLength, self.thickness);
    }
    self.update = function(){

    }

  }

var player = new Paddle(100,100, 100, 50);
var game = new Game();
canvas.onmousemove = player.setPosition;
