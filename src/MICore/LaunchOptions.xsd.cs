﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace MICore.Xml.LaunchOptions
{
    using System.Xml.Serialization;


    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014", IsNullable = false)]
    public partial class AndroidLaunchOptions
    {
        public AndroidLaunchOptions()
        {
            this.Attach = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Package;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LaunchActivity;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SDKRoot;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NDKRoot;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IntermediateDirectory;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DeviceId;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LogcatServiceId;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Attach;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TargetArchitecture TargetArchitecture;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AdditionalSOLibSearchPath;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MIMode MIMode;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MIModeSpecified;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    public enum TargetArchitecture
    {
        /// <remarks/>
        x86,

        /// <remarks/>
        arm,

        /// <remarks/>
        arm64,

        /// <remarks/>
        mips,

        /// <remarks/>
        x64,

        /// <remarks/>
        amd64,

        /// <remarks/>
        x86_64,

        /// <remarks/>
        X86,

        /// <remarks/>
        ARM,

        /// <remarks/>
        ARM64,

        /// <remarks/>
        MIPS,

        /// <remarks/>
        X64,

        /// <remarks/>
        AMD64,

        /// <remarks/>
        X86_64,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    public enum MIMode
    {
        /// <remarks/>
        gdb,

        /// <remarks/>
        lldb,

        /// <remarks/>
        clrdbg,
    }

    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    public partial class Command
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IgnoreFailures;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IgnoreFailuresSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    public partial class BaseLaunchOptions
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public Command[] SetupCommands;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public Command[] CustomLaunchSetupCommands;

        /// <remarks/>
        public BaseLaunchOptionsLaunchCompleteCommand LaunchCompleteCommand;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LaunchCompleteCommandSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ExePath;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ExeArguments;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string WorkingDirectory;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VisualizerFile;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TargetArchitecture TargetArchitecture;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AdditionalSOLibSearchPath;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MIMode MIMode;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MIModeSpecified;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    public enum BaseLaunchOptionsLaunchCompleteCommand
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("exec-run")]
        execrun,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("exec-continue")]
        execcontinue,

        /// <remarks/>
        None,
    }

    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014", IsNullable = false)]
    public partial class IOSLaunchOptions
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RemoteMachineName;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PackageId;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int vcremotePort;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public IOSLaunchOptionsIOSDebugTarget IOSDebugTarget;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public IOSLaunchOptionsSecure Secure;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TargetArchitecture TargetArchitecture;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AdditionalSOLibSearchPath;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MIMode MIMode;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MIModeSpecified;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    public enum IOSLaunchOptionsIOSDebugTarget
    {
        /// <remarks/>
        Device,

        /// <remarks/>
        Simulator,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    public enum IOSLaunchOptionsSecure
    {
        /// <remarks/>
        True,

        /// <remarks/>
        False,
    }

    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014", IsNullable = false)]
    public partial class LocalLaunchOptions : BaseLaunchOptions
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MIDebuggerPath;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MIDebuggerServerAddress;
    }

    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014", IsNullable = false)]
    public partial class PipeLaunchOptions : BaseLaunchOptions
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PipePath;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PipeArguments;
    }

    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014", IsNullable = false)]
    public partial class TcpLaunchOptions : BaseLaunchOptions
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Hostname;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Port;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Secure;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SecureSpecified;
    }
}