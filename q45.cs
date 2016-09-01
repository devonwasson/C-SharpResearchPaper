// devon wasson
// csci208
// q45

/*

What control structures does it use?

C# has selection control and repetition control (1)

selection control: c# allows for signel selection (if), double selection (if...else), multiple selection (switch) and inline conditional operations (?:)
repetition control: c# allows for top tested (while), bottom tested (do...while), property or array control (for...in), and counter controlled repetition (for)

source1: https://msdn.microsoft.com/en-us/library/vstudio/e240yzs4(v=vs.100).aspx
source for selection control (except ?: and switch structure): knoweldge of selection control and below code
source for switch structure: https://msdn.microsoft.com/en-us/library/06tc147t.aspx
source for (?:) structure: https://msdn.microsoft.com/en-us/library/ty67wk28.aspx
source for repition control (except foreach): knoweldge of repetition control and below code
source for foreach: https://msdn.microsoft.com/en-us/library/ttw7t8t6.aspx
*/

using System;

public class q45{
	public static void Main(){
	
		int a = 0;
		if(a == 0){
			Console.WriteLine("If statement works!\n");
		}

		int b = 0;
		if (b == 1){
			Console.WriteLine("did not make it to else statement\n");
		}
		else{
			Console.WriteLine("Else statement worked!\n");
		}		

		int caseSwitch = 2;	
		switch (caseSwitch)
		{
			case 1:
				Console.WriteLine("Switch made it to case 1\n");
				break;
			case 2:
				Console.WriteLine("Switch made it to case 2\n");
				break;  //use a break if you want to stop after a case
		
			default:
				Console.WriteLine("Default case has been reached\n");
				break;
		}
		
		string popularity;
		int numFriends = 50;
		popularity = (numFriends > 25) ? "Popular!" : "Not Popular";
		Console.WriteLine("You are: {0}\n", popularity);
		//sets the popularity variable to popular if numFriends > 25, 
		//and not popular if less than 25
		//works similar to if else, but can be done in one line


		int c = 0;
		while (c < 3){
			Console.WriteLine("Writing while loop line number {0}\n", c);
			c++;
		}		

		int d = 0;	
		do{
			Console.WriteLine("Writing do while loop line number {0}\n",d);
			d++;
		} while (d < 1);

		int[] nums = new int[4] {0,1,2,3};
		foreach (int x in nums){
			Console.WriteLine("For x In array: {0}\n", x);
		}		

		for (int e = 0; e < 3; e++ ) {
			Console.WriteLine("For line number {0}\n", e);
		}
	}
}
