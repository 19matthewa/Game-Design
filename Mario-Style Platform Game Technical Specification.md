# **Mario-Style Platform Game Technical Specification**

**Suggestions Received**
* removed data terminal with hacking puzzle
* removed thwomp / CrushBot becasue without animations it would be unfair to character
* edited visuals for enemies to eliminate animations other than movement

## **Technology Stack**

### **Core Technologies**

* Programming Language: JavaScript (ES6+)  
* Rendering: HTML5 Canvas API  
* Frontend: HTML5 and CSS3  
* Input Handling: Native DOM Event Listeners

### **Key Dependencies**

* No external game frameworks or libraries required  
* Pure vanilla JavaScript implementation  
* Browser-native Canvas API for rendering

## **Architecture**

### **Core Components**

## **Game Engine**

* The canvas-based rendering system will handle all visual elements of the game  
* A main game loop will manage update and render cycles for consistent gameplay  
* The frame-based animation system will ensure smooth sprite animations  
* Event-driven input handling will process player controls  
* A comprehensive collision detection system will manage object interactions

## **Game State Management**

* The system will track the current level state and progression  
* Player state management will handle power-ups and abilities  
* Enemy states will be monitored and updated  
* Power-up system will manage active and available power-ups  
* Score tracking will persist across levels  
* Coin collection will be saved across different levels

## **Entity System**

* This Entity System defines the structure and behavior for game entities within a 2D rendering engine using JavaScript  
* Each entity is represented as an object with properties for position, size, visual representation (sprites), and logic for updating and rendering its state  
* The system is designed to be flexible, allowing for efficient handling of entity animations and behaviors

## **Technical Specifications**

### **A. Core Game Systems**

## **Camera System**

* The game world will extend beyond the visible screen  
* Camera will follow the player character, maintaining them in the center of the screen  
* Smooth scrolling will be implemented for fluid level progression  
* Background parallax scrolling will create depth perception

## **Physics System**

* Gravity simulation will be implemented at 0.5 units per frame  
* Velocity-based movement will provide smooth character control  
* Ground collision detection will prevent falling through surfaces  
* Platform collision detection will enable proper jumping mechanics  
* Entity-entity collision detection will manage interactions

## **Input System**

* This Input System captures and tracks user input (keyboard events) to control the player character's actions, including movement, jumping, and shooting  
* It uses event listeners for keydown and keyup to update the state of specific keys and trigger corresponding actions  
* The system also tracks the player's facing direction (lastDirection), which is used to determine the trajectory of actions like shooting

## **Rendering System**

* Double buffering using requestAnimationFrame for smooth animation  
* Layer-based rendering order:  
  * Background/Terrain  
  * Platforms/Pipes  
  * Interactive elements (coins, blocks)  
  * Enemies  
  * Player  
  * UI elements

### **B. Game Objects**

## **Player Character**

The `player` object represents the player character in a game. It has the following properties:

1. `x` and `y`: The player's current position on the x and y axes, respectively. These can be updated to move the player around the game world.  
2. `width` and `height`: The dimensions of the player's hitbox or visual representation. These can be adjusted to change the player's size.  
3. `speed`: The player's horizontal movement speed. Increasing this value will make the player move faster.  
4. `velocityY`: The player's current vertical velocity. This can be modified to control the player's jumping and falling behavior.  
5. `jumpPower`: The force applied when the player jumps. Increasing this value will make the player jump higher.  
6. `gravity`: The acceleration downward due to gravity. Adjusting this value will affect how quickly the player falls.  
7. `grounded`: A boolean indicating whether the player is currently touching the ground. This can be set and checked to determine when the player is able to jump.  
8. `state`: The player's current state, such as "small" or another power-up state. Different states can be added to change the player's abilities, appearance, or behavior.  
9. `health`: The player's current health or number of lives. This can be decreased when the player takes damage and increased when the player collects health items.  
10. `coins`: The number of coins the player has collected. This can be incremented when the player picks up coins.  
11. `fireFlower`: A boolean indicating whether the player has a fire flower power-up. This and other power-ups can be added to give the player new abilities.  
12. `lastDirection`: An integer representing the player's last movement direction (1 for right, \-1 for left). This can be used to determine which way the player is facing.  
13. `invincible`: A boolean indicating whether the player is currently invincible. This can be used to temporarily protect the player from damage.  
14. `invincibilityTimer`: The time remaining in the player's current invincibility period. This can be used to track and manage the player's invincibility.  
15. `invincibilityDuration`: The total duration of the player's invincibility period. This can be adjusted to control how long the player remains invincible.

To add new qualities to the player, you can simply add new properties to the `player` object. For example, you could add a `weapon` property to track the player's current weapon, or a `score` property to track the player's points. You can then update these properties as the player interacts with the game world.

## **Fireball**

The Fireball class represents a projectile fired by the player character, typically when the player has acquired a power-up (such as a fire flower). The fireball travels in the direction the player is facing, and it has basic collision detection capabilities to interact with other objects in the game world. The class includes methods for updating its position, rendering it on the screen, and checking for collisions with other entities.

## **Enemy Types**

* Goomba: Implements basic walking enemy behavior, can be defeated by jumping on top  
* Koopa Troopa: Implements complex state machine with walking, shell, and moving shell states

### **Level Elements (Cyberpunk Naruto Theme)**

1. **Hover Platforms**  
   * Function: Floating platforms that the player can jump on. Some hover in place while others move horizontally or vertically.  
   * Looks: Metallic platforms with neon lights along the edges, pulsating with energy. Some platforms have hovering magnetic fields beneath them.  
