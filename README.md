### Test program for Type.GetType(..)
***
This program is designed to test the existing differences in the execution of .NET Framework and Mono when querying _Type.GetType ("**")_ and to obtain the name of the requested library.
This difference was found during rigorous testing of a large program, where the requested library name was checked using _String.Equals ()_.
The changes I proposed in the Mono core helped to get an identical result in Mono.

Before :
![](http://images.vfl.ru/ii/1589891831/f16d9820/30556389.png)

After (became how in Framework 4.8) :1st_place_medal: 
![](http://images.vfl.ru/ii/1589891613/9198a9a7/30556366.png)
