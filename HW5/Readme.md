# HW5

### Avatar Switcher Exercise
Build an avatar controler system that can switch betweeen multiple avatars with IK.
When we build social vr projects users will have the option to choose their Avatar. Based on 
our work in the last 2 classes, we should be able to modify our avatar project to support this.

#### Template

You can use the in class 005 exercise Unity project as a starting point for this project

### Must have functinalities

 1. Find/Download/Create 3 Humanoid Characters
 2. Import to Unity and Rig with VRIK
 3. Child all models under the avatar prefab, make only 1 visible
 4. Create an Enum in which each key represents one of the characters, model1,model2,model3
 5. Bind keys, 1-3 on your keyboard to change the current character to one of the Enum values
 for ex: if you preess 1, currentavatar would be enum.model1, 2-> enum.model2
 6. When the currentavatar enum changes, disable the current avatar and enable the selected new avatar.
 7. Make sure the new visible avatar can still be controlled by your IK bridge cubes as we did in class

## HINTS

1. Remember to Link VRIK to the bridge control boxes for controlling IK, head and arms
2. Enum is just a type, similaar to a class, declare a currentAvatar variable using the enum to track your current visible avatar
3. When currentAvatar changes, you can track if currentAvatar value is different in the Update loop. 
4. Keep Calm and Carry on.
	
