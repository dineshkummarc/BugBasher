﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication.Implementation
{
    
    #region Bug
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ApplicationData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Bug :
        global::LightSwitchApplication.Bug.DetailsClass.IImplementation
    {
        partial void OnBug_TesterChanged()
        {
            this.___OnPropertyChanged("Bug_Tester");
            this.___OnPropertyChanged("Tester");
        }
        
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnRowVersionChanged()
        {
            this.___OnPropertyChanged("RowVersion");
        }
        
        partial void OnSummaryChanged()
        {
            this.___OnPropertyChanged("Summary");
        }
        
        partial void OnDetailChanged()
        {
            this.___OnPropertyChanged("Detail");
        }
        
        partial void OnPageChanged()
        {
            this.___OnPropertyChanged("Page");
        }
        
        partial void OnStepsToReproduceChanged()
        {
            this.___OnPropertyChanged("StepsToReproduce");
        }
        
        partial void OnDateLoggedChanged()
        {
            this.___OnPropertyChanged("DateLogged");
        }
        
        partial void OnStatusChanged()
        {
            this.___OnPropertyChanged("Status");
        }
        
        partial void OnImageChanged()
        {
            this.___OnPropertyChanged("Image");
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Bug.DetailsClass.IImplementation.Tester
        {
            get
            {
                return this.Tester;
            }
            set
            {
                this.Tester = (global::LightSwitchApplication.Implementation.Tester)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Tester> __Tester
        {
            get
            {
                if (this.___Tester == null)
                {
                    this.___Tester = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Tester>(
                        this,
                        "Tester",
                        new string[] { "Bug_Tester" },
                        e => global::System.Object.Equals(e.Id, this.Bug_Tester),
                        () => this._Tester,
                        e => this._Tester = e);
                }
                return this.___Tester;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Tester> ___Tester;
        
    }
    #endregion
    
    #region Tester
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ApplicationData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Tester :
        global::LightSwitchApplication.Tester.DetailsClass.IImplementation
    {
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnRowVersionChanged()
        {
            this.___OnPropertyChanged("RowVersion");
        }
        
        partial void OnUserNameChanged()
        {
            this.___OnPropertyChanged("UserName");
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Tester.DetailsClass.IImplementation.Bugs
        {
            get
            {
                return this.Bugs;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Bug> __Bugs
        {
            get
            {
                if (this.___Bugs == null)
                {
                    this.___Bugs = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Bug>(
                        this,
                        "Bugs",
                        () => this._Bugs,
                        e => global::System.Object.Equals(e.Bug_Tester, this.Id));
                }
                return this.___Bugs;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Bug> ___Bugs;
        
    }
    #endregion
    
    #region ApplicationDataObjectContext
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class ApplicationDataObjectContext
    {
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.Bug))
            {
                return new global::LightSwitchApplication.Implementation.Bug();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Tester))
            {
                return new global::LightSwitchApplication.Implementation.Tester();
            }
            return null;
        }
    }
    #endregion
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class DataServiceFactory :
        global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.ApplicationData();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.Implementation.ApplicationDataObjectContext(global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceContext.CreateServiceUri("../ApplicationData.svc"));
            }
            return base.CreateDataServiceImplementation(dataService);
        }
    }
    #endregion
    
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.ITypeMappingProvider))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __TypeMapping
        : global::Microsoft.LightSwitch.Internal.ITypeMappingProvider
    {
        global::System.Type global::Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType(global::System.Type definitionType)
        {
            if (typeof(global::LightSwitchApplication.Bug) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Bug);
            }
            if (typeof(global::LightSwitchApplication.Tester) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Tester);
            }
            return null;
        }
    }
}
