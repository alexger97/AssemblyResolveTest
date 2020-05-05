# AssemblyResolveTest
Hello! This is a testing program about differents with  return name of resolving assembly in .Net Framework and Mono Project.


Using Mono  = "CommonComponents.Infra.Zero.Uc , Version=0.0.0.0, Culture=neutral, PublicKeyToken=null".

It is wrong because using .Net Framework we can take Name="CommonComponents.Infra.Zero.Uc"
          
This problem have been detected when I try use Mono with one application that use compare this parametr

This problem with  mono_stringify_assembly_name in assembly.c
