# ISUSpring2025-DGD202-FinalProject

Istinye University - Digital Game Design Undergraduate Programme
DGD202: Game Engines 1 - Spring 2025 Final Project

  
## Github Instructions:
* Fork this repo  
  	Fork the final project repo to your own Github account. If you don't know how, you can find a tutorial here.  
	https://www.youtube.com/watch?v=-9ftoxZ2X9g&t=25s&ab_channel=WebStylePress  
* Rename the forked repo   
	Rename your forked repo to this format: DGD202Final-YourName-YourStudentNumber  
	Replace "YourName" with your name and "YourStudentNumber" with your student number, obviously  
* Enter your student number  
	When you open the project for the first time, a pop-up will show to enter your student number. This is for verification that it is YOU who worked on the project. It will not show up after the first time, so please enter your own number only and don't give your project files to another student because they will be marked.  
	Of course there are ways to circumvent this security measure (Nothing is ever completely secure) but trust me, it is easier to just do the project.  
* Work on your Project  
	Please work only on this fork. I will track your progress through this fork, so any other repo that is not forked from this one will not be graded.  
* Submit your link, just in case  
	Submit the link to your repo to the final project assignment on Classroom.  
	As I said, I'll track them through the forks, but this is to make sure you also send in your link.  
  
## Project Instructions:
You are going to complete an incomplete Unity project. Don't worry, it's not that hard. Follow the steps below and you'll be alright.  
  
It's a basketball collecting tennis balls. Nothing fancy. The finished product should look like this:  
https://youtu.be/sWWp3ZmAh3E  
  
Here are the steps you should follow:  
  
### PLAYER INPUT    
The game has the player in place. But it's missing a few pieces. The input asset is deleted, and the player has a PlayerMover script but that script does not get any input. It just moves the player when told to do so. Here's what you should do:  
- Create an input asset. It should include a Vector2 input for movement. We did this in class.
- Create an input script. Put this on your player. It should get the input from your input asset, and run the Move() method on the PlayerMover script to move the player.  
- You can create a project-wide input asset, or create one that is referenced on the input script. The execution is totally up to you. We did both in class.  
  
### PREFAB GENERATION  
The pellets (tennis balls) we will collect are spawned automatically by the PelletSpawner component. But its prefab reference is missing, and there is no pellet prefab. You should create a pellet prefab from the Pellet object already in the scene. Here's how to do it:  
- There is a "Pellet" object in the scene. It is supposed to be a prefab, but with a missing element. Add the "Pellet" script to it (in the Scripts folder) and make it a prefab.  
- There is a PelletSpawner component on the "GameControls" object. Put this Pellet prefab you created into the "Pellet Prefab" field of the PelletSpawner.  
- Don't forget to delete the original object in the scene. There shouldn't be any pellets in the scene before we press play, or the game won't count them properly.  
  
### UI  
In the example video you will see a pellet counter on the top left. That element is missing from the game. But it is in the prefabs folder. You have to place it into the scene and reference it, so it will be updated when pellets are collected. Here's the step-by-step:  
- There is a "Pellet Counter" prefab in the prefabs folder. This is a UI element that belongs to the Gameplay Panel. Put it on the appropriate place in the scene. You can arrange its position appropriately.  
- PelletCollector component requires a reference to the counter text. Find the text element that displays the number of pellets collected, and put this element into the PelletCollector's "Counter" field.  
  
### TEST  
You should test that everything is in working order  
