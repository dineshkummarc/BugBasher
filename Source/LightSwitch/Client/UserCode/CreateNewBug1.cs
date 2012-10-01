using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;

namespace LightSwitchApplication
{
    public partial class CreateNewBug1
    {
        partial void CreateNewBug1_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            // Write your code here.
            this.BugProperty = new Bug();
        }

        partial void CreateNewBug1_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.BugProperty);
        }

        partial void CreateNewBug1_Created()
        {
            // Write your code here.

        }
    }
}