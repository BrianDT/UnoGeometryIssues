# UnoGeometryIssues
Replicates issues with fill and update

Issues are:
1) Under WASM the transparent rectangle is displayed as black.
Reported as issue #2982
Confirmed as resolved in Uno.UI 3.0.17

2) Under WASM when the Ellipse resizes the surrounding stackpanel does not resize.
Reported as issue #2983
Confirmed still present in Uno.UI 4.1.8
https://github.com/unoplatform/uno/issues/2983
