using System.Collections;
using UnityEditor;
using UnityEngine;

namespace Kudan.AR
{
    [CustomEditor(typeof(KudanTracker))]
    /// <summary>
    /// Script that creates a custom inspector entry for the Kudan Tracker. 
    /// </summary>
    public class KudanTrackerEditor : Editor
    {
        //private KudanTracker _target;

        void Awake()
        {
            //_target = (KudanTracker)target;
        }

        public override void OnInspectorGUI()
        {
            GUILayout.BeginVertical();

            this.DrawDefaultInspector();

            GUILayout.Space(16f);

            EditorGUILayout.LabelField("App/Bundle ID:", PlayerSettings.applicationIdentifier);

            if (GUILayout.Button("Set App/Bundle ID"))
            {
				#if UNITY_2018_3_OR_NEWER
					SettingsService.OpenProjectSettings("Project/Player");
				#else
            		EditorApplication.ExecuteMenuItem("Edit/Project Settings/Player");
				#endif
            }

            GUILayout.Space(5f);
            if (GUILayout.Button("Get Editor API Key"))
            {
				if (Application.systemLanguage == SystemLanguage.Japanese)
				{
	                Application.OpenURL("https://www.xlsoft.com/doc/kudan/ja/development-license-keys_jp/");
				}
				else
				{
	                Application.OpenURL("https://www.xlsoft.com/doc/kudan/development-license-keys/");
				}
            }
            GUILayout.Space(5f);

            if (GUILayout.Button("Get Support"))
            {
				if (Application.systemLanguage == SystemLanguage.Japanese)
				{
				    Application.OpenURL("https://www.xlsoft.com/jp/products/kudan/support.html");
				}
				else
				{
				    Application.OpenURL("https://www.xlsoft.com/en/products/kudan/support.html");					
				}
			}

            //TrackingMethodBase[] trackers = (TrackingMethodBase[])Resources.FindObjectsOfTypeAll(typeof(TrackingMethodBase));

            //typeof(TrackingMethodMarkerless)

            bool externalOperation = false;

            GUILayout.EndVertical();

            if (externalOperation)
            {
                // This has to be here otherwise we get strange GUI stack exceptions
                EditorGUIUtility.ExitGUI();
            }
        }
    }
}