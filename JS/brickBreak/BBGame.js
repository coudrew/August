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
       //console.log(el);
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
    }, 20);
  }
}