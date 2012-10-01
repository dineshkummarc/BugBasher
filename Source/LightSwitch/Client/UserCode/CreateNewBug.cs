using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
using Microsoft.LightSwitch.Client;

namespace LightSwitchApplication
{
    public partial class CreateNewBug
    {
        partial void CreateNewBug_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            var bug = new Bug();

            var applicationData = DataWorkspace.ApplicationData;

            var tester = (from testers in applicationData.Testers
                          where testers.UserName == Application.Current.User.Name
                          select testers).SingleOrDefault();
            
            if (tester == null)
            {
                tester = applicationData.Testers.AddNew();
                tester.UserName = Application.Current.User.Name;
                
            }

            bug.Tester = tester;
            bug.Status = "New";
            
            this.BugProperty = bug;
            
        }

        partial void CreateNewBug_Saved()
        {
            this.Close(false);

            IEnumerable<IActiveScreen> searchScreens = Application.ActiveScreens.Where(a => a.Screen is SearchBugs);

            foreach (var screen in searchScreens)
            {
                screen.Screen.Details.Dispatcher.BeginInvoke(() =>
                {
                    ((SearchBugs)screen.Screen).Bugs.Refresh();
                });
            }

            Application.Current.ShowSearchBugs();
        }

        partial void CreateNewBug_Saving(ref bool handled)
        {
            // Write your code here.

        }
    }
}