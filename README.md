[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Put your notes from the W1L2 (Thurs, Jan 9) in-class activity here. 
There are two main objects, the player and the seeds being planted. 
The player can move around the game world with the WASD keys. The player can plant the seeds with the space bar. The seeds aren’t able to do anything once placed. The player can NOT plant more than 5 seeds.
The player can trigger the other object (seed). The player plants the seeds using the space bar wherever they want to in the game world. 

Start by tackling the movement first, then getting the plant prefab set up. After that, I'm going to input the code for planting the seeds. Finally, I’m going to work on getting the UI to function properly. Obviously, I will add the scripts to each game object along the way as I always do.

## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.


Write your Devlog here!
I believe my original plan that I mapped out during the in-class activity worked out. I did in fact begin by working on the movement, which I totally just robbed from GP1 from last quarter's project. Following that, I attached the player script to the player object to get the movement to function. Then, I set up the plant prefab in Unity which was pretty simple. After that, I worked on the PlantSeed() method within my player script. I wasn't sure where to update the UI so I placed it both here and in the StartGame() method. Then, I worked on the PlantCountUI script which was fairly simple until I realized it wouldn't let my values be left as "seedsLeft" and "seedsPlanted." So, I had an idea to work around it which was adding two quotation marks with no actual message inside of them + the "seedsLeft" and "seedsPlanted." In the Unity scene, I had trouble setting up the Plant Count UI script to the Plant Count UI under the player script. I resolved my issue by adding an empty object under Canvas and attaching the Plant Count UI script to it. Finally, I hooked up the new object to the Plant Count UI under the player script. This was the entire process of coding and setting up the main scene in unity. While it was a good refresher, this assignment helped me realize that I am way better at the Unity stuff than the coding stuff.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprite
