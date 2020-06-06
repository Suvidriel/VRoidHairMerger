# VRoidHairMerger

At the time of making this application VRoid did not contain functionality to add hair presets to existing hair.

VRoidHairMerger takes source hair preset and adds it to the destination preset. This allows easy addition of hair assets like ears, hair accessories etc to existing characters.


## Usage
Requires .NET 4.7.2

1. Make sure the hair asset you want to add to your character's hair is saved as hair preset. Clear all unrelated hair bones
2. Save your character's hair as a hair preset in VRoid
3. Run VRoidHairMerger. Select the asset as source and your character's hair preset as destination
4. Import the destination hair preset to VRoid
5. If no error shows up then save your model in VRoid with a different name
6. Restart VRoid and make sure the model loads up without errors

## Things to note
VRoidHairMerger does not currently give new unique IDs to the merged objects. This means you should not combine same presets more than once.

## Error cases
If VRoid shows an error message after the merge then something went wrong and the destination hair preset needs to be manually removed.
