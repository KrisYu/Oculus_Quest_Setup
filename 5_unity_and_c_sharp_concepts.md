# Unity And C# Concepts

Now it's time to add some Unity and C# knowledge.

## Scene

Scene is the scene, it is where we place everything.



## GameObject

> Every object in your game is a GameObject, from characters and collectible items to lights, cameras and special effects. However, a GameObject can’t do anything on its own; you need to give it properties before it can become a character, an environment, or a special effect.


We have created GameObject and attached script to it before.
 

## Script

Script is C#, by default is has two methods, we need to attach Script to GameObject, it can be a empty GameObject in the scene, and the methods inside the script will be executed.

```
using UnityEngine;
using System.Collections;

public class MainPlayer : MonoBehaviour {

    // Use this for initialization
    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {
    
    }
}
```

That's why we put `Debug.Log("Hello World")` in `update` and can constantly see it.


## Asset

> An asset is any item that you use in your Unity project to create your game or app. Assets can represent visual or audio elements in your project, such as 3D models, textures, sprites, sound effects, or music. Assets can also represent more abstract items such as color gradients, animation masks, or arbitrary text or numeric data for any use.


Remember when we get the Oculus Integration from the Asset Store.


## Prefab

Using the Oculus Integration, when use `OculusTouchForQuestAndRiftS_Left`, if we look carefully, we'll see the suffix is `.prefab`. The file type is prefab.


> Unity’s Prefab system allows you to create, configure, and store a GameObject complete with all its components, property values, and child GameObjects as a reusable Asset. 

We can also create prefab ourself, for example, you can create a Sphere in the scene, then create a Prefab Folder under Asset, then drag the object to that folder, you'll see the object's filetype is to prefab. 


## Animator

Remember using the Oculus Integration, when using custom hand prefab, press button we can see a animation, but not with the controller, dig into the inspector we can see there's animator under the  `r_hand_skeletal_lowres` under the CustomHandRight, but no animator and animator controller in the controller prefab.

To look up concepts and usage:

- [Unity Manual](https://docs.unity3d.com/Manual)
- [Oculus Integration Documentation](https://developer.oculus.com/documentation/unity/unity-ovrinput/)




