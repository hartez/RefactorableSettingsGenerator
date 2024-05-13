Refactorable Settings Generator
=============================

Refactorable Settings Generator is an alternative to the standard SettingsSingleFileGenerator which ships with Visual Studio and handles generating the code for [Application Settings]. In addition to generating the usual settings code, this version also generates constant values for each of the settings names for use in `SettingChanging` event handlers. 

For a complete explanation of why you might want this, take a look at my posts on [Refactorable Settings].

### Compatibility
I've only built this for (and tested it on) Visual Studio 2013 Professional. If and when I need it to work in another version, I'll add support; in the meantime, if you want to get it running and tested in other versions, pull requests are always welcome. 

### Installation

This extension is available in the [Visual Studio Gallery]. 



[Application Settings]: https://msdn.microsoft.com/en-us/library/0zszyc6e(v=vs.110).aspx

[Refactorable Settings]: https://codewise-llc.com/blog/?category=VS+Refactorable+Settings

[Visual Studio Gallery]: https://marketplace.visualstudio.com/items?itemName=ElijaHart.RefactorableSettingsGenerator
