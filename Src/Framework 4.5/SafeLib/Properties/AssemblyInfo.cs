using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle( "EdlinSoftware.Safe.SafeLib.dll" )]
[assembly: AssemblyDescription( "Library with classes for Safe application support." )]
#if DEBUG
[assembly: AssemblyConfiguration( "Edlin Software Safe Library Debug version." )]
#else
[assembly: AssemblyConfiguration("Edlin Software Safe Library Release version.")]
#endif
[assembly: AssemblyCompany( "Edlin Software." )]
[assembly: AssemblyProduct( "Edlin Software Safe library." )]
[assembly: AssemblyCopyright( "Copyright (C) Edlin Software 2006-2008. All rights reserved." )]
[assembly: AssemblyTrademark( "Edlin Software." )]
[assembly: AssemblyCulture( "" )]
[assembly: AssemblyDefaultAlias( "EdlinSoftware.Safe.SafeLib.dll" )]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible( false )]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid( "3cc4af2c-3858-4038-bd39-10d71c654ac3" )]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:
[assembly: AssemblyVersion( "1.0.0.0" )]
[assembly: AssemblyFileVersion( "1.0.0.0" )]

[assembly: InternalsVisibleTo("EdlinSoftware.Safe.SafeLibTest")]