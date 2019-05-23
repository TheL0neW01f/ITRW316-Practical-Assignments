import java.util.Scanner;
import java.util.Random;

public class PageReplacement
{
	public static void main(String[] args)
	{
		Scanner input = new Scanner(System.in);
		
		System.out.println("Would you like to do Global or Local Page Replacement? Enter 0 for Global and 1 for Local.");
		int page = 0;
		page = input.nextInt();
		
		if(page == 0)
		{
			FIFO();
		}
		
		if(page == 1)
		{
			LIFO();
		}
	}
	public static void FIFO()
	{
		System.out.println("Address Space Available: 1000\n");
		int spce = 1000;
		Random rnd = new Random();
		
		Scanner x = new Scanner(System.in);
		System.out.println("Please enter number of pages: ");
		int y = x.nextInt();
		int[] rand = new int[y];
		
		String[] nme = new String[y];
		int user = 0;
		int[] prcs = new int[y];
		//int[] b = new int[y];
		
		for(int j = 0; j < y; j++)
		{
			System.out.println("Enter page " + j + " name: ");
			nme[j] = x.next();
			System.out.println("Enter space required for page " + j + ":");
			prcs[j] = x.nextInt();
			spce -= prcs[j];
			rand[j] = rnd.nextInt(10);
			System.out.println();
			System.out.println("Page Name: " + nme[j] + ", Saved in TLB virtual page: " + rand[j] + "\nPage Size: " + prcs[j] + "\nPage added successfully!\nAddress Space Left: " + spce + "\n");
			
			if(spce == 0)	
			{
				System.out.println("No more address space available!\n");
			}
			
			if(spce < 0)
			{
				System.out.println("Replace page with another that will be able to fit into remaining memory space.\n");
				System.out.println("Enter new page " + (j - y + 1) + " name: ");
				nme[j-y+1] = x.next();
				System.out.println("Enter space required for page " + (j-y+1) + ": (Memory space remaining: " + (spce + prcs[j - y + 1]) + ")");
				prcs[j-y+1] = x.nextInt();
			}
		}
		
		for(int i = 0; i < y; i++)
		{
			System.out.println("\nPage Name: " + nme[i] + ", Saved in TLB virtual page: " + rand[i] + "\nPage Size: " + prcs[i] + "\nPage added successfully!\n");
		}
		
		System.out.println("Would you like to search with the page name or address? Enter 0 for page name and 1 for virtual address");
		int respond = 0;
		respond = x.nextInt();
		String pro = "";
		int address = 0;
		
		if(respond == 0)
		{
			System.out.println("Which page are you looking for?");
			pro = x.next();
			
			for(int a = 0; a < y; a++)
			{
				if(nme[a].equals(pro))
				{
					System.out.println("Page " + nme[a] + " has been found in virtual page index " + rand[a] + ".");
				}
				else
				{
					System.out.println("Page you entered is not found in virtual page index " + rand[a]);
				}
			}
		}
		else 
		{
			System.out.println("Enter address of page you are searching for.");
			address = x.nextInt();
			
			for(int b = 0; b < y; b++)
			{
				if(address == rand[b])
				{
					System.out.println("Virtual address " + rand[b] + " with page name " + nme[b]+ " found in index " + b);
				}
				else
				{
					System.out.println("Virtual address " + rand[b] + " not found in index " + b);
				}
			}
		}
	}
	
	public static void LIFO()
	{
		System.out.println("Address Space Available: 1000\n");
		int spce = 1000;
		Random rnd = new Random();
		
		Scanner x = new Scanner(System.in);
		System.out.println("Please enter number of pages: ");
		int y = x.nextInt();
		int[] rand = new int[y];
		
		String[] nme = new String[y];
		int user = 0;
		int[] prcs = new int[y];
		//int[] b = new int[y];
		
		for(int j = 0; j < y; j++)
		{
			System.out.println("Enter page " + j + " name: ");
			nme[j] = x.next();
			System.out.println("Enter space required for page " + j + ":");
			prcs[j] = x.nextInt();
			spce -= prcs[j];
			rand[j] = rnd.nextInt(10);
			System.out.println();
			System.out.println("Page Name: " + nme[j] + ", Saved in TLB virtual page: " + rand[j] + "\nPage Size: " + prcs[j] + "\nPage added successfully!\nAddress Space Left: " + spce + "\n");
			
			if(spce == 0)	
			{
				System.out.println("No more address space available!\n");
			}
			
			if(spce < 0)
			{
				System.out.println("Replace page with another that will be able to fit into remaining memory space.\n");
				System.out.println("Enter new page " + j + " name: ");
				nme[j] = x.next();
				System.out.println("Enter space required for page " + j + ": (Memory space remaining: " + (spce + prcs[j]) + ")");
				prcs[j] = x.nextInt();
			}
		}
		
		for(int i = 0; i < y; i++)
		{
			System.out.println("Page Name: " + nme[i] + ", Saved in TLB virtual page: " + rand[i] + "\nPage Size: " + prcs[i] + "\nPages added successfully!\n");
		}
		
		System.out.println("Would you like to search with the page name or address? Enter 0 for page name and 1 for virtual address");
		int respond = 0;
		respond = x.nextInt();
		String pro = "";
		int address = 0;
		
		if(respond == 0)
		{
			System.out.println("Which page are you looking for?");
			pro = x.next();
			
			for(int a = 0; a < y; a++)
			{
				if(nme[a].equals(pro))
				{
					System.out.println("Page " + nme[a] + " has been found in virtual page index " + rand[a] + ".");
				}
				else
				{
					System.out.println("Page you entered is not found in virtual page index " + rand[a]);
				}
			}
		}
		else 
		{
			System.out.println("Enter address of page you are searching for.");
			address = x.nextInt();
			
			for(int b = 0; b < y; b++)
			{
				if(address == rand[b])
				{
					System.out.println("Virtual address " + rand[b] + " with page name " + nme[b]+ " found in index " + b);
				}
				else
				{
					System.out.println("Virtual address " + rand[b] + " not found in index " + b);
				}
			}
		}
	}
}
