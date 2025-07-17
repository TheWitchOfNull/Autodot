# Autodot
Lightweight Godot Engine specific version deployment utility

## What does Autodot do?
It allows you to very easily deploy and launch a specific version of Godot.  It downloads the desired version to a local directory and allows the execution of tasks on it.  This way if one team member updates the version a project uses, it will update for everyone at the same time and avoid accidental reversionings.

It also has a tasks system which I plan to use to automate exports, but it's fairly simplistic.

## Suggestions for use
The included example autodot.json uses a local folder called .autodot which you'll want to add to your .gitignore.
The binary is designed to be lightweight enough to include directly in a repo, and will execute the default task if run without parameters (which I use to launch the editor).