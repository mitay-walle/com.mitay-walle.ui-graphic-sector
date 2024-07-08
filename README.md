Unity3d uGUI Custom Graphic that draws an oval sector

# Features
- no custom shaders
- correct input handling
- SpriteBorder support
- 9-slice support
- SpriteAtlas support
- pixelPerUnitMultiplier support
- Anchors for other transforms, including resizing to squeeze content into a sector
- UV-by radius and tile by RectTransform
- free pivot, or generated in the center of the sector
- gradients
- nested sectors can stick to parent
- offset by angle
- pixel offset
- performance-wise
# Known Issues
- automatic navigation not always recognize Selectable in selection wheel, cause it's RectTransforms placed identicaly. Use explicit navigation instead
- 9-sliced sprites 'shrink' to center, cause uv calculated per-degree
- Tiled mode not support SpriteAtlas, only Single-texture sprites, by design. Cause tiling achievet through uv repeating, no blowing up geometry as UI.Image.Tiled use 
# Usage Example | 9-slice sprite
![sector_resolution](https://github.com/mitay-walle/com.mitay-walle.ui-graphic-sector/assets/5578552/8e77b83f-3c27-49b0-aa49-00e3eb194d18)
![sector_pixelPerUnitMultiplier](https://github.com/mitay-walle/com.mitay-walle.ui-graphic-sector/assets/5578552/d77aa3e0-4341-44a3-99c5-f1af5514a5f8)
![sector_inputRaycasting](https://github.com/mitay-walle/com.mitay-walle.ui-graphic-sector/assets/5578552/ae14bc8e-c446-42ae-9b74-637d78afef04)
![sector_inputRaycasting2](https://github.com/mitay-walle/com.mitay-walle.ui-graphic-sector/assets/5578552/59ad93b4-cb71-4389-ad0b-8965fe8fbbdf)
![sector_count](https://github.com/mitay-walle/com.mitay-walle.ui-graphic-sector/assets/5578552/4c1a544c-32e0-452e-bec7-c9cfd1ff90f4)
![photo_2024-04-21_03-00-49](https://github.com/mitay-walle/com.mitay-walle.ui-graphic-sector/assets/5578552/9edace04-0f86-4fee-8e9f-28c16e51694c)
![photo_2024-04-21_03-00-45](https://github.com/mitay-walle/com.mitay-walle.ui-graphic-sector/assets/5578552/c90f39c6-1723-4dd1-8442-d10c77d8d580)
![photo_2024-04-21_03-00-42](https://github.com/mitay-walle/com.mitay-walle.ui-graphic-sector/assets/5578552/b1c6d39a-73c3-4ea3-b7f6-3aef41406c65)
![photo_2024-04-21_03-00-55](https://github.com/mitay-walle/com.mitay-walle.ui-graphic-sector/assets/5578552/ddb2f28d-e5e7-47c3-b071-2df24438c896)
![photo_2024-04-21_03-00-51](https://github.com/mitay-walle/com.mitay-walle.ui-graphic-sector/assets/5578552/57a64d73-89e4-4392-b98a-4b3f88267122)
![photo_2024-04-21_03-01-00](https://github.com/mitay-walle/com.mitay-walle.ui-graphic-sector/assets/5578552/a218976e-2d6d-4997-9c52-235971e18b60)
![photo_2024-04-21_03-01-03](https://github.com/mitay-walle/com.mitay-walle.ui-graphic-sector/assets/5578552/1e24106d-b77e-434c-87ff-ca9a3072c6c3)
![photo_2024-04-21_03-01-06](https://github.com/mitay-walle/com.mitay-walle.ui-graphic-sector/assets/5578552/b1bfc807-5261-4d4c-ab05-20398b3cdb98)
![photo_2024-04-21_03-01-08](https://github.com/mitay-walle/com.mitay-walle.ui-graphic-sector/assets/5578552/70e66e04-5ce5-49b1-a23d-a04de8ae7033)
![photo_2024-04-21_03-01-14](https://github.com/mitay-walle/com.mitay-walle.ui-graphic-sector/assets/5578552/fa8ee8bc-86c5-45c3-a32a-fc8f92fca713)
![photo_2024-04-21_03-01-16](https://github.com/mitay-walle/com.mitay-walle.ui-graphic-sector/assets/5578552/f0f6342d-a8f7-46c5-bd5d-b0e45469bf65)
![photo_2024-04-21_03-01-19](https://github.com/mitay-walle/com.mitay-walle.ui-graphic-sector/assets/5578552/5cd5adfb-4716-4f4d-9f6b-a801242c7adc)
![photo_2024-04-21_03-01-21](https://github.com/mitay-walle/com.mitay-walle.ui-graphic-sector/assets/5578552/3c45bb2f-40a9-47f5-998c-d74dfd8d3633)
![photo_2024-04-21_03-01-24](https://github.com/mitay-walle/com.mitay-walle.ui-graphic-sector/assets/5578552/1ca10daf-6ce3-4b09-ab40-8694c4067349)
![photo_2024-04-21_03-01-26](https://github.com/mitay-walle/com.mitay-walle.ui-graphic-sector/assets/5578552/207c0de8-e732-4181-a6ff-2f2e3b1309e8)
![photo_2024-04-21_03-01-55](https://github.com/mitay-walle/com.mitay-walle.ui-graphic-sector/assets/5578552/5614409a-c5ee-4f4e-a449-2f42f0b1fff3)

