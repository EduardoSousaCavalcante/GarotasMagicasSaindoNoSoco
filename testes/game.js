const canvas = document.getElementById("gameCanvas");
const ctx = canvas.getContext("2d");

const WIDTH = canvas.width;
const HEIGHT = canvas.height;

let keys = {};
let direction = "idle"; // "right", "left", "idle"

// Posição do personagem
let x = WIDTH / 2;
let y = HEIGHT - 150;
let speed = 3;

// Carregar os sprites
const spriteIdle = new Image();
spriteIdle.src = "assets/parado.png"; // Imagem do personagem parado

// Carregar os frames dos sprites de movimento
const spriteRight1 = new Image();
spriteRight1.src = "assets/andando_direita/frame1.png"; // Primeiro frame do movimento para a direita
const spriteRight2 = new Image();
spriteRight2.src = "assets/andando_direita/frame2.png"; // Segundo frame do movimento para a direita

const spriteLeft1 = new Image();
spriteLeft1.src = "assets/andando_esquerda/frame1.png"; // Primeiro frame do movimento para a esquerda
const spriteLeft2 = new Image();
spriteLeft2.src = "assets/andando_esquerda/frame2.png"; // Segundo frame do movimento para a esquerda

// Controle de animação
let frame = 0;
let frameRate = 10; // Taxa de frames por segundo

// Eventos de teclado
window.addEventListener("keydown", (e) => keys[e.key] = true);
window.addEventListener("keyup", (e) => keys[e.key] = false);

// Loop principal
function gameLoop() {
  ctx.clearRect(0, 0, WIDTH, HEIGHT);

  // Movimento
  if (keys["ArrowRight"]) {
    x += speed;
    direction = "right";
  } else if (keys["ArrowLeft"]) {
    x -= speed;
    direction = "left";
  } else {
    direction = "idle";
  }

  // Desenha o personagem
  drawCharacter();

  // Atualiza a animação a cada frame
  frame++;
  requestAnimationFrame(gameLoop);
}

function drawCharacter() {
  let currentFrame;

  if (direction === "right") {
    // Alterna entre os frames da animação para a direita
    currentFrame = Math.floor(frame / frameRate) % 2; // Alterna entre frame1 e frame2
    if (currentFrame === 0) {
      ctx.drawImage(spriteRight1, x, y, 80, 100); // Desenha o primeiro frame
    } else {
      ctx.drawImage(spriteRight2, x, y, 80, 100); // Desenha o segundo frame
    }
  } else if (direction === "left") {
    // Alterna entre os frames da animação para a esquerda
    currentFrame = Math.floor(frame / frameRate) % 2; // Alterna entre frame1 e frame2
    if (currentFrame === 0) {
      ctx.drawImage(spriteLeft1, x, y, 80, 100); // Desenha o primeiro frame
    } else {
      ctx.drawImage(spriteLeft2, x, y, 80, 100); // Desenha o segundo frame
    }
  } else {
    ctx.drawImage(spriteIdle, x, y, 80, 100); // Desenha o sprite parado
  }
}

gameLoop();
