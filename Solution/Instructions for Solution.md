# Instructions for going through the Solution

You can find a full working Battle Tank project repository which contains the scripts and assets that you can fork in your local system and refer to the implementations done in Unity. This branch contains all the pre-requiestes mentioned in the problem statement + the additinal feature mentioned below,

### **Solution Feature Implementation**

Enemy AI -> Implemented this feature using State Machine Behavior.This allows the enemy tanks to,

- Idle -> Enemy tanks will stay in idle positon for sometime
- Patrol -> Enemy tanks will patrol the game scene in search of player tank
- Chase -> Enemy tanks will follow the player tank after getting in the defined range
- Attack -> Enemy tanks will start sattacking the player tank after getting in attacking range

**Things to keep in mind after forking the repository**

1. Install Cinemachine package in Unity (Windows -> Package Manager -> Unity Registry -> cinemachine)
2. Understand the code before jumping to the solution
3. Install Async await packagaes from Unity Asset Store
4. Use Navmesh surface from (GameObject > AI > NavMesh Surface)
5. The above repository was made in Unity 2017 but will be able to work on any 2017 or later Unity LTS version
