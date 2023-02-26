using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.Linq;



[CanEditMultipleObjects]
[CustomEditor(typeof(typeexplotion))]
public class stady2 : Editor
{

	public UnityEngine.Object _object;

	private void OnEnable()
	{
		var _typexplo = target as typeexplotion;
		var _typexploSeri = new SerializedObject(_typexplo);

		SerializedProperty radies_Prop = serializedObject.FindProperty("color") ;
		Direction
	}

	public override void OnInspectorGUI()
	{
		typeexplotion explotion = target as typeexplotion;
		exampleGUI();
		base.OnInspectorGUI();
	}
	
	void exampleGUI()
	{

		GUIStyle style = new GUIStyle();
		style.fontSize = 22;
		style.fontStyle = FontStyle.Bold;
		style.normal.textColor = Color.blue;
		style.imagePosition = ImagePosition.ImageLeft;

		
		GUILayout.BeginHorizontal();
		GUILayout.Label("Title :", style);
		GUILayout.Label("garcar");
		GUILayout.Button("Search Enemy");
		GUILayout.EndHorizontal();

		EditorGUILayout.Vector2Field("vector", new Vector2(2f, 2f));
		EditorGUILayout.SelectableLabel("selecctedLabel");

		EditorGUILayout.PasswordField("1234");
		EditorGUIUtility.fieldWidth = 20f;
		EditorGUILayout.ObjectField("put here ", null, typeof(UnityEngine.GameObject), true);

		
	}

	

}




