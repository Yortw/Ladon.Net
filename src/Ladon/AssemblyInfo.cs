using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
#if NET40
[assembly: AssemblyTitle("Ladon.Net40")]
#elif NET45
[assembly: AssemblyTitle("Ladon.Net45")]
#elif NET48
[assembly: AssemblyTitle("Ladon.Net48")]
#elif NETSTANDARD2_0
[assembly: AssemblyTitle("Ladon.NetStandard20")]
#endif

#if !NETCORE45
// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]
#endif