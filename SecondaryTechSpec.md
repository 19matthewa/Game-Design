# PowerUp: P2
The PowerUp class represents collectable power-ups that affect the player.
## Variables
x, y: double - Position of the power-up on the canvas.
type: String - Type of power-up (e.g., Armor, Voltage Cloak).
effectDuration: double - Duration of the effect for temporary power-ups.
isActive(): boolean - indicates if power-up is currently active
## Methods
applyEffect(player): Changes player attributes based on the power-up type for the effectDuration
removeEffect(player) : Reverts the player’s state to normal
update(): Updates position if the power-up moves
checkCollision(player): Detects collision with player and calls applyEffect() if detected.

# Projectile: P2
Handles projectiles like fireballs and kunai that the player or enemies fire.
## Variables
x, y: double - Initial position.
direction: int - Direction of movement.
speed: double - Travel speed.
damage: int - Amount of damage dealt upon collision.
origin: string - source of the projectile
isPowerUp: boolean - checks if projectile has any other effect besides damage
## Methods
move(): Updates x position according to direction and speed.
checkCollision(entity): Checks if the projectile collides with a specific entity, changes player or enemy health. If isPowerUp, then calls applyPowerUpEffect(player, powerUp)
applyPowerUpEffect(player, powerUp) : calls powerUp’s applyEffect(player)
render(): Draws the projectile on the canvas.
update(): Moves the projectile and checks for collisions.