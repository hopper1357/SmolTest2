# SmolTest2

Technical

    Written in C# using MonoGame framework
    Turn based system drives gameplay loop
    Persistent saving of game state

The goal is to create a single player dungeon crawling RPG experience inspired by the tabletop solo adventure game "4 Against Darkness".
Characters

    Classes: Fighter, Rogue, Wizard, Cleric. Each with special abilities.
    Stats: Attack, Defense, Max Health, Level, Experience
    Equipment: Weapon, Armor, Shield, Misc Gear
    Actions: Move, Attack, Use Item, Equip/Unequip, Cast Spell

Combat

    Turn-based system
    Attack rolls vs enemy defense
    Positioning matters based on marching order
    Effects like poison, fear, paralysis etc as debuffs

Content

    Procedurally generated dungeon rooms and corridors
    Monster spawns and encounter tables
    Loot tables for items, gold, gear
    Spell list
    Trap effects
    Random event
