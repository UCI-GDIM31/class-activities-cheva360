# in-class-activities
## Devlogs

## W7
### [Google doc link w/ drawing: (Came up with game idea, jump types, ui.)](https://docs.google.com/document/d/1tP76vpdvqVFgg7NrHrj0tOCw1tf_d0Ft6UOzOWAW50Q/edit?usp=sharing)
### Step 2 was wrong because it was using the world axis instead of the local axis, aka vector3.up instead of transform.up.

## W6
### [Category Google doc link: (Made unity engine category)](https://docs.google.com/document/d/1jGkW1Q2xP_713KL3rIzM0yPQ_F7CGMHJ1AHQlTPs5pg/edit?usp=sharing)

### BatW6 Plan
- If chase is called, set chase bool to true 
- If stopchase is called, set chase bool to false 
- If chase bool is true, on void update vector3 move towards target position at speed*deltatime
- speed = 2f


## W5

### Write down a question you have about vectors, the Transform Component, gameObject, or GetComponent().
What are the limitations and the proper syntax of get component? What scenarios can I use it for? 
- Get component gets a unity component of a game object, for example the collision. Lets say you want the collision of a ball object, you would write ball.GetComponent< collisionclass > something like that. You can get the component and change properties of the component

Deer class plan :
1. Define the class
2. Define the serialized field target object
3. Define the navmesh agent
4. Set destination to target objects position on start.


## W4

### Devlog

### Tables 11-19: lines 17, 28, and 32 of CatW4 code file

Table 11
- _isGrounded is a member variable, and the type is bool
- Line 28 is an if statement which occurs when _isGrounded is true and the space key is pressed.
- Line 32 sets _isGrounded to false because the jump has commenced, and the player is no longer grounded.

### What solution did you come up with for the collider activity, and why? Specifically- which objects did you add Rigidbodies to, and which object(s) did you check Is Trigger on?
- I added colliders to the player, the soccer ball, and the goal. I added rigidbodies to the soccer ball and the player, and set is trigger on the goal. This is because both the soccer ball and the player need to be affected by physics, while the goal only needs to detect when a collision tagged as the soccer ball occurs.

### IF your game did not work perfectly the first time you tested it, talk about what you had to fix.
- At first I forgot to set the goal as a trigger, so the goal vfx particles never played when the ball entered the goal.

## W3

### Devlog

### You’re building a visual novel, and you’re writing a method named GetResponse that gives you a character’s text response to a player’s dialogue choice based on the player’s current friendship level with the character and a flag that tells you whether or not the player knows the character’s secret.

GetResponse(int, bool);

The int describes the friendship level while the boolean whether or not the player knows the character's secret.
You can use nested if statements that checks the friendship level and then in the if statement check whether or not the boolean is true and return a dialogue option accordingly.

## W2

### Devlog 2

1. Why are the r, g, and b variables floats instead of ints, bools, or strings?
- The RGB values need to be float (fractional numbers) not integers (whole numbers) because the rgb values range from 0.0 to 1.0 (integer values cannot represent any value in between 1 and 0)

2. Why is the _bounce variable an int instead of a float, bool, or string?
- _bounce is a variable that counts the number of bounces, which can only be whole numbers. Float is for fractional numbers and integers is for whole numbers therefore int is the variable type used.

3. The error you got after Step 4 of Part 2 told you something useful about why that line of code was broken- what was it?
- If I remember correctly after uncommenting the line either required a semicolon ; to signify the end of the statement, or an f at the end of the value to signify a float value.


## W1
Hello World!

### Devlog 1
- Added movement to player
- Changed from third person to first person perspective

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
