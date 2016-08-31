function Scene(){
  var self = this;
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
}