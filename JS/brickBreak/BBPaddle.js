  //constructor to make the player paddle
  function Paddle(xPos, yPos, pLength, thickness, speed){
    var self = this;
    self.id = null;
    self.position = {x: xPos, y: yPos};
    self.direction = 0;
    self.lastX = self.position.x;
    self.speed = speed;
    self.pLength = pLength;
    self.thickness = thickness;
    self.setDirection = function(e){
        self.lastX = e.clientX - self.pLength/2;
    }
    self.setPosition = function(){
      //console.log(self.position);
        if (self.lastX >= self.position.x + 10 ^ self.lastX <= self.position.x - 10){
            if (self.lastX > self.position.x){
                self.position.x += self.speed;
            } else if (self.lastX < self.position.x){
                self.position.x -= self.speed;
            } 
        }; 
        console.log(self.lastX, self.position.x);
    }
    self.getPosition = function(){
      return [self.position.x, self.position.y];
    }
    self.draw = function(){
      //console.log('draw player');
      ctx.fillStyle = '#468ade'
      ctx.fillRect(self.position.x, self.position.y, self.pLength, self.thickness);
    }
    self.update = function(){
        self.setPosition();
    }

  }
