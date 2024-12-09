# MVP Implementation Plan
    make game over
    add death

## Day 1-2 (Core Framework)
    # Objects: P0
    ## Point 
    ## EnvironmentObject
    ## Box

    # Map: P0
    The Map class holds the level layout, obstacles, platforms, and boundaries
    ## Variables
    layout: 2D array - defining terrain, walls, and obstacles.
    platforms: List<Platform> - List of static or moving platforms.
    boundaries: Object - Defines the boundaries of the map (e.g., leftBoundary, rightBoundary, topBoundary, bottomBoundary) to restrict player movement.
    barriers: List<Barrier> - List of barriers and hazards.
    spawnPoints: List<Point> - List of spawn points for enemies and player
    ## Methods
    loadMap(level): Loads layout for the specified level.
    render(): Draws the map elements.
    update(): Updates dynamic elements in the map.
    checkBoundaryCollision(entity): Detects if an entity hits the boundaries.

    # GameManager: P0
    ## Variables
    level: int - Tracks the current level.
    isGameOver: boolean - Indicates if the game is over.
    player: Player - Instance of the player character.
    enemies: List<Enemy> - Collection of enemies present in the level.
    powerUps: List<PowerUp> - List of available power-ups.
    map: Map - map based on the level layout, terrain, and obstacles.

    ## Methods
    initializeGame(): Initializes the game, setting up the initial level, entities, and game loop. 
    toggleGamePause(): pauses or unpauses game
    endLevel(): sets isGameOver to true
    checkCollisions(): Detects and handles collisions between the player, enemies, platforms, power-ups, and other elements.
    tickGamePlay(): calls player actions, calls update() on the player, enemies, and map elements to refresh game state


## Day 3-4 (Essential Features)
    # Player: P0
    ## Variables
    position: point- Current position of the player on the canvas.
    width, height: int - Dimensions of the player hitbox.
    coins: int - Total coins collected by the player.
    score: int - Player’s accumulated score.
    speed: double - Speed at which the player moves horizontally.
    velocity: double - Vertical speed for jumping and falling.
    jumpPower: double - Determines how high the player can jump.
    gravity: double - Gravitational pull affecting the player.
    grounded: boolean - Indicates if the player is on the ground and able to jump.
    state: String - Player’s power-up state (ie "small", "armor", "fireFlower")
    health: int - Remaining player lives
    lastDirection: int - Tracks the last direction the player moved (1 = right, -1 = left).
    invincible: boolean - True if the player is temporarily invincible
    invincibilityTimer: double - Tracks remaining time in the current invincibility period

    ## Methods
    move(direction): Changes the player’s x position based on the speed and direction.
    jump(): Sets the vertical velocity if the player is grounded.
    applyGravity(): Modifies y position according to gravity and velocity.
    takeDamage(): Reduces health or changes player state when hit.
    collectCoin(): Increments coins and calls GameManager to increase the score.
    updateScore(): updates player score
    activatePowerUp(powerUp): Activates a power-up effect and modifies state or attributes.
    update(): Updates player position, applies gravity, and checks ground state.

## Day 5 (Enhancement & Testing)
# Enemy: P1
The Enemy class is a base class for all enemy types.
## Variables
position: point - Position of the enemy on the canvas.
width, height: int - Dimensions of the enemy hitbox.
speed: double - Movement speed.
direction: int - Movement direction (1 = right, -1 = left).
boundaryLeft: double - left boundary where the enemy will turn around
boundaryRight: double - right boundary where the enemy will turn around
isTurning: true when the enemy is changing direction
type: String - Type of enemy (e.g., Cyber-Grunt, Mecha-Troopa).

## Methods
move(): Adjusts position based on speed and direction.
checkBoundaries(): checks if the enemy has reached boundaryLeft() or boundaryRight()
turnAround(): changes the direction to the opposite direction when checkBoundaries() or detectObstacle() signals a need to turn
detectObstacle(): checks for obstacles in the direction moving.
takeDamage(): Updates health or destroys the enemy.
checkPlayerCollision(player): Determines if there’s a collision with the player and initiates the interaction.
update(): Updates enemy behavior and position based on specific enemy type logic.
- Final testing and refinement



library that might be helpful to use: melonJS
figma: https://www.figma.com/board/OnhIOHknIWMbRQF3eApGp0/Matthew's-Figma?node-id=0-1&t=k7YXhvjKD0NTGo84-1