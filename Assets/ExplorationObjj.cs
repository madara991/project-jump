using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

#if UNITY_EDITOR
using UnityEditor;
[ExecuteInEditMode]

public class ExplorationObjj : MonoBehaviour
{
	public float radius;
	public Color color = Color.red;
	MaterialPropertyBlock mpb;
	static readonly int shPropColor = Shader.PropertyToID("_Color");

	MaterialPropertyBlock MPB
	{
		get
		{
			if (mpb == null)
			{
				mpb = new MaterialPropertyBlock();
			}
			return mpb;
		}
	}
	void ApplyColor()
	{
		
		MeshRenderer rend = GetComponent<MeshRenderer>();
		MPB.SetColor(shPropColor, color);
		rend.SetPropertyBlock(MPB);
	}
	
	void OnEnable()
	{
		Debug.Log("on Enable");
		ExplorationObjectsManager.All_ExplorationObject.Add(this);
		Selection.selectionChanged += previesColor;
		//ApplyColor();
		
	}
	
	void test(SceneView scenview)
	{
		Debug.Log("durring scen gui");
		
	}
	void OnDisable() => ExplorationObjectsManager.All_ExplorationObject.Remove(this);
	
	private void OnDrawGizmosSelected()
	{
		Gizmos.color = color;
		Gizmos.DrawWireSphere(transform.position, radius);
	}

	
	
	void previesColor()
	{
		
		GameObject OnSelectObj = Selection.activeGameObject;
		foreach (var obj in ExplorationObjectsManager.All_ExplorationObject)
		{
			if (obj.gameObject != OnSelectObj.gameObject)
			{
				MeshRenderer rend = obj.GetComponent<MeshRenderer>();
				MPB.SetColor(shPropColor, Color.white);
				rend.SetPropertyBlock(MPB);
			}
			else ApplyColor();
			
		}
		
	}
	

#endif
}



	