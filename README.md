## Inspiration
Amblyopia is the most common cause of visual impairment among children, affecting approximately 2 to 3 out of every 100 children. Unless it is successfully treated in early childhood, amblyopia usually persists into adulthood. More than 200,000 cases are recorded every year. The inspiration to build this project was drawn after closely witnessing a beloved family member who still suffers from Amblyopia and unfortunately could not regain full strength in his left eye. Since this disorder is mostly observed in small children , A VR game based treatment appealed to us as a very engaging and effective way to train the weaker eye to function in sync with the brain and cure the disorder completely before it grows bigger.

## What it does
It creates a virtual reality environment which has the user playing a first person shooter game where the only way to score and progress through the game levels is to focus your weaker eye at moving targets and shoot at them! The game gathers several analytical metrics related to the player's performance and visualizes them  to gain further insights into their training. We can view the hit/mis-hit ratio , percentage increase in the number of hits/mishits per level and other meaningful statistics that gives a good sense of the player's progress. 

## How we built it
The game was designed  and developed using C# on the unity platform and runs on the Oculus-Rift VR device. A backend layer built on nodeJS captures live metrics from the game and stores this data in MySQL Database . This data is then pulled into Microstrategy desktop and visualized using different plots to discern the progress of the player.

## Challenges we ran into
We were new to VR world, a new technology platform Unity, a never used before device Oculus Rift. Challenges were initially to --setup all the required technology to develop a Game for achieving our Goal. 
-Understanding RayCast for shooting using Oculus Remote Control. 
-Unity Left Eye Right Eye Camera wise display of certain GameObjects(For making the Weaker Eye view more Objects).
-developing on a new language C#
-Microstartegy Visualization API MongoDB issues(did not support our use-case of MongoDB so had to port everything to MySQL)
-Developing by learning new framework NodeJS as a webservice for capturing game metrics 
## Accomplishments that we're proud of
1st Hackathon experience for one teammate. Learning new technology - Unity, C# and NodeJS webservice development. Figuring out and fixing all issues and challenges we ran into using Unity GameObjects. Completed development of a full-fledged game in Oculus Rift

## What we learned
-Unity
-Game Development for VR(LeftEye RightEye Camera Controllers)
-C#
-NodeJS

## What's next for AmblyoCare
A new module to collect visual health related data on the fly to involve Optical healthcare professionals
