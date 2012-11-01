﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.17929.
// 
namespace Ris.Client.Messages.Document
{
    using System.Xml.Serialization;


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class risdok
    {

        private object metadatenField;

        private nutzdaten nutzdatenField;

        private layoutdaten layoutdatenField;

        private string stylesheetField;

        private string hversionField;

        private string hcreatorField;

        private string hcreatedField;

        /// <remarks/>
        public object metadaten
        {
            get
            {
                return this.metadatenField;
            }
            set
            {
                this.metadatenField = value;
            }
        }

        //
        // http://stackoverflow.com/questions/13166659/winrt-with-xsd-exe-generated-serialization-no-access-to-system-xml-xmlnode/
        //
        public nutzdaten nutzdaten
        {
            get
            {
                return this.nutzdatenField;
            }
            set
            {
                this.nutzdatenField = value;
            }
        }

        /// <remarks/>
        public layoutdaten layoutdaten
        {
            get
            {
                return this.layoutdatenField;
            }
            set
            {
                this.layoutdatenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string stylesheet
        {
            get
            {
                return this.stylesheetField;
            }
            set
            {
                this.stylesheetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("h-version")]
        public string hversion
        {
            get
            {
                return this.hversionField;
            }
            set
            {
                this.hversionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("h-creator")]
        public string hcreator
        {
            get
            {
                return this.hcreatorField;
            }
            set
            {
                this.hcreatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("h-created")]
        public string hcreated
        {
            get
            {
                return this.hcreatedField;
            }
            set
            {
                this.hcreatedField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]

    public partial class T_Error
    {

        private T_Applikation applikationField;

        private string messageField;

        private int errorTypeField;

        /// <remarks/>
        public T_Applikation Applikation
        {
            get
            {
                return this.applikationField;
            }
            set
            {
                this.applikationField = value;
            }
        }

        /// <remarks/>
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int errorType
        {
            get
            {
                return this.errorTypeField;
            }
            set
            {
                this.errorTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]

    public enum T_Applikation
    {

        /// <remarks/>
        Bundesrecht,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]

    public partial class T_WebDocumentContentUrl
    {

        private T_WebDocumentDataType dataTypeField;

        private string urlField;

        /// <remarks/>
        public T_WebDocumentDataType DataType
        {
            get
            {
                return this.dataTypeField;
            }
            set
            {
                this.dataTypeField = value;
            }
        }

        /// <remarks/>
        public string Url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]

    public enum T_WebDocumentDataType
    {

        /// <remarks/>
        Xml,

        /// <remarks/>
        Pdf,

        /// <remarks/>
        Gif,

        /// <remarks/>
        Jpg,

        /// <remarks/>
        Tiff,

        /// <remarks/>
        Png,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]

    public partial class T_WebDocumentContentReference
    {

        private T_WebDocumentContentType contentTypeField;

        private string nameField;

        private T_WebDocumentDataType dataTypeField;

        private object itemField;

        /// <remarks/>
        public T_WebDocumentContentType ContentType
        {
            get
            {
                return this.contentTypeField;
            }
            set
            {
                this.contentTypeField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public T_WebDocumentDataType DataType
        {
            get
            {
                return this.dataTypeField;
            }
            set
            {
                this.dataTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("base64", typeof(byte[]), DataType = "base64Binary")]
        [System.Xml.Serialization.XmlElementAttribute("risdok", typeof(risdok))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]

    public enum T_WebDocumentContentType
    {

        /// <remarks/>
        MainDocument,

        /// <remarks/>
        Attachment,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]

    public partial class T_OGDWebDocument
    {

        private T_Applikation applikationField;

        private string dokumentnummerField;

        private string kurztitelField;

        private string kundmachungsorganField;

        private string typField;

        private string artikelParagraphAnlageField;

        private System.Nullable<System.DateTime> inkrafttretedatumField;

        private bool inkrafttretedatumFieldSpecified;

        private System.Nullable<System.DateTime> ausserkrafttretedatumField;

        private bool ausserkrafttretedatumFieldSpecified;

        private string abkuerzungField;

        private System.Nullable<System.DateTime> unterzeichnungsdatumField;

        private bool unterzeichnungsdatumFieldSpecified;

        private string[] indizesField;

        private string uebergangsrechtField;

        private string beachteZurGanzenRechtsvorschriftField;

        private string beachteField;

        private string aenderungField;

        private string langtitelField;

        private string sprachenField;

        private string staatenField;

        private string anmerkungZurGanzenRechtsvorschriftField;

        private string anmerkungField;

        private string schlagworteField;

        private System.Nullable<System.DateTime> veroeffentlichungsdatumField;

        private bool veroeffentlichungsdatumFieldSpecified;

        private System.Nullable<System.DateTime> aenderungsdatumField;

        private bool aenderungsdatumFieldSpecified;

        private string gesetzesnummerField;

        private string alteDokumentnummerField;

        private T_WebDocumentContentReference[] dokumentinhaltField;

        /// <remarks/>
        public T_Applikation Applikation
        {
            get
            {
                return this.applikationField;
            }
            set
            {
                this.applikationField = value;
            }
        }

        /// <remarks/>
        public string Dokumentnummer
        {
            get
            {
                return this.dokumentnummerField;
            }
            set
            {
                this.dokumentnummerField = value;
            }
        }

        /// <remarks/>
        public string Kurztitel
        {
            get
            {
                return this.kurztitelField;
            }
            set
            {
                this.kurztitelField = value;
            }
        }

        /// <remarks/>
        public string Kundmachungsorgan
        {
            get
            {
                return this.kundmachungsorganField;
            }
            set
            {
                this.kundmachungsorganField = value;
            }
        }

        /// <remarks/>
        public string Typ
        {
            get
            {
                return this.typField;
            }
            set
            {
                this.typField = value;
            }
        }

        /// <remarks/>
        public string ArtikelParagraphAnlage
        {
            get
            {
                return this.artikelParagraphAnlageField;
            }
            set
            {
                this.artikelParagraphAnlageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", IsNullable = true)]
        public System.Nullable<System.DateTime> Inkrafttretedatum
        {
            get
            {
                return this.inkrafttretedatumField;
            }
            set
            {
                this.inkrafttretedatumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InkrafttretedatumSpecified
        {
            get
            {
                return this.inkrafttretedatumFieldSpecified;
            }
            set
            {
                this.inkrafttretedatumFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", IsNullable = true)]
        public System.Nullable<System.DateTime> Ausserkrafttretedatum
        {
            get
            {
                return this.ausserkrafttretedatumField;
            }
            set
            {
                this.ausserkrafttretedatumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AusserkrafttretedatumSpecified
        {
            get
            {
                return this.ausserkrafttretedatumFieldSpecified;
            }
            set
            {
                this.ausserkrafttretedatumFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string Abkuerzung
        {
            get
            {
                return this.abkuerzungField;
            }
            set
            {
                this.abkuerzungField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", IsNullable = true)]
        public System.Nullable<System.DateTime> Unterzeichnungsdatum
        {
            get
            {
                return this.unterzeichnungsdatumField;
            }
            set
            {
                this.unterzeichnungsdatumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnterzeichnungsdatumSpecified
        {
            get
            {
                return this.unterzeichnungsdatumFieldSpecified;
            }
            set
            {
                this.unterzeichnungsdatumFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item")]
        public string[] Indizes
        {
            get
            {
                return this.indizesField;
            }
            set
            {
                this.indizesField = value;
            }
        }

        /// <remarks/>
        public string Uebergangsrecht
        {
            get
            {
                return this.uebergangsrechtField;
            }
            set
            {
                this.uebergangsrechtField = value;
            }
        }

        /// <remarks/>
        public string BeachteZurGanzenRechtsvorschrift
        {
            get
            {
                return this.beachteZurGanzenRechtsvorschriftField;
            }
            set
            {
                this.beachteZurGanzenRechtsvorschriftField = value;
            }
        }

        /// <remarks/>
        public string Beachte
        {
            get
            {
                return this.beachteField;
            }
            set
            {
                this.beachteField = value;
            }
        }

        /// <remarks/>
        public string Aenderung
        {
            get
            {
                return this.aenderungField;
            }
            set
            {
                this.aenderungField = value;
            }
        }

        /// <remarks/>
        public string Langtitel
        {
            get
            {
                return this.langtitelField;
            }
            set
            {
                this.langtitelField = value;
            }
        }

        /// <remarks/>
        public string Sprachen
        {
            get
            {
                return this.sprachenField;
            }
            set
            {
                this.sprachenField = value;
            }
        }

        /// <remarks/>
        public string Staaten
        {
            get
            {
                return this.staatenField;
            }
            set
            {
                this.staatenField = value;
            }
        }

        /// <remarks/>
        public string AnmerkungZurGanzenRechtsvorschrift
        {
            get
            {
                return this.anmerkungZurGanzenRechtsvorschriftField;
            }
            set
            {
                this.anmerkungZurGanzenRechtsvorschriftField = value;
            }
        }

        /// <remarks/>
        public string Anmerkung
        {
            get
            {
                return this.anmerkungField;
            }
            set
            {
                this.anmerkungField = value;
            }
        }

        /// <remarks/>
        public string Schlagworte
        {
            get
            {
                return this.schlagworteField;
            }
            set
            {
                this.schlagworteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", IsNullable = true)]
        public System.Nullable<System.DateTime> Veroeffentlichungsdatum
        {
            get
            {
                return this.veroeffentlichungsdatumField;
            }
            set
            {
                this.veroeffentlichungsdatumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VeroeffentlichungsdatumSpecified
        {
            get
            {
                return this.veroeffentlichungsdatumFieldSpecified;
            }
            set
            {
                this.veroeffentlichungsdatumFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", IsNullable = true)]
        public System.Nullable<System.DateTime> Aenderungsdatum
        {
            get
            {
                return this.aenderungsdatumField;
            }
            set
            {
                this.aenderungsdatumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AenderungsdatumSpecified
        {
            get
            {
                return this.aenderungsdatumFieldSpecified;
            }
            set
            {
                this.aenderungsdatumFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string Gesetzesnummer
        {
            get
            {
                return this.gesetzesnummerField;
            }
            set
            {
                this.gesetzesnummerField = value;
            }
        }

        /// <remarks/>
        public string AlteDokumentnummer
        {
            get
            {
                return this.alteDokumentnummerField;
            }
            set
            {
                this.alteDokumentnummerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ContentReference", IsNullable = false)]
        public T_WebDocumentContentReference[] Dokumentinhalt
        {
            get
            {
                return this.dokumentinhaltField;
            }
            set
            {
                this.dokumentinhaltField = value;
            }
        }
    }

    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class nutzdaten : IXmlSerializable
    {
        [XmlIgnore]
        public string Text { get; set; }

        public System.Xml.Schema.XmlSchema GetSchema()
        {
            throw new System.NotImplementedException();
        }

        public void ReadXml(System.Xml.XmlReader reader)
        {
            Text = reader.ReadInnerXml();
        }

        public void WriteXml(System.Xml.XmlWriter writer)
        {
            throw new System.NotImplementedException();
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class layoutdaten
    {

        private string classesField;

        private string paperfField;

        private string paperwField;

        private string paperhField;

        private string marglField;

        private string margrField;

        private string margtField;

        private string margbField;

        private string headerdField;

        private string footerdField;

        private string gutterField;

        private string gutterposField;

        private string deftabField;

        /// <remarks/>
        public string classes
        {
            get
            {
                return this.classesField;
            }
            set
            {
                this.classesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string paperf
        {
            get
            {
                return this.paperfField;
            }
            set
            {
                this.paperfField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string paperw
        {
            get
            {
                return this.paperwField;
            }
            set
            {
                this.paperwField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string paperh
        {
            get
            {
                return this.paperhField;
            }
            set
            {
                this.paperhField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string margl
        {
            get
            {
                return this.marglField;
            }
            set
            {
                this.marglField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string margr
        {
            get
            {
                return this.margrField;
            }
            set
            {
                this.margrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string margt
        {
            get
            {
                return this.margtField;
            }
            set
            {
                this.margtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string margb
        {
            get
            {
                return this.margbField;
            }
            set
            {
                this.margbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string headerd
        {
            get
            {
                return this.headerdField;
            }
            set
            {
                this.headerdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string footerd
        {
            get
            {
                return this.footerdField;
            }
            set
            {
                this.footerdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string gutter
        {
            get
            {
                return this.gutterField;
            }
            set
            {
                this.gutterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string gutterpos
        {
            get
            {
                return this.gutterposField;
            }
            set
            {
                this.gutterposField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string deftab
        {
            get
            {
                return this.deftabField;
            }
            set
            {
                this.deftabField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class DocumentResult
    {

        private object itemField;

        private DocumentResultStatus statusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Error", typeof(T_Error))]
        [System.Xml.Serialization.XmlElementAttribute("OGDDocumentMetadata", typeof(T_OGDWebDocument))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DocumentResultStatus status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum DocumentResultStatus
    {

        /// <remarks/>
        ok,

        /// <remarks/>
        error,
    }
}