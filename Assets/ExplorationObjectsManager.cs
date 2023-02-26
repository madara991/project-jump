using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class ExplorationObjectsManager : MonoBehaviour
{

	public static List<ExplorationObjj> All_ExplorationObject = new List<ExplorationObjj>();
	public List<ExplorationObjj> dd = All_ExplorationObject;

	public void OnDrawGizmos()
	{
		foreach (ExplorationObjj ObjectExp in All_ExplorationObject)
		{
			Handles.zTest = UnityEngine.Rendering.CompareFunction.LessEqual;
			//LINE BEZIR
			float haldHight = (transform.position.y - ObjectExp.transform.position.y) / 2f;
			Vector3 Offset = Vector3.up * haldHight;
			Handles.DrawBezier(
				  transform.position,
				  ObjectExp.transform.position,
				  transform.position - Offset,
				  ObjectExp.transform.position + Offset,
				  Color.white,
				  EditorGUIUtility.whiteTexture,
				  1f
				);
			
		}

	}
	 
	
}

