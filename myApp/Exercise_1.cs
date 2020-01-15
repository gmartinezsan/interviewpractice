// IMPORT LIBRARY PACKAGES NEEDED BY YOUR PROGRAM
// SOME CLASSES WITHIN A PACKAGE MAY BE RESTRICTED
// DEFINE ANY CLASS AND METHOD NEEDED
// CLASS BEGINS, THIS CLASS IS REQUIRED
public class Solution
{
  //METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
    public int[] cellCompete(int[] states, int days)
    {
      for (int j = 0; j< days; j++)
      {
          var postState = 0;
          var previousState = 0;
          for(int i = 0; i < states.Length ; i++)
          {
              if ( i == 0 || i == states.Length - 1)
              {
                  postState = previousState = 0;
              }
              else
              {
                  previousState = states[i-1];
                  postState = states[i+1];
              }
            states[i] = previousState == postState ? 0 : 1;
        }
      }
      
      System.Console.WriteLine("Final State: ");
      
      for(int i = 0; i < states.Length ; i++)
        {
            System.Console.Write(states[i] + ( i== states.Length ? " " : ","));
        }
        
      return states;
    }
  // METHOD SIGNATURE ENDS
}