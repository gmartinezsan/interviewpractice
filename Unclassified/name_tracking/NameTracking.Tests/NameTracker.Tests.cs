using System;
using System.Diagnostics;
using Xunit;

namespace NameTracking.Tests
{
    public class NameTrackerTests
    {
       

        [Fact]
        public void CanGetANewName()
        {
             NameTracker tracker = new NameTracker(); 
             var newname = tracker.allocate("apibox");

             var names = tracker.PrintDictionary();
             foreach (var item in names)
             {
                 Debug.Print(item);
             }

             Assert.True(newname == "apibox1", "The new name is not the expected");
        }
    }
}
