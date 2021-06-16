# Pyboard File Manager
Windows GUI for Pyboard.py Compatible Devices

<p align="center">
  <i>Note: This project is not associated in anyway with the Pyboard hardware project or the MicroPython organization.</i>
</p>
<p align="center">
  <i>BTW: Thanks Damien!</i>
</p>

<p align="center">
  <img src="https://github.com/joewez/PyboardFileManager/blob/main/pybfm.jpg" alt="Screenshot"/>
</p>
<p align="center">
  <img src="https://github.com/joewez/PyboardFileManager/blob/main/pybfm-repl.jpg" alt="REPL Screenshot"/>
</p>
<p align="center">
  <img src="https://github.com/joewez/PyboardFileManager/blob/main/rp2-repl.jpg" alt="RP2 REPL Screenshot"/>
</p>

A simple GUI wrapper that executes the <b>pyboard.py</b> script (https://github.com/micropython/micropython/blob/master/tools/pyboard.py) command to manipulate the files on an device running MicroPython.  The device must support raw REPL over the serial port in order for this application to function properly.

It was written in C# in Visual Studio 2019, so you will need VS Express or better to compile it.  It uses the Scintilla editor control (https://github.com/jacobslusser/ScintillaNET) which allows for MicroPython syntax highlighting.

As a development tool, I wrote the utility to mainly just edit the files directly off of the device.  I have also embedded a simple terminal emulator to send commands to the serial REPL.  The program works better though when paired with an external terminal such as puTTY or TeraTerm.  See the configuration notes below on how to set this up.

A precompiled binary is available for download here:

  https://wezensky.no-ip.org/shared/pybfm.zip
  
Just unzip to a convenient location and run the PyboardFileManager.exe. 

<b>DEPENDENCIES:</b> 

- Python 3.X
- Pyboard.py  (pip3 install pyboard)
- .Net Framework (maybe)

<b>HOW TO START:</b>

- Plug your MicroPython device into your computer and determine what com port it was assigned to
- Start the application.
- Select the com port for your device (if there is more than one)
- The main window should appear with the files on the root of the device listed
- If there was a problem and the files were not listed, click on the Refresh button
  
<b>HOW TO USE:</b>

All the features are pretty self-explanatory, but here is just a short description of it's general use.

- Navigation
  - To open a file for viewing or editing, select the file and click "Open" (or just double-click the filename)
  - To go into a sub-folder select the folder and click "Open" (or just double-click the folder name)
  - To go back one directory click on the [..] entry at the top of the file list
    
- Main Commands
  - <b>New</b> will prepare a new file for editing
  - <b>Open</b> will open a file for editing or change the directory
  - <b>Load</b> will allow you to import a file from your computer
  - <b>Export</b> will save the selected file to your computer
  - <b>Delete</b> will delete the file or directory from the device
  - <b>Move</b> will move (rename) the selected file
  - <b>MKDIR</b> will allow you to create a sub-folder
  - <b>Refresh</b> will re-read the file list of the current directory
  - <b>Run</b> will attempt to import/run the selected file
  - <b>REPL</b> will open a MicroPython REPL window
  
- Editing Commands
  - <b>Undo/Redo/Cut/Copy/Paste/Delete</b> standard editing commands
  - <b>Find</b> will do a simple search on the current file being edited
  - <b>Replace</b> will do a simple search and replace on the current file being edited
  - <b>Save As</b> will save the current file to the device using the name you give it in the <i>current</i> directory
  - <b>Save</b> will save the current file to the device

<b>ADDITIONAL INFO:</b>

- Configuration setting are located in the PyboardFilemanager.exe.config file
  - <b><i>CommPort</i></b> designation can be a name like COM3 (no colon) or just a number
  - The application defaults to 115200 baud for serial communications
  - If <b><i>ExternalTerminal</i></b> is set to "Y" the <b><i>TerminalApp</i></b>, <b><i>TerminalAppArgs</i></b> and 
    <b><i>TerminalAppTitle</i></b> settings are used
    - <b><i>TerminalApp</i></b> is the EXE to run
    - <b><i>TerminalAppArgs</i></b> are the arguments to run the terminal app with
      - The term <i>{PORT}</i> in this setting will be replaced at runtime with the current port
      - The term <i>{PORTNUM}</i> in this setting will be replaced at runtime with the current port number
    - <b><i>TerminalAppTitle</i></b> is the title of the external window
    - Example:

        <p>	
        &lt;add key="ExternalTerminal" value="Y" /&gt;<br />
        &lt;add key="TerminalApp" value="putty" /&gt;<br />
        &lt;add key="TerminalAppArgs" value="-load &quot;repl&quot; -serial {PORT}" /&gt;<br />
        &lt;add key="TerminalAppTitle" value="PuTTY" /&gt;<br />	
        </p>
        
        Invokes the putty.exe application and uses the "repl" session
  - The <b><i>EditExtensions</i></b> setting determines what types of files are editable (text)
  - The <b><i>SaveDir</i></b> setting determines where session files are created, if blank the EXE location is used
  - <b><i>UniqueSessions</i></b> indicates if a single session directory is used or a new one for each program start
    - The "session" directory is where a file is stored while being edited
  - Color settings may be a WebColor name or a 3 value, comma-separated list of the RGB values to use
  - <b><i>CommPortExclusions</i></b> should be just the numbers seperated by commas

<b>CAVEATS:</b>

- Although it should work with any device that <b>pyboard.py</b> works with, it has only been tested with...
    - Pyboard v1.1
    - TPYBoard
    - Wemos D1 Mini
    - Witty Cloud Board 
    - Generic NodeMCU Board
    - Raspberry Pi Pico (requires DTR to be enabled)
- This can only edit basic text files and is focused on editing MicroPython source code
- Binary files can be loaded and exported
- This editor is only meant to edit a single file at a time
- You cannot delete a directory unless it is empty
- Switching between the REPL and the editor (and back) is a little rough... especially with an ESP8266 and the internal REPL.  
    - You may have to "Refresh" or try again to get a feature to work.
    - Sometimes the software will pause until the device is momentarily unplugged
    - This is highly dependent on the type of application that is running
	- It is recommended you use an external application (such as putty or TeraTerm) for the REPL

<b>ROADMAP:</b>

- Proper Options/Configuration editing window.
