//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 4/29/2013 8:22:54 PM
namespace U2PhoneApp.U2_CodeFirst_oData_Service
{
    
    /// <summary>
    /// There are no comments for ProductContext in the schema.
    /// </summary>
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public partial class ProductContext : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new ProductContext object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public ProductContext(global::System.Uri serviceRoot) : 
                base(serviceRoot)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("WebApplication_vs2010_oData", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("U2PhoneApp.U2_CodeFirst_oData_Service", typeName.Substring(27)), false);
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("U2PhoneApp.U2_CodeFirst_oData_Service", global::System.StringComparison.Ordinal))
            {
                return string.Concat("WebApplication_vs2010_oData.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for Products in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Product> Products
        {
            get
            {
                if ((this._Products == null))
                {
                    this._Products = base.CreateQuery<Product>("Products");
                }
                return this._Products;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Product> _Products;
        /// <summary>
        /// There are no comments for Awards in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Award> Awards
        {
            get
            {
                if ((this._Awards == null))
                {
                    this._Awards = base.CreateQuery<Award>("Awards");
                }
                return this._Awards;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Award> _Awards;
        /// <summary>
        /// There are no comments for Products in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToProducts(Product product)
        {
            base.AddObject("Products", product);
        }
        /// <summary>
        /// There are no comments for Awards in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToAwards(Award award)
        {
            base.AddObject("Awards", award);
        }
    }
    /// <summary>
    /// There are no comments for WebApplication_vs2010_oData.Product in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ProductId
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Products")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("ProductId")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public partial class Product : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Product object.
        /// </summary>
        /// <param name="productId">Initial value of ProductId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Product CreateProduct(decimal productId)
        {
            Product product = new Product();
            product.ProductId = productId;
            return product;
        }
        /// <summary>
        /// There are no comments for Property ProductId in the schema.
        /// </summary>
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public decimal ProductId
        {
            get
            {
                return this._ProductId;
            }
            set
            {
                this.OnProductIdChanging(value);
                this._ProductId = value;
                this.OnProductIdChanged();
                this.OnPropertyChanged("ProductId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private decimal _ProductId;
        partial void OnProductIdChanging(decimal value);
        partial void OnProductIdChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property Rating in the schema.
        /// </summary>
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Rating
        {
            get
            {
                return this._Rating;
            }
            set
            {
                this.OnRatingChanging(value);
                this._Rating = value;
                this.OnRatingChanged();
                this.OnPropertyChanged("Rating");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Rating;
        partial void OnRatingChanging(string value);
        partial void OnRatingChanged();
        /// <summary>
        /// There are no comments for Property Image in the schema.
        /// </summary>
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Image
        {
            get
            {
                return this._Image;
            }
            set
            {
                this.OnImageChanging(value);
                this._Image = value;
                this.OnImageChanged();
                this.OnPropertyChanged("Image");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Image;
        partial void OnImageChanging(string value);
        partial void OnImageChanged();
        /// <summary>
        /// There are no comments for Awards in the schema.
        /// </summary>
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<Award> Awards
        {
            get
            {
                return this._Awards;
            }
            set
            {
                this._Awards = value;
                this.OnPropertyChanged("Awards");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<Award> _Awards = new global::System.Data.Services.Client.DataServiceCollection<Award>(null, global::System.Data.Services.Client.TrackingMode.None);
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for WebApplication_vs2010_oData.Award in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ASSOC_ROW
    /// ProductId
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Awards")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("ASSOC_ROW", "ProductId")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public partial class Award : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Award object.
        /// </summary>
        /// <param name="aSSOC_ROW">Initial value of ASSOC_ROW.</param>
        /// <param name="productId">Initial value of ProductId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Award CreateAward(decimal aSSOC_ROW, decimal productId)
        {
            Award award = new Award();
            award.ASSOC_ROW = aSSOC_ROW;
            award.ProductId = productId;
            return award;
        }
        /// <summary>
        /// There are no comments for Property ASSOC_ROW in the schema.
        /// </summary>
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public decimal ASSOC_ROW
        {
            get
            {
                return this._ASSOC_ROW;
            }
            set
            {
                this.OnASSOC_ROWChanging(value);
                this._ASSOC_ROW = value;
                this.OnASSOC_ROWChanged();
                this.OnPropertyChanged("ASSOC_ROW");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private decimal _ASSOC_ROW;
        partial void OnASSOC_ROWChanging(decimal value);
        partial void OnASSOC_ROWChanged();
        /// <summary>
        /// There are no comments for Property ProductId in the schema.
        /// </summary>
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public decimal ProductId
        {
            get
            {
                return this._ProductId;
            }
            set
            {
                this.OnProductIdChanging(value);
                this._ProductId = value;
                this.OnProductIdChanged();
                this.OnPropertyChanged("ProductId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private decimal _ProductId;
        partial void OnProductIdChanging(decimal value);
        partial void OnProductIdChanged();
        /// <summary>
        /// There are no comments for Property AwardName in the schema.
        /// </summary>
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string AwardName
        {
            get
            {
                return this._AwardName;
            }
            set
            {
                this.OnAwardNameChanging(value);
                this._AwardName = value;
                this.OnAwardNameChanged();
                this.OnPropertyChanged("AwardName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _AwardName;
        partial void OnAwardNameChanging(string value);
        partial void OnAwardNameChanged();
        /// <summary>
        /// There are no comments for Property AwardType in the schema.
        /// </summary>
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string AwardType
        {
            get
            {
                return this._AwardType;
            }
            set
            {
                this.OnAwardTypeChanging(value);
                this._AwardType = value;
                this.OnAwardTypeChanged();
                this.OnPropertyChanged("AwardType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _AwardType;
        partial void OnAwardTypeChanging(string value);
        partial void OnAwardTypeChanged();
        /// <summary>
        /// There are no comments for Product in the schema.
        /// </summary>
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Product Product
        {
            get
            {
                return this._Product;
            }
            set
            {
                this._Product = value;
                this.OnPropertyChanged("Product");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private Product _Product;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
