Title : Campus Walk-through Using VR

Group Members :
Mandar Kumbhar,
Sahil Naik, 
rutvik Lathiya

Description :

Virtual campus acts as an interactive walk-through application that is based on Virtual
Reality. This paper explains all phases of building the virtual campus starting from requirement gathering to building the final application, which includes other phases such as
modeling, texture mapping, and scripting. This Virtual Reality application can be used by
the institute to introduce students, newcomers, to the campus with a Virtual Model of the
college and make them familiar with the facilities available. It will provide a real-life walkthrough of the campus while being stationary with VR ready devices. It uses Blender for
preparing 3d models, unity 3d to prepare the structural model, and adding user interaction
to an application through scripts and Google VR plugins.

Implementation:
Head Movement: This is the most important interaction in the walkthrough as the user
should be able to have a full 360-degree view of the surrounding. For this we can use the
GvrEditorEmulator prefab from Google VR plugins, it includes the GvrEditorEmulator
script component that is used for controlling head movement and controller movement
in the unity 3d. When it is enabled in your scene in play mode in the unity 3d, it
allows you to control head movement by moving head-on VR head mount and moving
the mouse while holding the ALT or CTRL keys on the Unity editor window, and
emulator controller movement using the Controller Emulator companion app.

Teleporting: This can be achieved either by using XR plugins if using VR controllers
or by Google VR plugins if using google cardboard VR. In this project we will use
Google VR plugins, to teleport we have added the tiles on which if the users see
9for 2 to 3 sec it will be teleported to the location of that tile. For this, we have use
GvrEventSystem which is Container for the EventSystem and GvrPointerInputModule
components, and GvrReticlePointer which is used to renders the gaze reticle. It can be
disabled or removed through the unity editor window manually or by writing scripts.
In this project, we have made it as a child of the main camera, so that the pointer
and reticle follow the user’s gaze. For using the Google VR input system, the GvrControllerMain prefab is required in the scene. As when the user’s gaze intersects with
an interactive object it automatically adjusts reticle size in the scene. Following script
checks the gvrStatus from GvrReticlePointer and call the Teleport method.

Interacting with the surrounding objects: This includes displaying information of the
object on pointing to that object, for example in a lab on pointing the pointer on the
computer system or other components the specification information will be displayed.
For this, we can add a collider to that object and check for GvrReticlePointer to trigger
the collider on collision call the following info popup script to enable the information
panel or disable the information panel if not triggered.

For the entry-exit mechanism (to enter or exit the room) we can use the same logic
of transformation that we used in teleporting. Following script checks the gvrStatus
from GvrReticlePointer and call entry and exit method.




