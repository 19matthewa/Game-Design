# **Mario-Style Platform Game Design**

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
  * Level Elements  
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
11. `fireFlower`: A boolean indicating whether the player has a fire flower power-up. Example for other power-ups that can be added to give the player new abilities.  
12. `lastDirection`: An integer representing the player's last movement direction (1 for right, \-1 for left). This can be used to determine which way the player is facing.  
13. `invincible`: A boolean indicating whether the player is currently invincible. This can be used to temporarily protect the player from damage.  
14. `invincibilityTimer`: The time remaining in the player's current invincibility period. This can be used to track and manage the player's invincibility.  
15. `invincibilityDuration`: The total duration of the player's invincibility period. This can be adjusted to control how long the player remains invincible.

To add new qualities to the player, you can simply add new properties to the `player` object. For example, you could add a `weapon` property to track the player's current weapon, or a `score` property to track the player's points. You can then update these properties as the player interacts with the game world.

## **Fireball**

Example: The Fireball class represents a projectile fired by the player character, typically when the player has acquired a power-up (such as a fire flower). The fireball travels in the direction the player is facing, and it has basic collision detection capabilities to interact with other objects in the game world. The class includes methods for updating its position, rendering it on the screen, and checking for collisions with other entities.

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
* See game.js file