# Digital multi-display compound in Unity: 
## Split-screen and Post Processing
Using the "Viewport Rect" camera property in Unity to design split screen outputs is overwritten when applying post-processing effects (OnRenderImage).
The solution for this is using render textures for cameras and displaying them on a UI canvas relative to the desired display.

## EXAMPLE: VIOSO Warp & Blend Post-Process in a 3x1 Nvidia Mosaic
![Screenshot](https://github.com/Ahmed-jerbi/Digital-MultiDisplay-Compound-PostFX/blob/master/mosaicScreenshot.PNG)
