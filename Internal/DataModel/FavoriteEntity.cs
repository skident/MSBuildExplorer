﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class TargetSet {
    
    private string targetsField;
    
    private string parametersField;
    
    private string strapperField;
    
    private string nameField;
    
    private string fileField;
    
    /// <remarks/>
    public string Targets {
        get {
            return this.targetsField;
        }
        set {
            this.targetsField = value;
        }
    }
    
    /// <remarks/>
    public string Parameters {
        get {
            return this.parametersField;
        }
        set {
            this.parametersField = value;
        }
    }
    
    /// <remarks/>
    public string Strapper {
        get {
            return this.strapperField;
        }
        set {
            this.strapperField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string file {
        get {
            return this.fileField;
        }
        set {
            this.fileField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class FavoriteEntity {
    
    private TargetSet[] targetSetField;
    
    private string fileField;
    
    private string friendlyNameField;
    
    private string groupNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TargetSet")]
    public TargetSet[] TargetSet {
        get {
            return this.targetSetField;
        }
        set {
            this.targetSetField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string file {
        get {
            return this.fileField;
        }
        set {
            this.fileField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string friendlyName {
        get {
            return this.friendlyNameField;
        }
        set {
            this.friendlyNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string groupName {
        get {
            return this.groupNameField;
        }
        set {
            this.groupNameField = value;
        }
    }
}
