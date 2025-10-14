# in-class-activities
## Devlogs

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
