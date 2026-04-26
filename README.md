
# No Fences – Revived
A 64 bit safe restoration of the original NoFences project by Twometer.

## About This Project
This is an adaptation of the original NoFences repo by Twometer. I was looking for a simple desktop organiser, came across Stardock, and then found this project. I’ve been tinkering with repos for a couple of years for personal use, but this is the first time I’ve stepped out of my comfort zone to actually fix and ship something.
I’m a total amateur when it comes to correcting code outside of tweaking things for myself, so please go easy on me — any helpful advice or constructive criticism is welcome.
This version focuses on stability, 64 bit compatibility, and fixing core behaviour that prevented the original project from working properly on modern Windows.

<img width="474" height="483" alt="Screenshot 2026-04-26 194200" src="https://github.com/user-attachments/assets/918168da-a236-4fc3-9881-3f607947287b" /> 


## Why This Fork Exists
The original codebase had several issues on my modern 64 bit Windows:
•	The container didn’t actually own the shortcuts placed inside it
•	Dragging items in/out caused errors
•	Right clicking fences crashed the app
•	Win32 interop used 32 bit pointer conversions
•	The app was unstable, froze randomly, or closed unexpectedly
The concept was great — a lightweight, free alternative to Stardock Fences — so I decided it would be the perfect project to learn from and revive.

## 64 Bit Fixes & Win32 Interop Overhaul
Older versions of the app used 32 bit pointer conversions internally (ToInt32() on window handles and message parameters). On 64 bit Windows this caused pointer truncation, leading to:
•	random crashes
•	context menu failures
•	explorer instability
•	corrupted window styles
•	the app freezing or closing unexpectedly

### All Win32 interop has now been audited and corrected:
•	All pointer sized values now use IntPtr
•	Message parameters are read using ToInt64()
•	Window style operations use SetWindowLongPtr on 64 bit
•	All 32 bit only code paths have been removed or replaced
•	The entire Win32 folder has been validated for 64 bit safety

### Example Fix
Old (broken on 64 bit):
```
csharp
int style = GetWindowLong(hWnd, GWL_EXSTYLE).ToInt32();

```

New (64 bit safe):
```
csharp
long style = GetWindowLongPtr(hWnd, GWL_EXSTYLE).ToInt64();

```

This prevents truncation, invalid handles, corrupted window styles, and crashes when interacting with the desktop.
The app is now fully 64 bit compatible and tested on modern Windows builds.

## Shortcut Ownership Fix (Major Behaviour Change)
In the original repo, dragging a shortcut into a fence didn’t actually move the .lnk file. The fence only referenced the desktop copy, which caused:
•	disappearing items
•	duplication
•	orphaned entries
•	inability to drag items back out

### The backend has been rewritten so fences now own their contents:
•	Dropped shortcuts are physically moved into the fence’s AppData folder
•	Metadata is updated to point to the new location
•	The desktop copy is removed cleanly
•	Every item inside a fence is now self contained
•	Deleting a fence returns its shortcuts to the desktop
This makes the behaviour predictable, stable, and consistent.

## Features (Same as Original, Now Stable)
Right clicking a fence gives you options to:
•	Lock the fence
•	Minimise/expand on mouseover
•	Rename the fence
•	Change title size
•	Create a new fence
•	Delete the current fence
The goal of this version is faithful functionality, but modern stability.

## Installation (Simple Guide)

```
1. Download the EXE
Grab the latest version from the Releases page: [here](https://github.com/whackerla/NoFences-Revived/releases/tag/1.0.0)

Extract it anywhere you like (Desktop, Documents, etc).

2. Run the app

Inside the ZIP you’ll find:

NoFences-Revived.exe

Double‑click it to start the app.
No installation required.

3. Your first fence will appear
Right‑click the fence → 
for options like:

Lock fence

Minimise/expand on hover

Rename

Change title size

Delete fence

4. Drag shortcuts into fences
Just drag any shortcut into a fence.
The app will take ownership of it and keep everything tidy.

You will find your backend in Users/[Username]/AppData/Local/
```

## Credits
```
Huge thanks to Twometer for the original NoFences project.
This fork exists purely because the idea was too good to let die,
I needed a desktop cleanup solution, and because,
I finally took the plunge to try and learn something I did not have a clue about.
```


