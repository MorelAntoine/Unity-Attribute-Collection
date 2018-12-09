using UnityEditor;
using UnityEngine;

namespace UniCraft.AttributeCollection
{
	/// <inheritdoc/>
	/// <summary>
	/// Disable the attached field in the inspector
	/// </summary>
	public sealed class DisableInInspectorAttribute : PropertyAttribute
	{}

	[CustomPropertyDrawer(typeof(DisableInInspectorAttribute))]
	public sealed class DisableInInspectorDrawer : PropertyDrawer
	{
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			EditorGUI.BeginDisabledGroup(true);
			EditorGUI.PropertyField(position, property, label);
			EditorGUI.EndDisabledGroup();
		}
	}
}
