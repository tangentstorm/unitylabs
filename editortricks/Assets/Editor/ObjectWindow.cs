using UnityEditor;
using UnityEngine;
using System.Collections;

public class ObjectWindow : EditorWindow {

	public GameObject obj = null;
	public MonoBehaviour myb = null;
	[System.NonSerialized] private bool hasInitialized;

	[MenuItem("EditorTricks/ObjectWindow")]
	static void Init() {
		UnityEditor.EditorWindow window = GetWindow(typeof(ObjectWindow));
		window.position = new Rect(0, 0, 250, 80);
		window.Show();
	}

	void OnEnable() {
		if (!ReferenceEquals(myb, null)) myb=EditorUtility.InstanceIDToObject(myb.GetInstanceID()) as MonoBehaviour;
		hasInitialized = true;
	}

	void OnInspectorUpdate() {
		Repaint();
	}

	void OnGUI() {
		if (!hasInitialized) OnEnable();
		obj = EditorGUILayout.ObjectField(obj, typeof(GameObject), true) as GameObject;
		myb = EditorGUILayout.ObjectField(myb, typeof(MonoBehaviour), true) as MonoBehaviour;
	}
}