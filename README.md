# MauiNavigationBugRepro

Minimal repro where pushing the same Page instance onto a NavigationPage after popping it causes a crash on UWP.

Note that the page instance is pushed onto a NavigationPage and not onto the Shell navigation stack.
