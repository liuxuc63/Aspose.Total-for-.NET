﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18033.
// 
#pragma warning disable 1591

namespace Aspose.CreateProjectWizard.com.aspose.community {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="AsposeDownloadsSoap", Namespace="http://aspose.com/")]
    public partial class AsposeDownloads : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetProductReleaseOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetProductResourceFileOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public AsposeDownloads() {
            this.Url = global::Aspose.CreateProjectWizard.Properties.Settings.Default.Aspose_CreateProjectWizard_com_aspose_community_AsposeDownloads;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetProductReleaseCompletedEventHandler GetProductReleaseCompleted;
        
        /// <remarks/>
        public event GetProductResourceFileCompletedEventHandler GetProductResourceFileCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://aspose.com/GetProductRelease", RequestNamespace="http://aspose.com/", ResponseNamespace="http://aspose.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ProductRelease GetProductRelease(string platform, string productName) {
            object[] results = this.Invoke("GetProductRelease", new object[] {
                        platform,
                        productName});
            return ((ProductRelease)(results[0]));
        }
        
        /// <remarks/>
        public void GetProductReleaseAsync(string platform, string productName) {
            this.GetProductReleaseAsync(platform, productName, null);
        }
        
        /// <remarks/>
        public void GetProductReleaseAsync(string platform, string productName, object userState) {
            if ((this.GetProductReleaseOperationCompleted == null)) {
                this.GetProductReleaseOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetProductReleaseOperationCompleted);
            }
            this.InvokeAsync("GetProductRelease", new object[] {
                        platform,
                        productName}, this.GetProductReleaseOperationCompleted, userState);
        }
        
        private void OnGetProductReleaseOperationCompleted(object arg) {
            if ((this.GetProductReleaseCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetProductReleaseCompleted(this, new GetProductReleaseCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://aspose.com/GetProductResourceFile", RequestNamespace="http://aspose.com/", ResponseNamespace="http://aspose.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ProductRelease GetProductResourceFile(string platform, string productName) {
            object[] results = this.Invoke("GetProductResourceFile", new object[] {
                        platform,
                        productName});
            return ((ProductRelease)(results[0]));
        }
        
        /// <remarks/>
        public void GetProductResourceFileAsync(string platform, string productName) {
            this.GetProductResourceFileAsync(platform, productName, null);
        }
        
        /// <remarks/>
        public void GetProductResourceFileAsync(string platform, string productName, object userState) {
            if ((this.GetProductResourceFileOperationCompleted == null)) {
                this.GetProductResourceFileOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetProductResourceFileOperationCompleted);
            }
            this.InvokeAsync("GetProductResourceFile", new object[] {
                        platform,
                        productName}, this.GetProductResourceFileOperationCompleted, userState);
        }
        
        private void OnGetProductResourceFileOperationCompleted(object arg) {
            if ((this.GetProductResourceFileCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetProductResourceFileCompleted(this, new GetProductResourceFileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://aspose.com/")]
    public partial class ProductRelease {
        
        private string fileNameField;
        
        private string versionNumberField;
        
        private string changeLogField;
        
        private string downloadLinkField;
        
        /// <remarks/>
        public string FileName {
            get {
                return this.fileNameField;
            }
            set {
                this.fileNameField = value;
            }
        }
        
        /// <remarks/>
        public string VersionNumber {
            get {
                return this.versionNumberField;
            }
            set {
                this.versionNumberField = value;
            }
        }
        
        /// <remarks/>
        public string ChangeLog {
            get {
                return this.changeLogField;
            }
            set {
                this.changeLogField = value;
            }
        }
        
        /// <remarks/>
        public string DownloadLink {
            get {
                return this.downloadLinkField;
            }
            set {
                this.downloadLinkField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetProductReleaseCompletedEventHandler(object sender, GetProductReleaseCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetProductReleaseCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetProductReleaseCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ProductRelease Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ProductRelease)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetProductResourceFileCompletedEventHandler(object sender, GetProductResourceFileCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetProductResourceFileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetProductResourceFileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ProductRelease Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ProductRelease)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591