2. **Electric Barriers**  
   * Function: Blocks the player's path until disabled by a switch or avoided by careful timing. Contact with the barrier damages the player.  
   * Looks: Transparent force fields with blue or red electric currents running through them, sparking on the edges.  
3. **Magnetic Rails**  
   * Function: Player can attach to these rails, sliding along them or jumping between rails to progress through the level.  
   * Looks: Glowing, blue-tinted magnetic strips embedded in walls or ceilings, with energy pulsating along the rail's length.   
5. **Electric Lifts**  
   * Function: Vertical platforms that the player can ride to different parts of the level. Can be slow or fast-moving, and some are activated by switches.  
   * Looks: Sleek metal platforms with glowing power cores beneath them, with visible electrical sparks running up and down the support poles.  
5. **Neon Sign Hazards**  
   * Function: These neon signs are obstacles that flash erratically, creating damage zones the player must avoid.  
   * Looks: Bright, glitchy holographic signs advertising products or ninja clans, with parts that flicker and spark with electricity when malfunctioning.  
6. **Energy Shields**  
   * Function: Shields protect certain areas or enemies. Players need to deactivate these shields by solving puzzles or hacking terminals.  
   * Looks: Transparent, shimmering force fields with a hexagonal pattern, emitting a low hum and glowing in bright colors like cyan or pink.  
7. **Chakra-Infused Jumps Pads**  
   * Function: Propels the player high into the air to access otherwise unreachable areas.  
   * Looks: High-tech pads with glowing chakra symbols that flare up with energy when stepped on, creating a ripple of blue or purple light.  
8. **Electric Traps**  
   * Function: These traps release bursts of electricity when the player steps near them, requiring timing to pass without taking damage.  
   * Looks: Metal floor or wall-mounted devices with exposed wiring and electric arcs, with warning lights flashing before activating.  
9. **Checkpoint Pylons**  
    * Function: When activated, serves as a respawn point for the player. Can restore some health or energy.  
    * Looks: Tall, sleek pylons with glowing chakra symbols that rotate around the top. When activated, they pulse with a bright light, syncing the player's chakra.

### **Enemy Types (Cyberpunk Naruto Theme)**

1. **Cyber-Grunt**  
   * Mario Bros Equivalent: Goomba  
   * Behavior: Walks forward, turning when hitting an obstacle. Can be defeated with a jump or certain power-ups.  
   * Player Interaction: Player can jump on the enemy to destroy it, causing a small electric burst. Contact damages the player.  
   * Looks: Small, humanoid robots with bright red eyes and armored legs. Their exoskeletons have worn-down metal plates and neon circuits.  
2. **Mecha-Troopa**  
   * Mario Bros Equivalent: Koopa Troopa  
   * Behavior: Walks forward and retracts into a core mode when stomped, becoming a projectile the player can kick.  
   * Player Interaction: Jumping on it retracts it into its shell-like core, which can be kicked to defeat other enemies.  
   * Looks: Robotic ninjas with reinforced armor and retractable metallic wings. The shell mode is a compact, spherical core covered in neon lights.  
3. **Shuriken Bro**  
   * Mario Bros Equivalent: Hammer Bro  
   * Behavior: Throws electric shurikens at the player from platforms while jumping between positions.  
   * Player Interaction: The player can jump on or attack them with projectiles to defeat them, but must avoid the thrown shurikens.  
   * Looks: Futuristic ninja with high-tech body armor and a glowing visor, throwing blue-lined, shurikens charged with electricity.  
4. **Data-Spike Plant**  
   * Mario Bros Equivalent: Piranha Plant  
   * Behavior: Pops out of data terminals to attack, spitting electric spikes in short bursts.  
   * Player Interaction: The player must avoid the spikes and can defeat it with a projectile attack when it's exposed.  
   * Looks: A mechanical plant with metal petals and data cables for vines. Its "spikes" are bright digital data packets.  
5. **Ghost Protocol**  
   * Mario Bros Equivalent: Boo  
   * Behavior: Approaches the player when they aren't looking, stopping when they face it.  
   * Player Interaction: The player must avoid turning their back to it, as it only moves when unseen.  
   * Looks: A glitchy, transparent holographic face with neon lines. The body flickers in and out of view, with on-off patterns.  
6. **Pulse Drone**  
   * Mario Bros Equivalent: Bullet Bill  
   * Behavior: Flies straight at the player from a launcher. Can be destroyed or dodged.  
   * Player Interaction: The player can either dodge or use a power-up to destroy it in mid-air.  
   * Looks: A cylindrical drone with a light blue targeting sensor in the front and jet-powered exhausts in the back.  
7. **Drone Operator**  
   * Mario Bros Equivalent: Lakitu  
   * Behavior: Flies overhead, dropping electro-bombs or electric kunai onto the player.  
   * Player Interaction: The player must dodge the bombs and can defeat the enemy by destroying its hoverboard or with a ranged attack.  
   * Looks: A cyberpunk ninja on a hoverboard, wearing a  suit with a helmet that displays holographic targeting data.  
8. **Shock-Spike**  
   * Mario Bros Equivalent: Spiny  
   * Behavior: Crawls along the ground with electrified spikes, damaging the player on contact.  
   * Player Interaction: The player cannot jump on it, but can use projectiles or certain abilities to defeat it.  
   * Looks: A robotic creature with, eletric spikes, with circuits on its body.  

## **Power-ups**

