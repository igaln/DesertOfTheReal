# HW4

### 3D DRAWING SHOW
Build a drawing game that can be recording from the computer screen using a 3rd party camera

#### Download the template here

[https://drive.google.com/file/d/1GJREVxScaeJOe4Pcm19S9jqSkgSuq-5e/view?usp=sharing](https://drive.google.com/file/d/1GJREVxScaeJOe4Pcm19S9jqSkgSuq-5e/view?usp=sharing)

### Must have functinalities

 1. Must draw using spheres from your controller
 2. Controller Grip used to draw
 3. Can change colors using some sort of interactive 3D menu.

## HINTS

#### There are 3 Classes setup in the template project to get you going.
1. ControllerHandler - Attached to Player Hands to detect controller actions
2. BrushHandler - Handles the color selection and brushes
3. ColorSelector - Tells Brush Handler which color is selected on Collision

#### TODO
1. Setup your scene to have SteamVR Input Player and teleports
2. Setup a 3D menu with different colored objects - Each Object must know what color they are
3. On Collision Update the selected Color in Brush Handler
4. When grip is pulled in the Controller, use the transform position of the controller to instantiate the Brush Prefab and update its color from the BrushHandler
5. Create a render texture and add it to a Canvas in the UI.
6. Use an extra camera in the scene to Render to render Texture
7. Record your screen as you are drawing in the game, and make a video to send with your Build.
	
