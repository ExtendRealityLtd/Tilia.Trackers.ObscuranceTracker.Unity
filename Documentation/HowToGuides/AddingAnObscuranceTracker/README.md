# Adding An Obscurance Tracker

> * Level: Beginner
>
> * Reading Time: 5 minutes
>
> * Checked with: Unity 2018.3.14f1

## Introduction
The `Obscurance Tracker` enables you to toggle the state of an object between being present or invisble based a `GameObject` obscuring the view between two other `GameObjects`

## Prerequisites

* [Install the Tilia.Trackers.ObscuranceTracker.Unity] package dependency in to your [Unity] project.



## Let's Start

### Step 1

Create a new `Cube` Unity 3D Object by selecting `Main Menu -> GameObject -> 3D Object -> Cube` and change the `Transform` properties to:

* Position: `X = -2`, `Y = 0`, `Z = 0`

![Adding A Cube](assets/images/AddingACube.png)

### Step 2

Create a new `Cube` Unity 3D Object by selecting `Main Menu -> GameObject -> 3D Object -> Cube` and change the `Transform` properties to:

* Position: `X = 2`, `Y = 0`, `Z = 0`

![Adding A Second Cube](assets/images/AddingASecondCube.png)

### Step 3

Create a new `Cube` Unity 3D Object by selecting `Main Menu -> GameObject -> 3D Object -> Cube` and change the `Transform` properties to:

* Position: `X = 0`, `Y = 0`, `Z = 0`

![Adding A Third Cube](assets/images/AddingAThirdCube.png)
	
### Step 4

Create a new `Sphere` Unity 3D Object by selecting `Main Menu -> GameObject -> 3D Object -> Sphere` and change the `Transform` properties to:

* Position: `X = 0`, `Y = 2`, `Z = 0`

![Adding A Sphere](assets/images/AddingASphere.png)

### Step 5

Expand the `Tilia Trackers ObscuranceTracker Unity` Package directory in the Unity Project window and select then `Packages -> Tilia Trackers ObscuranceTracker Unity -> Runtime -> Prefabs -> Actions` directory then drag and drop the `Tilia Trackers ObscuranceTracker` prefab into the Hierarchy window.

![Adding The ObscuranceTracker](assets/images/AddingTheObscuranceTracker.png)

### Step 6

Drag and drop the `Cube` GameObject from the Unity Hierarchy window into the `Source` parameter field.

![Drag And Drop Cube Into Source Parameter](assets/images/DragAndDropCubeIntoSourceParameter.png)

### Step 7

Drag and drop the `Cube (1)` GameObject from the Unity Hierarchy window into the `Target` parameter field.

![Drag And Drop Cube(1) Into Source Parameter](assets/images/DragAndDropCube(1)IntoSourceParameter.png)

### Step 8

Click the `+` symbol in the bottom right corner of the `Target Obscured` event parameter in the `Obscurance Query` component.

![Click+Symbol](assets/images/Click+Symbol.png)

Drag and drop the `Sphere` GameObject into the box that appears and displays `None (Object)`.

![Drag And Drop Sphere](assets/images/DragAndDropSphere.png)

### Step 9

Select a `Function` to perform when the `Target Obscured` event is emitted. For this example, select `GameObject -> SetActive(bool)` (be sure not to select `Dynamic bool - SetActive` for this example).

![Set Target Obscured Active Bool](assets/images/SetTargetObscuredActiveBool.png)

### Step 10

Do The same as Step 9 for the `Target Unobscured` but tick the checkbox.

![Set Target Unobscured Active Bool](assets/images/SetTargetUnobscuredActiveBool.png)

### Done

Play the Unity scene and you will notice that the `Sphere` GameObject disappears, this is because `Cube` does not have direct line of sight on `Cube (1)` because `Cube (2)` is in the way and obscuring the view.

This causes the `Target Obscured` event to emit, which we've set to disable our `Sphere` GameObject.

![No Sphere](assets/images/NoSphere.png)

Now just change the `Cube (2`) Transform `y` position to `-2`

![Set Value To -2](assets/images/SetValueTo-2.png)

And now `Cube` does have direct line of sight of `Cube (1)` so the target is no longer obscured and the `Sphere` GameObject will become active.

![SpherePresent](assets/images/SpherePresent.png)

[Install the Tilia.Trackers.ObscuranceTracker.Unity]: ../Installation/README.md
[Unity]: https://unity3d.com/