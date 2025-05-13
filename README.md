# Kacky Split Loader
![image](https://github.com/user-attachments/assets/f75db724-0059-4aca-92da-6667d1499f56)

A Split Loader component for Kackiest Kacky in LiveSplit.

## Description
While playing Kackiest Kacky in TrackMania, I found it tedious to manually load a split file every time the map changed, so I created this component myself.  
**Skill 0%, ChatGPT 100%** — there may be bugs or unnecessary code. xd

> **Note: This component must be used together with the TimerPause component.**  
> [TimerPause by ROFLailXGOD](https://github.com/ROFLailXGOD/TimerPause)

## Installation
Don't forget to install ROFLailXGOD's TimerPause component first.
1. Go to the Releases tab and download the latest `LiveSplit.Kacky.SplitLoader.dll` and `Kacky_Splits.zip`.
2. Extract `Kacky_Splits.zip` to any folder you prefer.
3. Copy `LiveSplit.Kacky.SplitLoader.dll` into the `Components` folder inside your LiveSplit installation directory.
4. Open LiveSplit → Right-click → Edit Layout... → Click the "+" button → Control → Add "Kacky Split Loader".
   - (Note: TimerPause can be found under "Other" → "Timer Pause".)
5. In Layout Settings → Kacky Split Loader tab, set the path to the folder where you extracted `Kacky_Splits.zip`.

## Usage
- It is recommended to first set up a Pause hotkey in LiveSplit Settings. (If you check "Global Hotkeys," you will be able to pause the timer while playing the game.)
- Enter the map number you want to play in the input box.
- Press the **Load button** or **Enter key** to automatically load the corresponding split file.
- Start the timer and enjoy playing Kackiest Kacky.
- When switching maps, simply enter the new map number and Load again.
- Previous split records will be automatically saved through TimerPause.
