using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TestEditorWindow : EditorWindow
{
	

	[MenuItem("Savvy Tools/EditObject")]
	static void window()
	{
	     EditorWindow.GetWindow(typeof(TestEditorWindow),false,"Mode Savvy");	
	}
	
}
