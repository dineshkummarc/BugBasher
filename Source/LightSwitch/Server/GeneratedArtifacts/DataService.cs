﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Data Services
    
    /// <summary>
    /// Provides members to query and update data in the ApplicationData datasource.
    /// </summary>
    public sealed partial class ApplicationDataService
        : global::LightSwitchApplication.ApplicationData
    {
        #region Constructors
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public ApplicationDataService() : base()
        {
        }
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.Application Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Server Interceptions Points
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Bugs_CanInsert(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Bugs_CanUpdate(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Bugs_CanDelete(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Bugs_CanRead(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Bugs_Inserting(global::LightSwitchApplication.Bug entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Bugs_Inserted(global::LightSwitchApplication.Bug entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Bugs_Updating(global::LightSwitchApplication.Bug entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Bugs_Updated(global::LightSwitchApplication.Bug entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Bugs_Deleting(global::LightSwitchApplication.Bug entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Bugs_Deleted(global::LightSwitchApplication.Bug entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Bugs_Validate(global::LightSwitchApplication.Bug entity, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder results);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Bugs_Filter(ref global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Bug, bool>> filter);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Testers_CanInsert(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Testers_CanUpdate(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Testers_CanDelete(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Testers_CanRead(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Testers_Inserting(global::LightSwitchApplication.Tester entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Testers_Inserted(global::LightSwitchApplication.Tester entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Testers_Updating(global::LightSwitchApplication.Tester entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Testers_Updated(global::LightSwitchApplication.Tester entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Testers_Deleting(global::LightSwitchApplication.Tester entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Testers_Deleted(global::LightSwitchApplication.Tester entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Testers_Validate(global::LightSwitchApplication.Tester entity, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder results);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Testers_Filter(ref global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Tester, bool>> filter);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_CanExecute(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_Executing();
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_Executed();
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_ExecuteFailed(global::System.Exception exception);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Query_Executing(global::Microsoft.LightSwitch.QueryExecutingDescriptor queryDescriptor);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Query_Executed(global::Microsoft.LightSwitch.QueryExecutedDescriptor queryDescriptor);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Query_ExecuteFailed(global::Microsoft.LightSwitch.QueryExecuteFailedDescriptor queryDescriptor);
    
        #endregion
    
        #region Details Class
    
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public static new class DetailsClass
        {
    
            static DetailsClass()
            {
            }
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Bug>
                __BugsEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Bug>(
                    "Bugs",
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Bugs_CanInsert,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Bugs_CanUpdate,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Bugs_CanDelete,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Bugs_CanRead,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Bugs_Inserting,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Bugs_Inserted,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Bugs_Updating,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Bugs_Updated,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Bugs_Deleting,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Bugs_Deleted,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Bugs_Validate,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Bugs_Filter);
            private static bool __Bugs_CanInsert(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Bugs_CanInsert(ref result);
                return result;
            }
            private static bool __Bugs_CanUpdate(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Bugs_CanUpdate(ref result);
                return result;
            }
            private static bool __Bugs_CanDelete(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Bugs_CanDelete(ref result);
                return result;
            }
            private static bool __Bugs_CanRead(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Bugs_CanRead(ref result);
                return result;
            }
            private static void __Bugs_Inserting(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Bug e)
            {
                d.Bugs_Inserting(e);
            }
            private static void __Bugs_Inserted(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Bug e)
            {
                d.Bugs_Inserted(e);
            }
            private static void __Bugs_Updating(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Bug e)
            {
                d.Bugs_Updating(e);
            }
            private static void __Bugs_Updated(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Bug e)
            {
                d.Bugs_Updated(e);
            }
            private static void __Bugs_Deleting(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Bug e)
            {
                d.Bugs_Deleting(e);
            }
            private static void __Bugs_Deleted(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Bug e)
            {
                d.Bugs_Deleted(e);
            }
            private static void __Bugs_Validate(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Bug e, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder r)
            {
                d.Bugs_Validate(e, r);
            }
            private static global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Bug, bool>> __Bugs_Filter(global::LightSwitchApplication.ApplicationDataService d)
            {
                global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Bug, bool>> filter = null;
                d.Bugs_Filter(ref filter);
                return filter;
            }
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Tester>
                __TestersEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Tester>(
                    "Testers",
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Testers_CanInsert,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Testers_CanUpdate,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Testers_CanDelete,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Testers_CanRead,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Testers_Inserting,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Testers_Inserted,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Testers_Updating,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Testers_Updated,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Testers_Deleting,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Testers_Deleted,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Testers_Validate,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Testers_Filter);
            private static bool __Testers_CanInsert(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Testers_CanInsert(ref result);
                return result;
            }
            private static bool __Testers_CanUpdate(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Testers_CanUpdate(ref result);
                return result;
            }
            private static bool __Testers_CanDelete(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Testers_CanDelete(ref result);
                return result;
            }
            private static bool __Testers_CanRead(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Testers_CanRead(ref result);
                return result;
            }
            private static void __Testers_Inserting(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Tester e)
            {
                d.Testers_Inserting(e);
            }
            private static void __Testers_Inserted(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Tester e)
            {
                d.Testers_Inserted(e);
            }
            private static void __Testers_Updating(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Tester e)
            {
                d.Testers_Updating(e);
            }
            private static void __Testers_Updated(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Tester e)
            {
                d.Testers_Updated(e);
            }
            private static void __Testers_Deleting(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Tester e)
            {
                d.Testers_Deleting(e);
            }
            private static void __Testers_Deleted(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Tester e)
            {
                d.Testers_Deleted(e);
            }
            private static void __Testers_Validate(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Tester e, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder r)
            {
                d.Testers_Validate(e, r);
            }
            private static global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Tester, bool>> __Testers_Filter(global::LightSwitchApplication.ApplicationDataService d)
            {
                global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Tester, bool>> filter = null;
                d.Testers_Filter(ref filter);
                return filter;
            }
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.OperationEntry<global::LightSwitchApplication.ApplicationDataService>
                __SaveChangesEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.OperationEntry<global::LightSwitchApplication.ApplicationDataService>(
                    "SaveChanges",
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SaveChanges_CanExecute,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SaveChanges_Executing,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SaveChanges_Executed,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SaveChanges_Failed);
            private static bool __SaveChanges_CanExecute(global::LightSwitchApplication.ApplicationDataService d, bool r)
            {
                d.SaveChanges_CanExecute(ref r);
                return r;
            }
            private static void __SaveChanges_Executing(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.SaveChanges_Executing();
            }
            private static void __SaveChanges_Executed(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.SaveChanges_Executed();
            }
            private static void __SaveChanges_Failed(global::LightSwitchApplication.ApplicationDataService d, object[] args, global::System.Exception ex)
            {
                d.SaveChanges_ExecuteFailed(ex);
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.QueryEntry<global::LightSwitchApplication.ApplicationDataService>
                ___QueryEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.QueryEntry<global::LightSwitchApplication.ApplicationDataService>(
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Query_Executing,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Query_Executed,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Query_Failed);
            private static void __Query_Executing(global::LightSwitchApplication.ApplicationDataService d, global::Microsoft.LightSwitch.QueryExecutingDescriptor queryDescriptor)
            {
                d.Query_Executing(queryDescriptor);
            }
            private static void __Query_Executed(global::LightSwitchApplication.ApplicationDataService d, global::Microsoft.LightSwitch.QueryExecutedDescriptor queryDescriptor)
            {
                d.Query_Executed(queryDescriptor);
            }
            private static void __Query_Failed(global::LightSwitchApplication.ApplicationDataService d, global::Microsoft.LightSwitch.QueryExecuteFailedDescriptor queryDescriptor)
            {
                d.Query_ExecuteFailed(queryDescriptor);
            }
        }
    
        #endregion
    }
    
    #endregion
}