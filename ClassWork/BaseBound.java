import java.util.Scanner;
import java.util.Random;

public class BaseBound
{
	public static void main(String[] args)
	{
		Random rnd = new Random();
		int bse = 0;
		int bnd = rnd.nextInt(1000);
		
		Scanner x = new Scanner(System.in);
		System.out.println("Please enter number of processes: ");
		int y = x.nextInt();
		
		String[] nme = new String[y];
		int[] prcs = new int[y];
		
		for(int j = 0; j < y; j++)
		{
			System.out.println("Enter process " + j + " name: ");
			nme[j] = x.next();
			//System.out.println("Enter length of process " + j + ":");
			prcs[j] = rnd.nextInt(1000);
		}
		
		for(int i = 0; i < y; i++)
		{
			if(prcs[i] > bse && prcs[i] < bnd)
			{
				System.out.println();
				System.out.println("Process Name: " + nme[i] + "\nProcess Size: " + prcs[i] + "\nBase: " + bse + "\nBound: " + bnd + "\nThis process does fit into memory segment.");
			}
			else
			{
				System.out.println();
				System.out.println("Process Name: " + nme[i] + "\nProcess Size: " + prcs[i] + "\nBase: " + bse + "\nBound: " + bnd + "\nThis process does not fit into memory segment!");
			}	
		}
	}
}