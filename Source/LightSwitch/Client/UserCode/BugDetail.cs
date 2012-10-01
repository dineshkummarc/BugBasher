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
    public partial class BugDetail
    {
        partial void Bug_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Bug);
        }

        partial void Bug_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Bug);
        }

        partial void BugDetail_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Bug);
        }

        partial void Delete_CanExecute(ref bool result)
        {
            

        }

        partial void Delete_Execute()
        {
            this.Close(false);
        }
    }
}