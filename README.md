# Light LOD

In this tutorial repository and [associated video](https://youtu.be/4uFKwR0SrZo) you will learn how to apply the "LOD" (Level of Detail) concept to lights!
In many cases you do not need to always have the highest quality shadows shown. Using this technique you can dramatically reduce the GPU usage and improve performance by stepping down the quality as the camera is farther away from the light source.

[![Youtube Tutorial](./Video%20Screenshot.jpg)](https://youtu.be/4uFKwR0SrZo)

## Quickstart
To use it, simply attach `LightLOD` to an existing Light, or replace your Light(s) with one of the preconfigured Prefabs based on how aggressively you would like to scale the lights.
Then, on your Player's Camera, attach `LightLODCamera`. 

`LightLODCamera` can be attached to as many cameras as you have in the scene. LightLOD will pick the first ACTIVE CAMERA in the list and adjust their LOD based on the distance from this camera. Call `LightLODCamera#Activate` when the active camera should change, and the LODs will adjust automatically.

## Supporters
Have you been getting value out of these tutorials? Do you believe in LlamAcademy's mission of helping everyone make their game dev dream become a reality? Consider becoming a Patreon supporter and get your name added to this list, as well as other cool perks.
Head over to the [LlamAcademy Patreon Page](https://patreon.com/llamacademy) or join as a [YouTube Member](https://www.youtube.com/channel/UCnWm6pMD38R1E2vCAByGb6w/join) to show your support.

### Phenomenal Supporter Tier
* Andrew Bowen
* YOUR NAME HERE!

### Tremendous Supporter Tier
* Bruno Bozic
* YOUR NAME HERE!

### Awesome Supporter Tier
* Gerald Anderson
* AudemKay
* Matt Parkin
* Ivan
* Paul Berry
* Reulan
* Iffy Obelus
* YOUR NAME HERE!

### Supporters
* Bastian
* Trey Briggs
* Matt Sponholz
* Dr Bash
* Tarik
* Sean
* ag10g
* Elijah Singer
* Lurking Ninja
* Josh Meyer
* Edwald Schulte
* Dom C
* Andrew Allbright
* YOUR NAME HERE!

## Other Projects
Interested in other AI Topics in Unity, or other tutorials on Unity in general? 

* [Check out the LlamAcademy YouTube Channel](https://youtube.com/c/LlamAcademy)!
* [Check out the LlamAcademy GitHub for more projects](https://github.com/llamacademy)

## Socials
* [YouTube](https://youtube.com/c/LlamAcademy)
* [Facebook](https://facebook.com/LlamAcademyOfficial)
* [TikTok](https://www.tiktok.com/@llamacademy)
* [Twitter](https://twitter.com/TheLlamAcademy)
* [Instagram](https://www.instagram.com/llamacademy/)
* [Reddit](https://www.reddit.com/user/LlamAcademyOfficial)

## Requirements
* This has been supported at least since Unity 5 so any modern version should work. I used a Unity 2021 LTS.