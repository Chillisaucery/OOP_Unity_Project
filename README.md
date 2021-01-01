# OOP_Unity_Project: Megaman Zero Clone


### Member:

+ Lưu Hiển Long - ITITIU19025.
+ Trần Ngọc Tiến - ITITIU19217.
+ Dương Thiên Phúc - ITITIU19184.


### Game Rule:

###### Start of the game:

+ Player has health = 200.
+ Spawn all the enemies. 


###### Game Rule:

+ Type: Platformer.
+ Player can shoot enemies to damage and eventually destroy them.
+ Enemies can shoot or touch the player to damage and eventually destroy him.
+ Player can jump or dash to dodge the monster’s attack.
+ Player can shoot 2 kinds of bullet: a normal bullet and a wave bullet.
+ Normal bullet usually does less damage, but flies farther and faster.
+ Wave bullets have higher damage and shorter range, also the player cannot shoot waves bullets if they are moving horrizontally..
+ The game will have no boss, so the win condition is to destroy all the monsters in the map to win and end the game.
+ Enemy will has different kinds (like flying, grounded, can shoot or cannot shoot).


###### Game Over:
+ Health = 0.
+ Amount of monster = 0.


### Terminogies:


###### Game:

1. Platform: places that the player can stand on.
2.	Projectile: Bullet of the character’s gun.
3.	Character Movement: allow the creature to move (including jump, dash, flip horizontally and shoot)
4.	Character Controller: let the physical player (input via keyboard) and other C# scripts make the creature to move. 


###### Unity:

1.	 Game Object: Every objects that appears on the screen during the gameplay.
2.	 Camera: Render the whole game.
3.	 Component: Contains behaviour for a game object).
4.	 Transform: Scaling, rotating and positioning the game object. Is a Component and every Game Object has this.
5.	 Sprite : two-dimensional bitmap usually contains multiple images. These images will be used to create animation for the Game Objects..
6.	 Animator: Animation Controller, decides which animation the Game Object should display (example: Running Animation, Shooting Animation,...)..
7.	 RigidBody2D: Apply different kinds physics system on a game object.
8.	 Collider: Allow game object to collide (contact physically) with other game object that has collider.
9.	 C# Script: C# code.

### Class Diagram:
This is our link for class diagram : https://app.diagrams.net/#G18GANFgK7SwhiZsIiEerdUQwS8knLuWWj

### OOP properties:
Unity has many features designed base of the concept of OOP. We took advantage of this to implement OOP into our games.
1.	 Inheritance and Polymorphism: Unity support this through a use of "Prefab" system. We can save our Game Objects as .prefab files and then create some Variants of them. Variants are also .prefab files, but it inherit all the properties of the base file and allow us to modify its own properties. 
2.	 Decorator Pattern: The Game Object system support this pattern. Each Game Object is created with only 1 initial components (which is Transform). We then 'decorate' these Game Object with different kinds of components to create all the Game Object in the game. 
3.	 Factory Pattern: the "Prefab" system also support this pattern. We can create multiple Game Objects into the game from a base .prefab file. Our bullets and enemies are created this way/

    
