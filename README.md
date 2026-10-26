# BG3 Mini Tool

This was a tool I was making to edit lsx/lsf files that would put less strain on the eyes that I wanted to share with others.

This is a very WIP tool and I am only one person who was learning how to code as I made this tool. I used books I bought, internet tutorials and help from ChatGPT.

Things included:
- create a new meta.lsx
- New Head/Horn/Hair slots
- folder creation for lsx locations
- Colour wheel that shows Hex and converts it also to sRGB 0 to 1.0 converter
- separate version number generator in the tools tab with the colour wheel with a save as option to save to existing meta's
- mass replace uuids/handles (always save a copy of your mod elsewhere just as a precaution like when using any other tools)
- localisation editor
- creating 32 entries for CCAV (or more if the CharacterCreationAppearanceVisuals_ForAll.lsx is added to add more between the `<children></children>`
- adding vfx files for heads to fix speak with the dead and such not working

---

## October 2026

I began reviewing my tool and all the commits I made to it. I have fibromyalgia along with various sleep conditions which does come with a lot of brain fog and memory issues for me, as well as autism and social phobia which contributed to my use of ChatGPT on this tool.

### Where it helped:

Reading back all the commits, I can see where I likely got help. Due to my memory issues I can't pinpoint every single one, but what I can I have pointed out below, as I am trying to disclose everything.

- Maths: the version numbers, hex to sRGB 0-1.0 and the seam blending on textures.
  - Might come as a surprise but I used to be very good at maths, but since the start of my memory issues from brain fog and other health conditions in 2010 I lost that, and I am no longer good at maths. My brain takes a lot of time these days for even some simple maths on my bad days.
- Snippets: I clearly asked it for snippets for replacing a value in a line which then I went on to using myself having understood everything that works in that snippet. How to create folders, pick a folder and checks in MaterialGroups.
- To fully disclose there are left over comments from the AI, even on the snippets I copied and reused after understanding how to use them. Those copies were edited completely by me after understanding what they did and why. I am admitting this as I am not trying to hide anything.

### What was completely me:

- I used Windows Forms to create my UI and I did that all completely myself including adding the colour picker via Windows Forms. Which is why it has more the classic colour picker look from early 2000s than newer UIs do. 
- The research was all me, as most will know before this tool I made the exact same templates for manual replacement/edits. What I did with the tool was make a UI that could do the same just look less messy than reading an lsx/xml format directly.
- The high resolution fix was something I found by researching online to make sure it wouldn't blur on higher resolutions with help from nandez's suggestion pointing me in the right direction.

### Extra:
Looking back at my code having the knowledge I do now I know I could have used a static helper to streamline my code better instead of reusing the exact same code again and again. I will be slowly working on improving that part of the code with the help of The C# Yellow Book by Rob Miles. If that version ever gets released I don't know, and I want to be honest about that too. My health conditions get in the way a lot. So sometimes I do prefer focusing on new mods rather than going back and cleaning old ones.

**Am I still learning code?** Yes, slowly but yes with a mix of things. In most things I first work in the format I am most comfortable in which usually isn't code to begin with. A good example of this is editing game files directly first, before moving onto another format. And I find this helps my brain understand everything I need to do. In BG3 this would be first working on Osiris the games native code, before attempting to convert that to Lua. And yes I realise I don't need to convert Osiris to Lua, but it helps me learn plus it provides another option for users. Such as being able to use the Mod Configuration Menu to give the players options in the mod.
