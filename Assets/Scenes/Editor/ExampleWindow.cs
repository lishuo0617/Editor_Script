using UnityEngine;
using UnityEditor;

public class ExampleWindow : EditorWindow
{
	public Color changeColor;
    [MenuItem("Assets/改变模型材质颜色")]
    public static void ShowWindow()
    {
        GetWindow<ExampleWindow>("改变模型材质颜色");
    }
    private void OnGUI()
    {
        GUILayout.Label("改变所选物体颜色", EditorStyles.boldLabel);
        changeColor = EditorGUILayout.ColorField("ChangeColor", changeColor);

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("SetColor"))
        {
            Colorize();
        }
        if (GUILayout.Button("Reset"))
        {
            Colorreset();
        }
        GUILayout.EndHorizontal();

        void Colorize()//设置颜色
        {
            foreach (GameObject moxing in Selection.gameObjects)
            {
                Renderer xuanran = moxing.GetComponent<Renderer>();
                if (xuanran != null)
                {
                    xuanran.sharedMaterial.color = changeColor;

                }
            }
        }

        void Colorreset()//返回初始颜色
        {
            foreach (GameObject moxing in Selection.gameObjects)
            {
                Renderer xuanran = moxing.GetComponent<Renderer>();
                if (xuanran != null)
                {
                    xuanran.sharedMaterial.color = Color.white;
                }
            }

        }

    }

}