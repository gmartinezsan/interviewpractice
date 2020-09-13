using System;
using System.Collections.Generic;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            threeProductSuggestions(5, );
        }

    public static List<List<string>>  threeProductSuggestions(int numProducts, 
	                                                   List<string> repository, 
													   string customerQuery)     
	{
	    
	    List<List<string>> result = new List<List<string>>();
	    //Valitating input
	    if (string.IsNullOrEmpty(customerQuery) || repository.Count == 0
	        || customerQuery.Length < 2)
	      return null;
	      
	    string criteria = "";  
	    int letters = 2;
	    //Get the suggestions for each case iterating on the letters
	    //starting with 2 letters
	    for (int i=2; i< customerQuery.Length; i++)
	    {
	        criteria = customerQuery.Substring(0,letters);
	        result.Add(getSuggestions(repository,criteria));
	    }
	    
	   return result;
		
	}
	
	// public static List<string> getSuggestions(List<string>repository, string criteria)
	// {
	//     List<string> matches = new List<string>();
	    
	//     //Valitating data
    //     if (repository.Count > 0 && !string.IsNullOrEmpty(criteria)) {
    //         criteria = criteria.ToLower();
    //         int wordsfound = 0;
    //         foreach(string item in repository){
    //             var inCriteria = item.Substring(0, criteria.Length); 
    //             if (criteria==inCriteria && wordsfound < 3)
    //             {
    //                matches.Add(item);
    //                wordsfound++;
    //             }
    //         }
    //     }
    //  matches.Sort();
    //  return matches;
	// }	


    }
}
