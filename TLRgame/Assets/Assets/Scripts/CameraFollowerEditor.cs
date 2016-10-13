/* CameraFollowerEditor
 * Script for setting camera position with GUI
 */

using UnityEngine;
using System.Collections;

#if UNITY_EDITOR
using UnityEditor;
#endif

#if UNITY_EDITOR
[CustomEditor (typeof(CameraFollow))]

class CameraFollowerEditor : Editor // extends Editor to change GUI
{
	public override void OnInspectorGUI ()
	{
		DrawDefaultInspector ();
		
		CameraFollow cf = (CameraFollow)target;
		// two buttons to set extremes for camera position
		if (GUILayout.Button ("Set Min Cam Pos")) {
			cf.SetMinCamPos ();
		}
		if (GUILayout.Button ("Set Max Cam Pos")) {
			cf.SetMaxCamPos ();
		}
	}
}
#endif