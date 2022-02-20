# Instructions for going through the Problem Statement

You can find a working Battle Tank project repository that contains the scripts and assets which you can fork in your local system and refer to the implementations done in Unity. Below are the features of the game that you will be able to access from this repository.

### **Pre-Requisites**

1. Tank Movement (WSAD keys) -> Player Tank can move around the scene in the game using keyboard input
2. Tank Spawning (3 types of tanks) -> We have taken 3 types of Player Tank with different health and movement speed. Any 1 of the tank will spawn at random at the start of the game
3. The firing of bullets (Space/L.Ctrl key) -> Player Tank will be able to fire bullets with the help of keyboard input
4. Using Navmesh system to create enemy AI -> Spawning of Enemy Tank with the shooting mechanism
5. Destroying the bullets -> Bullets will get destroyed after colliding with the enemy tank or any other gameObject
6. Destroying enemy tanks -> Enemy tanks get destroyed after colliding with the bullet fired by the player tank
7. Destroying player tanks -> Player tank gets destroyed after colliding with the bullet fired by the enemy tanks

**Things to keep in mind after forking the repository**

1. Install Cinemachine package in Unity (Windows -> Package Manager -> Unity Registry -> Cinemachine)
2. Understand the code before jumping to the solution
3. Install Async await support packages from Unity Asset Store
4. Use Navmesh surface from (GameObject > AI > NavMesh Surface)
5. The above repository was made in Unity 2017 but will be able to work on any 2017 or later Unity LTS version

