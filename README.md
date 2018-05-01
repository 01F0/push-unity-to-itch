# What is it?
Just a simple C# script for running several builds and then pushing them to the right channels on itch.io.
I've only added code for building/pushing web and android but it is quite simple to expand.

# Requirements
This script uses itch.io's butler to push builds, so you need that installed. Prior to running this script you must also have run 'butler login' at least once, so that the credentials are stored.

# How to use it
1. Download or copy/paste the content into a script file which should be located in your Scripts/Editor folder.
2. Replace the values indicated by the 'replace me' comments.
3. The script should be visible in your Unity menu as its own category.
