﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.81.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:minor-servicebus-fileservicelocator:locationData")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:minor-servicebus-fileservicelocator:locationData", IsNullable=false)]
public partial class locationData {
    
    private serviceLocation[] serviceLocationField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("serviceLocation")]
    public serviceLocation[] serviceLocation {
        get {
            return this.serviceLocationField;
        }
        set {
            this.serviceLocationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:minor-servicebus-fileservicelocator:locationData")]
public partial class serviceLocation {
    
    private string nameField;
    
    private string profileField;
    
    private string metadataAddressField;
    
    private System.Nullable<decimal> versionField;
    
    /// <remarks/>
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    public string profile {
        get {
            return this.profileField;
        }
        set {
            this.profileField = value;
        }
    }
    
    /// <remarks/>
    public string metadataAddress {
        get {
            return this.metadataAddressField;
        }
        set {
            this.metadataAddressField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public System.Nullable<decimal> version {
        get {
            return this.versionField;
        }
        set {
            this.versionField = value;
        }
    }
}