# VRoidHairMerger

At the time of making this application VRoid did not contain functionality to add hair presets to existing hair.

VRoidHairMerger takes source hair preset and adds it to the destination preset. This allows purchase of hair presets from booth and adding them to your exitsting VRoid model.


## Usage
1. Make sure the hair asset you want to add to your character's hair is saved as hair preset
2. Save your character's hair as a hair preset in VRoid
3. Run VRoidHairMerger
4. Import the destination hair preset on your existing character

## Error cases
The program looks the hair presets in AppData\LocalLow\pixic\VRoidStudio\hair_presets. If your presets are saved elsewhere then you need to change the path in the source.

If VRoid shows an error message after the merge then something went wrong and the destination hair preset needs to be manually removed.
