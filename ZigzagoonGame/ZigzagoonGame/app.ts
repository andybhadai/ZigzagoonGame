class Game {

    constructor() {
        this.game = new Phaser.Game(800, 600, Phaser.AUTO, 'content', { preload: this.preload, create: this.create});
    }

    game: Phaser.Game;

    preload() {
    }

    create() {
        var map = this.game.add.tilemap();
        map.addTilesetImage("ground");
        var layer = map.create('default', 400, 400, 32, 32);
        layer.scrollFactorX = 0.50;
        layer.scrollFactorY = 0.50;
        layer.resizeWorld();
        this.game.stage.backgroundColor = "#FFFFFF";
    }
}

interface ITIle {

}

window.onload = () => {
    var game = new Game();
}