1. **Plain Armor**  
   * Effects: Grants the player an extra life. When hit, the player loses the armor instead of losing a life.  
   * Description: A simple protective armor that allows the player to take an additional hit without losing a life. It's a standard defense boost that provides safety in dangerous situations.  
   * Visual: The player dons a sleek, metallic armor with a minimalistic design, glowing with faint blue lines indicating energy flowing through it.  
2. **Voltage Cloak**  
   * Effects: Creates an aura around the player that applies a small DoT (damage over time) and slows nearby enemies.  
   * Description: Surrounded by a field of electric energy, the Voltage Cloak zaps any enemy that gets too close, gradually wearing them down and reducing their movement speed.  
   * Visual: The player is surrounded by a shimmering, electrical field that sparks with blue and white lightning arcs, pulsing with energy as enemies approach.  
3. **Default (No Power-Up)**  
   * Effects: The player can stomp on enemies as a default attack, similar to classic Mario mechanics.  
   * Description: Without any power-up, the player relies on their basic abilities, jumping and stomping on enemies to defeat them. This is the player's core form of attack.  
   * Visual: The player's regular appearance without any special enhancements or aura. Basic ninja outfit with minimal tech gear.  
4. **Chakra Blade**  
   * Effects: Close-range damage with a permanent death effect on enemies. When an enemy is defeated with the Chakra Blade, they cannot respawn.  
   * Description: The Chakra Blade is an energy-infused sword that cuts down enemies in one strike, ensuring they won't return. This weapon is ideal for taking down tough enemies that would normally revive.  
   * Visual: A glowing sword with a sleek, cyber-chakra design, radiating with energy. The blade has sharp light trails as it slashes through enemies, leaving a faint afterglow.  
5. **Lightning Bow**  
   * Effects: Provides long-range damage and applies DoT to enemies hit by the arrows.  
   * Description: A powerful long-range weapon, the Lightning Bow shoots electric-charged arrows that continue to deal damage over time, weakening enemies as they try to close in.  
   * Visual: The player wields a high-tech bow with neon blue energy strings, firing arrows that crackle with electricity, leaving electric trails in their wake.  
6. **Shock Kunai**  
   * Effects: No damage, but freezes enemies in place for 1 second.  
   * Description: The Shock Kunai doesn't damage enemies but instead temporarily paralyzes them, giving the player a moment to escape or set up for another attack.  
   * Visual: Small, glowing kunai with electric pulses running along the edges. When thrown, they emit a short electrical burst that briefly locks enemies in place, causing them to glow and spark.  
7. **Rocket Booster**  
   * Effects: Grants the ability to double jump and glide over long distances.  
   * Description: The Rocket Booster gives the player increased mobility, allowing them to perform a second jump in mid-air and glide down slowly, perfect for dodging enemies or reaching difficult platforms.  
   * Visual: Sleek, glowing boosters are attached to the player's back, emitting faint blue jets of energy when jumping, and a small, steady stream when gliding through the air.  
8. **Susanoo (Star Equivalent)**  
   * Effects: Provides temporary invincibility for a short duration, allowing the player to defeat enemies simply by touching them.  
   * Description: The ultimate power-up, Susanoo envelops the player in an invincible chakra form, making them unstoppable for a brief period. During this time, enemies are destroyed on contact.  
   * Visual: The player is surrounded by a massive, glowing Susanoo figure, resembling a cybernetic chakra warrior. The figure is semi-transparent, with bright blue energy radiating from it, and destroys enemies on contact.

## **Security Considerations**

### **Client-Side Security**

* Input validation  
* Frame rate limiting  
* State validation  
* Anti-cheat measures

### **Browser Compatibility**

* Cross-browser event handling  
* Canvas API compatibility  
* Performance optimization for different browsers

## **Future Enhancements**

### **Planned Features**

* Additional enemy types  
* More power-ups  
* Multiple level themes  
* Boss battles  
* Checkpoint system

### **Technical Improvements**

* Sprite-based animation system  
* Enhanced physics simulation  
* Improved collision detection  
* Save state functionality

## **Development Guidelines**

### **Code Organization**

* Modular class structure  
* Clear separation of concerns  
* Consistent naming conventions  
* Comprehensive documentation  
* Regular code reviews

### **Testing Strategy**

* Unit tests for core systems  
* Integration tests for game mechanics  
* Performance benchmarking  
* Cross-browser testing  
* User acceptance testing

# File for reference:

const canvas \= document.getElementById('gameCanvas');

const ctx \= canvas.getContext('2d');

let width \= window.innerWidth;

let height \= window.innerHeight;

canvas.width \= width;

canvas.height \= height;

// Game state flags

let levelComplete \= false;

let gameOver \= false;

// Function to display the "GAME OVER" screen

