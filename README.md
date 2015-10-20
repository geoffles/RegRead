# RegRead fix for VS Command Prompt

In somecases, registry editing may be blocked by a group policy which then blocks your VS Command Prompt.

VS Command Prompt attempts to get settings out of the registry by using reg.exe, which denies access to the registry.

The simple solution is to replace your reg.exe

## Installation

This is for VS 2012. For other versions, you'll have to adapt.

There are three files which you will need to edit:

-  %VS110COMNTOOLS%\VCVarsQueryRegistry.bat
-  %VS110COMNTOOLS%\VsDevCmd.bat
-  %VS110COMNTOOLS%\vsvars32.bat

### Instructions

1. Unpack RegRead.exe to your somewhere in your %PATH% variable
  o  You can create a create a directory (eg, Program Files\RegRead) and add it to the your PATH variable
2. For each of the above files,
  1.  Open the file
  2.  Goto 'Find and Replace'
  3.  Find `'reg query` , replace with `'RegRead query`
  4.  Test!
  
Happy CLIing.
