[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
There are two main objects, the player and the seeds being planted. 
The player can move around the game world with the WASD keys. The player can plant the seeds with the space bar. The seeds aren’t able to do anything once placed. The player can NOT plant more than 5 seeds.
The player can trigger the other object (seed). The player plants the seeds using the space bar wherever they want to in the game world. 

Start by tackling the movement first, then getting the plant prefab set up. After that, I'm going to input the code for planting the seeds. Finally, I’m going to work on getting the UI to function properly. Obviously, I will add the scripts to each game object along the way as I always do.

## Devlog
I believe my original plan that I mapped out during the in-class activity worked out. I did in fact begin by working on the movement, which I totally just robbed from GP1 from last quarter's project. Following that, I attached the player script to the player object to get the movement to function. Then, I set up the plant prefab in Unity which was pretty simple. After that, I worked on the PlantSeed() method within my player script. I wasn't sure where to update the UI so I placed it both here and in the StartGame() method. Then, I worked on the PlantCountUI script which was fairly simple until I realized it wouldn't let my values be left as "seedsLeft" and "seedsPlanted." So, I had an idea to work around it which was adding two quotation marks with no actual message inside of them + the "seedsLeft" and "seedsPlanted." In the Unity scene, I had trouble setting up the Plant Count UI script to the Plant Count UI under the player script. I resolved my issue by adding an empty object under Canvas and attaching the Plant Count UI script to it. Finally, I hooked up the new object to the Plant Count UI under the player script. This was the entire process of coding and setting up the main scene in unity. While it was a good refresher, this assignment helped me realize that I am way better at the Unity stuff than the coding stuff.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprite

## Prof comments
The activity answers you wrote weren't exactly what I was expecting- in the class, we broke down things into objects and their attributes and actions- but, you described how your plans connected to the code that you implemented well, so I'm giving you full marks for this Devlog. I'm very interested to see how you structure your plan for HW2, and whether or not you're finding the planning activities useful.

Also:

> I did in fact begin by working on the movement, which I totally just robbed from GP1 from last quarter's project

This is a totally valid way to code things. LOL.

> I realized it wouldn't let my values be left as "seedsLeft" and "seedsPlanted." So, I had an idea to work around it which was adding two quotation marks with no actual message inside of them + the "seedsLeft" and "seedsPlanted."

You can also use the ToString() method on almost anything in C#, but this also works.

You can remove the prompt text from your Devlogs; it makes reading them easier for me.
