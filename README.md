# AdVenture Calculator

[Download Now!](https://github.com/TrapperHell/AdVentureCalculator/releases/tag/1.0)

AdVenture Calculator is a small tool I developed in C# for use with *AdVenture Capitalist* - developed by Hyper Hippo.

#![Screenshot](Screenshot.png?raw=true)

Initially it was intended as a very small tool to calculate the total earnings per second (before I could buy the appropriate managers anyway). However, out of necessity (and lacking an alternative) it grew into something more.

I managed to squeeze in all the unlocks, cash and angel upgrades along with angel investors and their effectiveness to provide a rather thorough calculation.

In addition I included a purchase cost calculator, an Angel Investor calculator and a waiting-time calculator to reach a certain monetary goal. Ohh, and I've also included a graph of each business's contribution to the sum amount of money earned - just for the kicks.

### Credits:

This tool uses an LZF compression algorithm developed by Roman Atachiants (a port of Mark Lehmann's LibLZF) and based on Oren J. Maurice's original adaptation: [https://csharplzfcompression.codeplex.com/](https://csharplzfcompression.codeplex.com/)

Additional thanks: biggreen200, Muskar, Empresstamar, Confuseh, JesterXO.

### Disclaimer (and historical notes):

This application was never really intended to grow so large, so quickly. As such some of the technical decisions (or lack of) are a result of shortsightedness. I just wanted to create something that works.

Another unforeseen circumstance was that I would suddenly lose interest in the game and eventually stop playing it altogether.

This lead to a very curious struggle. partly there was so much more I wanted to do with the tool and on the other hand there was very little motivation left to work upon it. As such the project lay dormant for quite a while - since **v. 1.0.0.977** of AdVenture Capitalist actually.

It was only recently that I came across the code and realized how useful it was to me in my prior quest to become a capitalist. Thinking that someone might actually benefit from this tool I decided that it might be a good idea to let it out in the wild.

As such after a lengthy deliberation I decided to go forth with this idea. I slapped together the newly added cash and angel upgrades - and even the increasing large monetary terms. This was obviously added to an already rather complex codebase.

As a result I was rather unhappy about the end-result of the code and the inconsistencies therein. However realistically speaking I could not see myself taking the time to do all the refactoring or re-write the application from scratch.

That is not to say that all the code is a mess. There are a few pieces of code that I am rather content with (*FunctionChainer* and *MonetaryValueDisplay*) but there is also a lot of code that could have been designed differently. For instance, I didn't immediately use data-bindings to link the controls to the back-end, and it was only much later in the project that I did some use of it. As such, not all the controls are consistently bound - which also makes the UI refreshing a bit more tedious.

The whole set of upgrades and hard-coded within the application itself and there is no external resource file for them, which is quite sad. Additionally due to my initial uncertainly on how to make the upgrade system work, all the upgrade names are written, not once - but twice! Comments are also virtually nonexistent. Yep...

So, in short, the tool seems to work, but if you want to browse through the code, you're in for a treat.



### Missing Bits and Pieces:

Here's a couple of things that I wanted to do, however never really got around to doing...

* Refactor the upgrade system
* Throw all the upgrades (and lots of other text) in external resource files
* Improve the UI (WPF or web even - as you see fit)
* Make use of the DataExport reader to pre-load all the upgrades, unlocks, building levels etc. Currently, it only re-writes the export into JSON data.
* The Moon! I initially thought of including it with the release, but there are quite a number of upgrades, so after throwing in the Moon buildings I decided against it. It is very much doable if you find the time to incorporate all the unlocks, upgrades and other calculations. From the little I've seen Mars is possibly doable as well.
* You might also find a couple of TO-DOs lying around in the code, while those were meant as notes for myself, I did not bother remove them.


### Ending Notes:

If this tool proves to be of any use to you, than great! If on the other hand, you find little use for it, you might want to improve as you see fit. That's the whole reason why I'm open-sourcing this thing.
