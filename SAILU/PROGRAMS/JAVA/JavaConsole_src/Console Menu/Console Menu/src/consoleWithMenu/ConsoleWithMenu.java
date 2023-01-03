package consoleWithMenu;

import java.util.Scanner;
import javaConsole.JavaConsole;
import menu.*;

/**
 * @brief Application class to test the java console and menu classes.
 * 
 * @author David MacDermot
 *
 * @date 02-07-2012
 * 
 * @bug
 */
public class ConsoleWithMenu {

	private static boolean fContinue = true;
	private static boolean fContinueItem2 = true;
	private static JavaConsole console;
	private static Scanner scanner;
	
	/**
	 * @brief Handle Menu exit choice
	 */
	public static void exitHandler()
	{
		fContinue = false;
	}

	/**
	 * @brief Handle Menu item1 choice
	 */
	public static void item1Handler(){
			System.out.println("You have chosen item 1.");
			scanner.nextLine();
	}

	/**
	 * @brief Handle Menu item2A choice
	 */
	public static void item2AHandler(){
			System.out.println("You have chosen item 2A.");
			scanner.nextLine();
	}

	/**
	 * @brief Handle Menu item2B choice
	 */
	public static void item2BHandler(){
			System.out.println("You have chosen item 2B.");
			scanner.nextLine();
	}

	/**
	 * @brief Handle Menu back choice
	 */
	public static void backHandler(){
			fContinueItem2 = false;
	}

	/**
	 * @brief Handle Menu item2 choice
	 */
	public static void item2Handler(){
		fContinueItem2 = true;
		Menu menu = new Menu(console);

		menu.add("Item 2A", new MenuCallback() { public void Invoke() { item2AHandler(); } });
		menu.add("Item 2B", new MenuCallback() { public void Invoke() { item2BHandler(); } });
		menu.add("Back", new MenuCallback() { public void Invoke() { backHandler(); } });

		while(fContinueItem2)
		{
			console.clear();
			System.out.println("Item 2: Please choose an option.");
			menu.show();
		}
	}

	/**
	 * @brief the program entry point
	 * @param args the command line arguments
	 */
	public static void main(String[] args) {

		console = new JavaConsole();
		scanner = new Scanner(System.in);
		Menu menu = new Menu(console);

		menu.add("Item 1", new MenuCallback() { public void Invoke() { item1Handler(); } });
		menu.add("Item 2", new MenuCallback() { public void Invoke() { item2Handler(); } });
		menu.add("Exit", new MenuCallback() { public void Invoke() { exitHandler(); } });

		while(fContinue)
		{
			console.clear();
			System.out.println("Please choose an option.");
			menu.show();
		}
		
		System.exit(0);
		
	}
}
