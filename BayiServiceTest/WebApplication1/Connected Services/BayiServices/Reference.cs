﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BayiServices
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthInfo", Namespace="http://schemas.datacontract.org/2004/07/Vektora.CMS.API.BayiIntegration")]
    public partial class AuthInfo : object
    {
        
        private string PasswordField;
        
        private string UsernameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password
        {
            get
            {
                return this.PasswordField;
            }
            set
            {
                this.PasswordField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username
        {
            get
            {
                return this.UsernameField;
            }
            set
            {
                this.UsernameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductFor3rdParty", Namespace="http://schemas.datacontract.org/2004/07/Vektora.CMS.DAL.Core")]
    public partial class ProductFor3rdParty : object
    {
        
        private string BrandNameField;
        
        private System.Nullable<int> Category3IDField;
        
        private string CategoryBreadcrumbField;
        
        private string CategoryNameField;
        
        private decimal DiscountPriceField;
        
        private string DisplayNameField;
        
        private BayiServices.CmsContentWithImage[] GeneralInfoBoxesField;
        
        private string[] ImageUrlField;
        
        private string[] MajorPropertiesField;
        
        private BayiServices.CmsContentWithImage[] PictogramSummaryField;
        
        private BayiServices.CmsContentWithImage[] PictogramsField;
        
        private decimal PriceField;
        
        private string ProductCodeField;
        
        private System.Nullable<int> ProductIDField;
        
        private System.Nullable<int> SortField;
        
        private string[] TechInfoSummaryField;
        
        private BayiServices.TechnicalInfoProperty[] TechnicalInfoPropertiesField;
        
        private string UrlField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BrandName
        {
            get
            {
                return this.BrandNameField;
            }
            set
            {
                this.BrandNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Category3ID
        {
            get
            {
                return this.Category3IDField;
            }
            set
            {
                this.Category3IDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CategoryBreadcrumb
        {
            get
            {
                return this.CategoryBreadcrumbField;
            }
            set
            {
                this.CategoryBreadcrumbField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CategoryName
        {
            get
            {
                return this.CategoryNameField;
            }
            set
            {
                this.CategoryNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal DiscountPrice
        {
            get
            {
                return this.DiscountPriceField;
            }
            set
            {
                this.DiscountPriceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DisplayName
        {
            get
            {
                return this.DisplayNameField;
            }
            set
            {
                this.DisplayNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BayiServices.CmsContentWithImage[] GeneralInfoBoxes
        {
            get
            {
                return this.GeneralInfoBoxesField;
            }
            set
            {
                this.GeneralInfoBoxesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] ImageUrl
        {
            get
            {
                return this.ImageUrlField;
            }
            set
            {
                this.ImageUrlField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] MajorProperties
        {
            get
            {
                return this.MajorPropertiesField;
            }
            set
            {
                this.MajorPropertiesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BayiServices.CmsContentWithImage[] PictogramSummary
        {
            get
            {
                return this.PictogramSummaryField;
            }
            set
            {
                this.PictogramSummaryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BayiServices.CmsContentWithImage[] Pictograms
        {
            get
            {
                return this.PictogramsField;
            }
            set
            {
                this.PictogramsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price
        {
            get
            {
                return this.PriceField;
            }
            set
            {
                this.PriceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductCode
        {
            get
            {
                return this.ProductCodeField;
            }
            set
            {
                this.ProductCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ProductID
        {
            get
            {
                return this.ProductIDField;
            }
            set
            {
                this.ProductIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Sort
        {
            get
            {
                return this.SortField;
            }
            set
            {
                this.SortField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] TechInfoSummary
        {
            get
            {
                return this.TechInfoSummaryField;
            }
            set
            {
                this.TechInfoSummaryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BayiServices.TechnicalInfoProperty[] TechnicalInfoProperties
        {
            get
            {
                return this.TechnicalInfoPropertiesField;
            }
            set
            {
                this.TechnicalInfoPropertiesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Url
        {
            get
            {
                return this.UrlField;
            }
            set
            {
                this.UrlField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CmsContentWithImage", Namespace="http://schemas.datacontract.org/2004/07/Vektora.CMS.API.Library")]
    public partial class CmsContentWithImage : object
    {
        
        private string HtmlField;
        
        private string ImageField;
        
        private string TitleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Html
        {
            get
            {
                return this.HtmlField;
            }
            set
            {
                this.HtmlField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Image
        {
            get
            {
                return this.ImageField;
            }
            set
            {
                this.ImageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title
        {
            get
            {
                return this.TitleField;
            }
            set
            {
                this.TitleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TechnicalInfoProperty", Namespace="http://schemas.datacontract.org/2004/07/Vektora.CMS.DAL.CachedRepos")]
    public partial class TechnicalInfoProperty : object
    {
        
        private string HeaderField;
        
        private System.Tuple<string, string>[] PropertiesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Header
        {
            get
            {
                return this.HeaderField;
            }
            set
            {
                this.HeaderField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Tuple<string, string>[] Properties
        {
            get
            {
                return this.PropertiesField;
            }
            set
            {
                this.PropertiesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CategoryFor3rdParty", Namespace="http://schemas.datacontract.org/2004/07/Vektora.CMS.DAL.Core")]
    public partial class CategoryFor3rdParty : object
    {
        
        private int CategoryIDField;
        
        private string DisplayNameField;
        
        private string ImageField;
        
        private string Image2Field;
        
        private BayiServices.CategoryFor3rdParty[] SubCategoriesField;
        
        private string URLField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CategoryID
        {
            get
            {
                return this.CategoryIDField;
            }
            set
            {
                this.CategoryIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DisplayName
        {
            get
            {
                return this.DisplayNameField;
            }
            set
            {
                this.DisplayNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Image
        {
            get
            {
                return this.ImageField;
            }
            set
            {
                this.ImageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Image2
        {
            get
            {
                return this.Image2Field;
            }
            set
            {
                this.Image2Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BayiServices.CategoryFor3rdParty[] SubCategories
        {
            get
            {
                return this.SubCategoriesField;
            }
            set
            {
                this.SubCategoriesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string URL
        {
            get
            {
                return this.URLField;
            }
            set
            {
                this.URLField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FilterHolder", Namespace="http://schemas.datacontract.org/2004/07/Vektora.CMS.DAL.CachedRepos")]
    public partial class FilterHolder : object
    {
        
        private string DisplayNameField;
        
        private BayiServices.FilterItem[] FilterItemsField;
        
        private int PropertyIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DisplayName
        {
            get
            {
                return this.DisplayNameField;
            }
            set
            {
                this.DisplayNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BayiServices.FilterItem[] FilterItems
        {
            get
            {
                return this.FilterItemsField;
            }
            set
            {
                this.FilterItemsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PropertyId
        {
            get
            {
                return this.PropertyIdField;
            }
            set
            {
                this.PropertyIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FilterItem", Namespace="http://schemas.datacontract.org/2004/07/Vektora.CMS.DAL.CachedRepos")]
    public partial class FilterItem : object
    {
        
        private string FilterValueField;
        
        private string TextField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FilterValue
        {
            get
            {
                return this.FilterValueField;
            }
            set
            {
                this.FilterValueField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text
        {
            get
            {
                return this.TextField;
            }
            set
            {
                this.TextField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductInstallments", Namespace="http://schemas.datacontract.org/2004/07/Vektora.CMS.API.Library.Common")]
    public partial class ProductInstallments : object
    {
        
        private string BankNameField;
        
        private BayiServices.BankListPrice[] InstallmentPricesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BankName
        {
            get
            {
                return this.BankNameField;
            }
            set
            {
                this.BankNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BayiServices.BankListPrice[] InstallmentPrices
        {
            get
            {
                return this.InstallmentPricesField;
            }
            set
            {
                this.InstallmentPricesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BankListPrice", Namespace="http://schemas.datacontract.org/2004/07/Vektora.CMS.API.Library.Common")]
    public partial class BankListPrice : object
    {
        
        private string BankColorField;
        
        private int BankInstallmentField;
        
        private string BankNameField;
        
        private System.Nullable<decimal> InstallmenPriceField;
        
        private int sortField;
        
        private decimal totalPriceField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BankColor
        {
            get
            {
                return this.BankColorField;
            }
            set
            {
                this.BankColorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BankInstallment
        {
            get
            {
                return this.BankInstallmentField;
            }
            set
            {
                this.BankInstallmentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BankName
        {
            get
            {
                return this.BankNameField;
            }
            set
            {
                this.BankNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> InstallmenPrice
        {
            get
            {
                return this.InstallmenPriceField;
            }
            set
            {
                this.InstallmenPriceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int sort
        {
            get
            {
                return this.sortField;
            }
            set
            {
                this.sortField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal totalPrice
        {
            get
            {
                return this.totalPriceField;
            }
            set
            {
                this.totalPriceField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VestelBanner", Namespace="http://schemas.datacontract.org/2004/07/Vektora.CMS.API.Library.CMS")]
    public partial class VestelBanner : object
    {
        
        private string VestelBannerDetailLinkField;
        
        private string VestelBannerHTMLDescriptionField;
        
        private string VestelBannerHTMLTitleField;
        
        private string VestelBannerImageField;
        
        private string VestelBannerVideoField;
        
        private string VestelBannerVideoLinkField;
        
        private string VestelBannerVideoWebmField;
        
        private string VestelYeniBannerMobileImageField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VestelBannerDetailLink
        {
            get
            {
                return this.VestelBannerDetailLinkField;
            }
            set
            {
                this.VestelBannerDetailLinkField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VestelBannerHTMLDescription
        {
            get
            {
                return this.VestelBannerHTMLDescriptionField;
            }
            set
            {
                this.VestelBannerHTMLDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VestelBannerHTMLTitle
        {
            get
            {
                return this.VestelBannerHTMLTitleField;
            }
            set
            {
                this.VestelBannerHTMLTitleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VestelBannerImage
        {
            get
            {
                return this.VestelBannerImageField;
            }
            set
            {
                this.VestelBannerImageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VestelBannerVideo
        {
            get
            {
                return this.VestelBannerVideoField;
            }
            set
            {
                this.VestelBannerVideoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VestelBannerVideoLink
        {
            get
            {
                return this.VestelBannerVideoLinkField;
            }
            set
            {
                this.VestelBannerVideoLinkField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VestelBannerVideoWebm
        {
            get
            {
                return this.VestelBannerVideoWebmField;
            }
            set
            {
                this.VestelBannerVideoWebmField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VestelYeniBannerMobileImage
        {
            get
            {
                return this.VestelYeniBannerMobileImageField;
            }
            set
            {
                this.VestelYeniBannerMobileImageField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VestelCampaignItem", Namespace="http://schemas.datacontract.org/2004/07/Vektora.CMS.API.Library.CMS")]
    public partial class VestelCampaignItem : object
    {
        
        private string CampaignDefaultTemplateBaslikTextField;
        
        private string CampaignDefaultTemplateButtonLinkField;
        
        private string CampaignDefaultTemplateIcerikTextField;
        
        private string CampaignDefaultTemplateImageField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CampaignDefaultTemplateBaslikText
        {
            get
            {
                return this.CampaignDefaultTemplateBaslikTextField;
            }
            set
            {
                this.CampaignDefaultTemplateBaslikTextField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CampaignDefaultTemplateButtonLink
        {
            get
            {
                return this.CampaignDefaultTemplateButtonLinkField;
            }
            set
            {
                this.CampaignDefaultTemplateButtonLinkField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CampaignDefaultTemplateIcerikText
        {
            get
            {
                return this.CampaignDefaultTemplateIcerikTextField;
            }
            set
            {
                this.CampaignDefaultTemplateIcerikTextField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CampaignDefaultTemplateImage
        {
            get
            {
                return this.CampaignDefaultTemplateImageField;
            }
            set
            {
                this.CampaignDefaultTemplateImageField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BayiServices.IService")]
    public interface IService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetProductsOfCategory", ReplyAction="http://tempuri.org/IService/GetProductsOfCategoryResponse")]
        System.Threading.Tasks.Task<BayiServices.ProductFor3rdParty[]> GetProductsOfCategoryAsync(BayiServices.AuthInfo authToken, int category3ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetCategories", ReplyAction="http://tempuri.org/IService/GetCategoriesResponse")]
        System.Threading.Tasks.Task<BayiServices.CategoryFor3rdParty[]> GetCategoriesAsync(BayiServices.AuthInfo authToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetCategoryFilters", ReplyAction="http://tempuri.org/IService/GetCategoryFiltersResponse")]
        System.Threading.Tasks.Task<BayiServices.FilterHolder[]> GetCategoryFiltersAsync(BayiServices.AuthInfo authToken, int category3ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetProductPaymentOptions", ReplyAction="http://tempuri.org/IService/GetProductPaymentOptionsResponse")]
        System.Threading.Tasks.Task<BayiServices.ProductInstallments[]> GetProductPaymentOptionsAsync(BayiServices.AuthInfo authToken, string ProductCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetBanners", ReplyAction="http://tempuri.org/IService/GetBannersResponse")]
        System.Threading.Tasks.Task<BayiServices.VestelBanner[]> GetBannersAsync(BayiServices.AuthInfo authToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetCampaigns", ReplyAction="http://tempuri.org/IService/GetCampaignsResponse")]
        System.Threading.Tasks.Task<BayiServices.VestelCampaignItem[]> GetCampaignsAsync(BayiServices.AuthInfo authToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetBayiValidateLink", ReplyAction="http://tempuri.org/IService/GetBayiValidateLinkResponse")]
        System.Threading.Tasks.Task<string> GetBayiValidateLinkAsync(BayiServices.AuthInfo authToken);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    public interface IServiceChannel : BayiServices.IService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<BayiServices.IService>, BayiServices.IService
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ServiceClient() : 
                base(ServiceClient.GetDefaultBinding(), ServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(ServiceClient.GetBindingForEndpoint(endpointConfiguration), ServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<BayiServices.ProductFor3rdParty[]> GetProductsOfCategoryAsync(BayiServices.AuthInfo authToken, int category3ID)
        {
            return base.Channel.GetProductsOfCategoryAsync(authToken, category3ID);
        }
        
        public System.Threading.Tasks.Task<BayiServices.CategoryFor3rdParty[]> GetCategoriesAsync(BayiServices.AuthInfo authToken)
        {
            return base.Channel.GetCategoriesAsync(authToken);
        }
        
        public System.Threading.Tasks.Task<BayiServices.FilterHolder[]> GetCategoryFiltersAsync(BayiServices.AuthInfo authToken, int category3ID)
        {
            return base.Channel.GetCategoryFiltersAsync(authToken, category3ID);
        }
        
        public System.Threading.Tasks.Task<BayiServices.ProductInstallments[]> GetProductPaymentOptionsAsync(BayiServices.AuthInfo authToken, string ProductCode)
        {
            return base.Channel.GetProductPaymentOptionsAsync(authToken, ProductCode);
        }
        
        public System.Threading.Tasks.Task<BayiServices.VestelBanner[]> GetBannersAsync(BayiServices.AuthInfo authToken)
        {
            return base.Channel.GetBannersAsync(authToken);
        }
        
        public System.Threading.Tasks.Task<BayiServices.VestelCampaignItem[]> GetCampaignsAsync(BayiServices.AuthInfo authToken)
        {
            return base.Channel.GetCampaignsAsync(authToken);
        }
        
        public System.Threading.Tasks.Task<string> GetBayiValidateLinkAsync(BayiServices.AuthInfo authToken)
        {
            return base.Channel.GetBayiValidateLinkAsync(authToken);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService))
            {
                return new System.ServiceModel.EndpointAddress("http://212.29.90.76/bayiservices/Service.svc/soap");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IService,
        }
    }
}