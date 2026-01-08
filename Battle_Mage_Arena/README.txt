README

Controls:
WASD to move, mouse wheel to select spell, left click to cast spell. While in-game, press "p" to to acces the overlay menu, from where you can exit the game.

FILE LOCATIONS
The file layout is a bit confusing, and with the amount of preconfigured stuff, unreal folders can be hard to navigate. Here are the locations of the important ones for our project:

/Game/Levels
Contains the logic for the lobbies, the main menu (SessionSelect), and the coin pickup game mode. The "Ballgame" folder can be ignored. It just contains an empty level.

/Game/Gamemode_and_state
Contains logic for selecting the game mode and managing the game state, along with the relevant blueprints.

/Game/ThirdPerson
Contains the level used for the battle arena as well as the blueprints used for the player along with the various components attached to the player. It also contains UI elements for the healthbar (/Game/ThirdPerson/Blueprints)


/Game/Spells
Contains blueprints for every spell. There are two versions of the force spell and teh ice spell. The ones currently implemented are "New_Force_Spell" and "New_Ice_spell".

/Game/Widgets
Contains the majority of UI elements for the game.