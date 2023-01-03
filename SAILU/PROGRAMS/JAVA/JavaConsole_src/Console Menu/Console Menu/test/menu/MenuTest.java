package menu;

import javaConsole.JavaConsole;

import org.junit.Test;


import junit.framework.TestCase;
import menu.Menu;
import menu.MenuCallback;

public class MenuTest extends TestCase {

	public MenuCallback CALLBACKTEST = new MenuCallback() {
		public void Invoke() {
			throw new UnsupportedOperationException("Not supported yet.");
		}
	};

	@Test
	public void testMenu_Add() {
		Menu menu = new Menu(new JavaConsole());

		assertTrue(menu.add("Test", CALLBACKTEST));

	}
}
