using UnityEditor;
using UnityEngine;
using System.Collections;

public class ObjectWindow : EditorWindow {

	public GameObject obj = null;
	public GameObject myb = null;

	[MenuItem("EditorTricks/ObjectWindow")]
	static void Init() {
		UnityEditor.EditorWindow window = GetWindow(typeof(ObjectWindow));
		window.position = new Rect(0, 0, 250, 80);
		window.Show();
	}
	void OnInspectorUpdate() {
		Repaint();
	}

	void OnGUI() {
		obj = EditorGUILayout.ObjectField(obj, typeof(GameObject), true) as GameObject;
	  MonoBehaviour mbref = EditorGUILayout.ObjectField(myb, typeof(MonoBehaviour), true) as MonoBehaviour;
    if (!ReferenceEquals(mbref, null)) myb = mbref.gameObject;
	}
}