function displayGameOver() {

   // Clear the canvas with a black background

   ctx.clearRect(0, 0, canvas.width, canvas.height);

   ctx.fillStyle \= 'black';

   ctx.fillRect(0, 0, canvas.width, canvas.height);

   const text \= "GAME OVER\!";

   const fontSize \= 80;

   const letterSpacing \= fontSize \* 1.2; // Increased spacing between letters

   ctx.textAlign \= "center";

   ctx.font \= \`bold ${fontSize}px Arial\`;

   // Calculate total width for centering

   const totalWidth \= letterSpacing \* (text.length \- 1);

   const startX \= (canvas.width \- totalWidth) / 2;

   const y \= canvas.height / 2;

   // 3D effect layers

   const layers \= 12;


   for (let i \= 0; i \< text.length; i\++) {

       const x \= startX \+ (i \* letterSpacing);

      

       // Draw 3D shadow layers

       for (let layer \= layers; layer \> 0; layer\--) {

           const offset \= layer \* 1.5;

           ctx.fillStyle \= \`rgba(0, 0, 0, ${0.7 \- layer/layers})\`;

           ctx.fillText(text\[i\], x, y \+ offset);

       }

       // Main text with gradient

       const gradient \= ctx.createLinearGradient(x, y \- fontSize/2, x, y \+ fontSize/2);

       gradient.addColorStop(0, '\#ff3366');

       gradient.addColorStop(0.5, '\#ff1a1a');

       gradient.addColorStop(1, '\#cc0000');

      

       ctx.fillStyle \= gradient;

       ctx.fillText(text\[i\], x, y);

       // Add highlight effect

       ctx.fillStyle \= 'rgba(255, 255, 255, 0.2)';

       ctx.fillText(text\[i\], x, y \- 2);

   }

   // Add overall text shadow for depth

   ctx.shadowColor \= 'rgba(0, 0, 0, 0.5)';

   ctx.shadowBlur \= 10;

   ctx.shadowOffsetX \= 4;

   ctx.shadowOffsetY \= 4;

   // Reset shadow effect

   ctx.shadowColor \= 'transparent';

   ctx.shadowBlur \= 0;

   ctx.shadowOffsetX \= 0;

   ctx.shadowOffsetY \= 0;

}

// Function to display the "LEVEL COMPLETE" screen

function displayLevelComplete() {

   // Clear the canvas with a white background

   ctx.clearRect(0, 0, canvas.width, canvas.height);

   ctx.fillStyle \= 'white';

   ctx.fillRect(0, 0, canvas.width, canvas.height);

   const text \= "LEVEL COMPLETE";

   const fontSize \= 80;

   const letterSpacing \= fontSize \* 0.8;

   ctx.font \= \`${fontSize}px Arial\`;

   ctx.textAlign \= "center";


   // Calculate total width of text with spacing

   const totalWidth \= letterSpacing \* (text.length \- 1);

   const startX \= (canvas.width \- totalWidth) / 2;

   const y \= canvas.height / 2;

   // Calculate the total number of color steps needed

   const totalSteps \= text.length \* 3; // Multiply by 3 for smoother transition

   for (let i \= 0; i \< text.length; i\++) {

       const x \= startX \+ (i \* letterSpacing);

      

       // Create smoother rainbow transition

       // Map the letter position to a color wheel position

       // Multiply by 3 to make colors flow across multiple letters

       const hue \= ((i \* 3) / totalSteps) \* 360;

      

       // Add shadow effect

       ctx.shadowColor \= 'rgba(0, 0, 0, 0.3)';

       ctx.shadowBlur \= 4;

       ctx.shadowOffsetX \= 2;

       ctx.shadowOffsetY \= 2;

      

       // Create gradient for each letter

       const gradient \= ctx.createLinearGradient(x \- fontSize/4, y \- fontSize/2, x \+ fontSize/4, y \+ fontSize/2);

      

       // Calculate gradient colors that flow into next letter

       const currentHue \= (hue) % 360;

       const nextHue \= (hue \+ 30) % 360; // Blend into next color

      

       gradient.addColorStop(0, \`hsl(${currentHue}, 100%, 50%)\`);

       gradient.addColorStop(1, \`hsl(${nextHue}, 100%, 50%)\`);

      

       ctx.fillStyle \= gradient;

       ctx.fillText(text\[i\], x, y);

   }


   // Reset shadow effect

   ctx.shadowColor \= 'transparent';

   ctx.shadowBlur \= 0;

   ctx.shadowOffsetX \= 0;

   ctx.shadowOffsetY \= 0;

}

// Player character

function initializePlayer() {

   player \= {

       x: 50,

       y: 550,

       width: 50,

       height: 50,

       speed: 5,

       velocityY: 0,

       jumpPower: \-15,

       gravity: 0.5,

       grounded: false,

       state: 'small',

       health: 3,

       coins: 0,

       fireFlower: false,

       lastDirection: 1,

       invincible: false,

       invincibilityTimer: 0,

       invincibilityDuration: 1000

   };

}

initializePlayer();

// Terrain and obstacles

const groundHeight \= 20;

const terrain \= \[\];

const pipes \= \[\];

const platforms \= \[\];

const coins \= \[\];

const questionBlocks \= \[\];

const items \= \[\]; // Array to hold items like power-ups

// Enemies

const enemies \= \[\];

let scale \= Math.min(width / 800, height / 600); // Adjust the scaling for 800x600 base

canvas.style.transform \= \`scale(${scale})\`;       // Apply scale transformation

canvas.style.transformOrigin \= 'top left';

// Function to generate terrain

function generateTerrain(startX \= 0, length \= 800, amplitude \= 50, frequency \= 0.05, isCurved \= true) {

   terrain.length \= 0; // Clear previous terrain

   for (let x \= startX; x \< startX \+ length; x \+= 40) {

       let y;

       if (isCurved) {

           // Generate a sine wave curve for the terrain

           y \= height \- groundHeight \- (Math.sin(x \* frequency) \* amplitude);

       } else {

           // Generate straight terrain at a fixed height (can be adjusted)

           y \= height \- groundHeight \- amplitude; // Flat terrain at height defined by amplitude

       }

       terrain.push({ x: x, y: y, width: 40, height: groundHeight });

   }

}

// Create pipes with specified x and y coordinates

function createPipes(startX \= 0, startY \= height \- 120) {

   pipes.push({ x: startX, y: startY, width: 40, height: 100 }); // Vertical pipe

}

// Create floating platforms with specified x and y coordinates

function createPlatforms(startX \= 0, startY \= height \- 200) {

   platforms.push({ x: startX, y: startY, width: 100, height: 20 });

}

// Create coins with specified x and y coordinates

function createCoins(startX \= 0, startY \= height \- 100) {

   coins.push({ x: startX, y: startY, width: 20, height: 20 });

}

// Create question block with specified x and y coordinates

function createQuestionBlocks(startX \= 0, startY \= height \- 250) {

   questionBlocks.push({ x: startX , y: startY, width: 40, height: 40, hasPowerUp: true });

}

// Create enemies with specified coordinates and type

function createEnemies(startX \= 0, startY \= height \- 60, type \= 'Goomba') {

   if (type \=== 'Goomba') {

       enemies.push(new Goomba(startX, startY));

   } else if (type \=== 'KoopaTroopa') {

       enemies.push(new KoopaTroopa(startX, startY));

   }

}

// Item class

class Item {

   constructor(x, y, type) {

       this.x \= x;

       this.y \= y;

       this.width \= 20;

       this.height \= 20;

       this.type \= type; // 'mushroom' or 'fireFlower'

       this.velocityY \= \-2; // Initial upward velocity

   }

   update() {

       this.y \+= this.velocityY; // Move the item up

       this.velocityY \+= 0.1; // Gravity effect on the item

   }

   render() {

       ctx.fillStyle \= this.type \=== 'mushroom' ? 'red' : 'orange'; // Color based on type

       ctx.fillRect(this.x, this.y, this.width, this.height);

   }

   collect(player) {

       if (this.type \=== 'mushroom') {

           player.state \= 'big'; // Change player state to big

       } else if (this.type \=== 'fireFlower') {

           player.fireFlower \= true; // Grant fire flower ability

       player.canShoot \= true; // Allow shooting fireballs

       }

   }

}

let flagpole \= {

   x: width \- 50, // Position flagpole near the end of the level

   y: height\-500, // 150px tall flagpole

   width: 10,

   height: 500,

   touched: false,

};

// Fireball class

class Fireball {

   constructor(x, y, direction) {

       this.x \= x;

       this.y \= y;

       this.width \= 10;

       this.height \= 10;

       this.speed \= 5; // Slower fireball speed

       this.direction \= direction; // 1 for right, \-1 for left

   }

   update() {

       this.x \+= this.speed \* this.direction; // Move fireball in the direction of last player movement

   }

   render() {

       ctx.fillStyle \= 'orange'; // Fireball color

       ctx.fillRect(this.x, this.y, this.width, this.height);

   }

   collidesWith(other) {

       return (

           this.x \< other.x \+ other.width &&

           this.x \+ this.width \> other.x &&

           this.y \< other.y \+ other.height &&

           this.y \+ this.height \> other.y

       );

   }

}

// Goomba class

class Goomba {

   constructor(x, y) {

       this.x \= x;

       this.y \= y;

       this.width \= 40;

       this.height \= 40;

       this.speed \= 2;

       this.direction \= 1; // 1 for right, \-1 for left

       this.grounded \= true;

   }

   update() {

       // Move back and forth

       this.x \+= this.speed \* this.direction;

       // Change direction if hitting a wall

       if (this.x \<= 0 || this.x \+ this.width \>= width) {

           this.direction \*= \-1;

       }

       // Check collision with player

       if (this.collidesWith(player)) {

           if (\!player.grounded) { // If player jumps on Goomba

               enemies.splice(enemies.indexOf(this), 1); // Remove Goomba

           } else if (\!player.invincible){

               if(player.state \== 'big'){

               player.invincible \= true; // Set invincible flag

               player.invincibilityTimer \= player.invincibilityDuration;

               player.state \= 'small'

               }else{

               player.health \-= 1; // Deal damage to player

               player.invincible \= true; // Set invincible flag

               player.invincibilityTimer \= player.invincibilityDuration;

               player.x \= 50;

               player.y \= 550;

           }}

       }

   }

   collidesWith(other) {

       return (

           this.x \< other.x \+ other.width &&

           this.x \+ this.width \> other.x &&

           this.y \< other.y \+ other.height &&

           this.y \+ this.height \> other.y

       );

   }

   render() {

       ctx.fillStyle \= 'brown'; // Goomba color

       ctx.fillRect(this.x, this.y, this.width, this.height);

   }

}

// Koopa Troopa class

class KoopaTroopa {

   constructor(x, y) {

       this.x \= x;

       this.y \= y;

       this.width \= 40;

       this.height \= 40;

       this.speed \= 2; // Normal walking speed (same as Goomba)

       this.shellSpeed \= 4; // Faster speed when in moving shell form

       this.direction \= 1;

       this.grounded \= true;

       this.state \= 'normal'; // 'normal', 'shell', 'stoppedShell'

       this.stateTimer \= 0;

       this.stateDuration \= 8000; // 10 seconds in shell state

       this.stateTransitionDelay \= 500; // 500ms transition delay

       this.lastStateChange \= 0; // Track when the last state change occurred

   }

   update() {

       const currentTime \= Date.now();

       const timeSinceStateChange \= currentTime \- this.lastStateChange;

      

       // Update position based on current state

       switch (this.state) {

           case 'normal':

               this.x \+= this.speed \* this.direction;

               if (this.x \<= 0 || this.x \+ this.width \>= width) {

                   this.direction \*= \-1;

               }

               break;

           case 'shell':

               this.x \+= this.shellSpeed \* this.direction;

               if (this.x \<= 0 || this.x \+ this.width \>= width) {

                   this.direction \*= \-1;

               }

               break;

           case 'stoppedShell':

               if (currentTime \- this.stateTimer \> this.stateDuration) {

                   this.changeState('normal');

               }

               break;

       }

       // Check collision with player only if we're not in transition period

       if (timeSinceStateChange \> this.stateTransitionDelay && this.collidesWith(player)) {

           if (\!player.grounded) {

               // Player hit Koopa from above

               player.velocityY \= \-8; // Small bounce

              

               switch (this.state) {

                   case 'normal':

                       this.changeState('shell');

                       this.direction \= player.x \< this.x ? 1 : \-1;

                       break;

                   case 'shell':

                       this.changeState('stoppedShell');

                       break;

                   case 'stoppedShell':

                       this.changeState('shell');

                       this.direction \= player.x \< this.x ? 1 : \-1;

                       break;

               }

           } else if (this.state \!== 'stoppedShell' && \!player.invincible) {

               // Player touched dangerous state Koopa

               if (player.state \=== 'big') {

                   player.state \= 'small';

                   player.invincible \= true;

                   player.invincibilityTimer \= player.invincibilityDuration;

               } else {

                   player.health \-= 1;

                   player.invincible \= true;

                   player.invincibilityTimer \= player.invincibilityDuration;

                   player.x \= 50;

                   player.y \= 550;

               }

           }

       }

       // Check for collision with Goomba only when in moving shell state

       if (this.state \=== 'shell' && timeSinceStateChange \> this.stateTransitionDelay) {

           enemies.forEach(enemy \=\> {

               if (enemy instanceof Goomba && this.collidesWith(enemy)) {

                   enemies.splice(enemies.indexOf(enemy), 1);

               }

           });

       }

   }

   changeState(newState) {

       this.state \= newState;

       this.lastStateChange \= Date.now();

       if (newState \=== 'stoppedShell') {

           this.stateTimer \= Date.now();

       }

   }

   collidesWith(other) {

       return (

           this.x \< other.x \+ other.width &&

           this.x \+ this.width \> other.x &&

           this.y \< other.y \+ other.height &&

           this.y \+ this.height \> other.y

       );

   }

   render() {

       const timeSinceStateChange \= Date.now() \- this.lastStateChange;

      

       // Flashing effect during transition

       if (timeSinceStateChange \< this.stateTransitionDelay && Math.floor(timeSinceStateChange / 100) % 2 \=== 0) {

           ctx.fillStyle \= 'white'; // Flash white during transition

       } else {

           // Normal colors based on state

           switch (this.state) {

               case 'normal':

                   ctx.fillStyle \= 'red';

                   break;

               case 'shell':

                   ctx.fillStyle \= 'green';

                   break;

               case 'stoppedShell':

                   ctx.fillStyle \= 'gray';

                   break;

           }

       }

       ctx.fillRect(this.x, this.y, this.width, this.height);

   }

}

   // Clear all game elements

   terrain.length \= 0;

   pipes.length \= 0;

   platforms.length \= 0;

   coins.length \= 0;

   questionBlocks.length \= 0;

   enemies.length \= 0;


   // Reset player

   initializePlayer();


   // Reset flags

   levelComplete \= false;

   gameOver \= false;

   ctx.clearRect(0, 0, canvas.width, canvas.height);

function setupLevel0() {

   // First, create the base terrain with rolling hills

   generateTerrain(0, 3200, 60, 0.02, true); // Make it wider to match the shown level


   // Add pipes at strategic locations

   createPipes(400, height \- 120);  // First pipe

   createPipes(600, height \- 160);  // Taller pipe

   createPipes(2800, height \- 120); // Pipe near end


   // Create platforms for jumping sections

   createPlatforms(800, height \- 200);

   createPlatforms(1000, height \- 180);

   createPlatforms(1200, height \- 160);


   // Add coins in patterns

   // First coin section

   for (let i \= 0; i \< 5; i\++) {

       createCoins(500 \+ (i \* 30), height \- 250);

   }

   // Second coin section

   for (let i \= 0; i \< 3; i\++) {

       createCoins(1000 \+ (i \* 30), height \- 300);

   }


   // Add question blocks

   createQuestionBlocks(300, height \- 250);

   createQuestionBlocks(900, height \- 250);

   createQuestionBlocks(1500, height \- 250);


   // Add enemies

   createEnemies(500, height \- 60, 'Goomba');

   createEnemies(800, height \- 60, 'KoopaTroopa');

   createEnemies(1200, height \- 60, 'Goomba');


   // Create underground sections (assuming we have a method for this)

   // You might need to add additional methods to create the underground rooms

   // shown in the image with their specific block patterns


   // Add floating platforms in ascending pattern

   for (let i \= 0; i \< 4; i\++) {

       createPlatforms(1600 \+ (i \* 150), height \- (200 \+ i \* 40));

   }

}

function setupLevel1() {

   // Create flat terrain for underground base

   generateTerrain(0, 3200, 0, 0, false); // Use flat terrain for underground


   // Set up main tunnel structure with platforms

   // Left side entrance area

   createPlatforms(0, height \- 200, 200, 20);


   // Create vertical pipes for transportation

   createPipes(200, height \- 300); // Entrance pipe

   createPipes(800, height \- 400); // Middle section pipe

   createPipes(1600, height \- 350); // Exit area pipe

   createPipes(2400, height \- 300); // Final pipe


   // Create horizontal pipes for obstacles

   createPipes(400, height \- 150);

   createPipes(1000, height \- 200);

   createPipes(1800, height \- 180);


   // Add platforms for traversal

   // First section platforms

   createPlatforms(300, height \- 250);

   createPlatforms(500, height \- 300);

   createPlatforms(700, height \- 350);

   createPlatforms(500, height \- 150);


   // Middle section platforms

   for (let i \= 0; i \< 3; i\++) {

       createPlatforms(1000 \+ (i \* 200), height \- 280);

   }


   // Create coin patterns

   // Coin trail leading up

   for (let i \= 0; i \< 5; i\++) {

       createCoins(600 \+ (i \* 30), height \- (200 \+ i \* 30));

   }


   // Coin clusters in open areas

   for (let i \= 0; i \< 3; i\++) {

       for (let j \= 0; j \< 3; j\++) {

           createCoins(1200 \+ (i \* 30), height \- (250 \+ j \* 30));

       }

   }


   // Add question blocks in key locations

   createQuestionBlocks(450, height \- 350);

   createQuestionBlocks(1100, height \- 300);

   createQuestionBlocks(1900, height \- 280);


   // Add enemies in strategic locations

   createEnemies(600, height \- 60, 'Goomba');

   createEnemies(1200, height \- 60, 'KoopaTroopa');

   createEnemies(1800, height \- 60, 'Goomba');


   // Create platform maze section

   // This creates a more complex jumping puzzle area

   let mazeStartX \= 2000;

   let platformHeights \= \[150, 200, 250, 300, 250, 200\];

   for (let i \= 0; i \< platformHeights.length; i\++) {

       createPlatforms(

           mazeStartX \+ (i \* 120),

           height \- platformHeights\[i\],

           80, // shorter platforms for tighter jumping

           20

       );

   }


   // Add hidden bonus areas

   // Secret upper path

   createPlatforms(1500, height \- 400, 300, 20);

   for (let i \= 0; i \< 5; i\++) {

       createCoins(1550 \+ (i \* 30), height \- 450);

   }

}

// setupLevel0();

setupLevel1()

let keys \= {

   left: false,

   right: false,

   jump: false,

};

// Input handling

window.addEventListener('keydown', (e) \=\> {

   if (e.key \=== 'j') {

       keys.left \= true;

       player.lastDirection \= \-1; // Moving left

   }

   if (e.key \=== 'l') {

       keys.right \= true;

       player.lastDirection \= 1; // Moving right

   }

   if (e.key \=== 'i') keys.jump \= true;

   if (e.key \=== ' ') { // space bar to shoot

       if (player.fireFlower) {

           // Shoot a fireball in the direction the player is facing

           const fireball \= new Fireball(

               player.x \+ (player.lastDirection \=== 1 ? player.width : \-10), // Adjust fireball start position based on direction

               player.y \+ player.height / 2 \- 5,

               player.lastDirection // Pass the direction

           );

           fireballs.push(fireball); // Add fireball to the array

       }

   }

});

window.addEventListener('keyup', (e) \=\> {

   if (e.key \=== 'j') keys.left \= false;

   if (e.key \=== 'l') keys.right \= false;

   if (e.key \=== 'i') keys.jump \= false;

});

// Game loop

function gameLoop() {

   update();

   render();

   requestAnimationFrame(gameLoop);

}

const fireballs \= \[\]; // Array to hold fireballs

// Update game logic

function update() {

   // Player movement

   if (keys.left) player.x \-= player.speed;

   if (keys.right) player.x \+= player.speed;

   // Jumping

   if (keys.jump && player.grounded) {

       player.velocityY \= player.jumpPower;

       player.grounded \= false;

   }

   // Apply gravity

   player.velocityY \+= player.gravity;

   player.y \+= player.velocityY;

   // Collision detection with terrain

   terrain.forEach(tile \=\> {

       if (player.x \< tile.x \+ tile.width &&

           player.x \+ player.width \> tile.x &&

           player.y \+ player.height \< tile.y \+ tile.height &&

           player.y \+ player.height \+ player.velocityY \>= tile.y) {

           player.y \= tile.y \- player.height; // Adjust position

           player.velocityY \= 0;

           player.grounded \= true;

       }

   });

   // Collision detection with pipes

   pipes.forEach(pipe \=\> {

       if (player.x \< pipe.x \+ pipe.width &&

           player.x \+ player.width \> pipe.x &&

           player.y \+ player.height \< pipe.y \+ pipe.height &&

           player.y \+ player.height \+ player.velocityY \>= pipe.y) {

           player.y \= pipe.y \- player.height; // Adjust position

           player.velocityY \= 0;

           player.grounded \= true;

       }

   });

   // Collision detection with platforms

   platforms.forEach(platform \=\> {

       if (player.x \< platform.x \+ platform.width &&

           player.x \+ player.width \> platform.x &&

           player.y \+ player.height \< platform.y \+ platform.height &&

           player.y \+ player.height \+ player.velocityY \>= platform.y) {

           player.y \= platform.y \- player.height; // Adjust position

           player.velocityY \= 0;

           player.grounded \= true;

       }

   });

   // Reset player position if they fall through the ground

   if (player.y \> height) {

       player.y \= height \- player.height;

       player.velocityY \= 0;

       player.grounded \= true;

   }

   // Coin collection

   coins.forEach((coin, index) \=\> {

       if (player.x \< coin.x \+ coin.width &&

           player.x \+ player.width \> coin.x &&

           player.y \< coin.y \+ coin.height &&

           player.y \+ player.height \> coin.y) {

           coins.splice(index, 1); // Remove the coin from the array

           player.coins \+= 1; // Increment coin count

       }

   });

// Check if player has enough coins for an extra life

if (player.coins \>= 15) {

   lives \+= 1;

   player.coins \= 0; // Reset coins after gaining a life

}

   // Question block interaction

   questionBlocks.forEach(block \=\> {

       if (player.x \< block.x \+ block.width &&

           player.x \+ player.width \> block.x &&

           player.y \+ player.height \< block.y \+ block.height &&

           player.y \+ player.height \+ player.velocityY \>= block.y) {

           if (block.hasPowerUp) {

               block.hasPowerUp \= false; // Remove the power-up from the block

               // Spawn a random power-up (mushroom or fire flower)

               const powerUpType \= Math.random() \< 0.5 ? 'mushroom' : 'fireFlower';

               items.push(new Item(block.x, block.y \- 20, powerUpType)); // Spawn item above the block

           }

       }

   });





  

    // Check collision with flagpole

   if (player.x \+ player.width \> flagpole.x && player.x \< flagpole.x \+ flagpole.width && player.y \+ player.height \>= flagpole.y) {

   }


  

   fireballs.forEach((fireball, index) \=\> {

       fireball.update();

      

       // Check if fireball goes off-screen

       if (fireball.x \> width || fireball.x \< 0) {

           fireballs.splice(index, 1); // Remove fireball if it goes off screen

       }

       // Check collision with enemies

       enemies.forEach((enemy, enemyIndex) \=\> {

           if (fireball.collidesWith(enemy)) {

               enemies.splice(enemyIndex, 1); // Remove enemy if hit by fireball

               fireballs.splice(index, 1); // Remove fireball after hit

           }

       });

   });


   items.forEach((item, index) \=\> {

       item.update();

       if (item.y \> height) {

           items.splice(index, 1); // Remove item if it falls off screen

       }

       // Check if player collects the item

       if (item.x \< player.x \+ player.width &&

           item.x \+ item.width \> player.x &&

           item.y \< player.y \+ player.height &&

           item.y \+ item.height \> player.y) {

           item.collect(player); // Collect item and apply effects

           items.splice(index, 1); // Remove item from the array

       }

   });


   // Check collision with flagpole

if (player.x \+ player.width \> flagpole.x && player.x \< flagpole.x \+ flagpole.width && player.y \+ player.height \>= flagpole.y) {

   flagpole.touched \= true;

   player.velocityY \= 2; // Start sliding down the flagpole

   player.x \= flagpole.x \- player.width / 2; // Keep player aligned with the pole

   setTimeout(function() {

       levelComplete \= true; // Set the level as complete

   }, 1000);

}

// Check if the player's health is 0 or below

if (player.health \<= 0) {

   setTimeout(function() {

       gameOver \= true;

   }, 50);

}

if (player.invincible) {

   player.invincibilityTimer \-= 16.67; // Assuming 60 FPS, subtracting \~16.67 ms per frame

   if (player.invincibilityTimer \<= 0) {

       player.invincible \= false; // Reset invincibility

   }

}

   // Update enemies

   enemies.forEach(enemy \=\> enemy.update());

}

//========================

// Render graphics

function render() {

   ctx.clearRect(0, 0, canvas.width, canvas.height); // Clear canvas

   // Draw terrain

   ctx.fillStyle \= 'green'; // Terrain color

   terrain.forEach(tile \=\> {

       ctx.fillRect(tile.x, tile.y, tile.width, tile.height);

   });

   // Draw pipes

   ctx.fillStyle \= 'darkgreen'; // Pipe color

   pipes.forEach(pipe \=\> {

       ctx.fillRect(pipe.x, pipe.y, pipe.width, pipe.height);

   });

   // Draw platforms

   ctx.fillStyle \= 'lightblue'; // Platform color

   platforms.forEach(platform \=\> {

       ctx.fillRect(platform.x, platform.y, platform.width, platform.height);

   });

   // Draw coins

   ctx.fillStyle \= 'gold'; // Coin color

   coins.forEach(coin \=\> {

       ctx.fillRect(coin.x, coin.y, coin.width, coin.height);

   });

   // Draw question blocks

   ctx.fillStyle \= 'yellow'; // Question block color

   questionBlocks.forEach(block \=\> {

       ctx.fillRect(block.x, block.y, block.width, block.height);

   });


   // Draw items

   items.forEach(item \=\> item.render());


   // Draw fireballs

   fireballs.forEach(fireball \=\> fireball.render());


   // Draw flagpole

ctx.fillStyle \= 'gray';

ctx.fillRect(flagpole.x, flagpole.y, flagpole.width, flagpole.height);


   // Draw enemies

   enemies.forEach(enemy \=\> enemy.render());

   // Draw player

   ctx.fillStyle \= player.fireFlower ? 'orange' : (player.state \=== 'big' ? 'blue' : 'red'); // Color based on state

   ctx.fillRect(player.x, player.y, player.width, player.height);


   // Draw coin counter

   ctx.font \= "20px Arial";

   ctx.fillStyle \= "yellow";

   ctx.fillText("Coins: " \+ player.coins, 1400, 30);

   ctx.fillStyle \= "white";

   ctx.fillText("Lives: " \+ player.health, 1400, 60);


  

   if (levelComplete) {

        displayLevelComplete();

        return;

   }

   if (gameOver) {

       displayGameOver();

       return;

  }

}

// Start the game loop

gameLoop();

