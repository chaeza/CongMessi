using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class BuildSetting : MonoBehaviour
{
    // Current Path
    private static readonly string cPath = Directory.GetCurrentDirectory();
    // Build File Path
    private static readonly string path = cPath + "Build";

    public static void MyBuild()
    {
        // �ش� path�� ����
        FileInfo pathInfo = new FileInfo(path);
        // Build �� ����
        string[] scene = { "Assets/Scenes/SampleScene.unity" };
        // �� ������ path ����
        FileInfo[] Scenes = new FileInfo[scene.Length];

        // �ش� �ּҿ� ������ �����ϴ���
        if(pathInfo.Exists == false)
        {
            // �ش� �ּҿ� ���� ���� ����
            Directory.CreateDirectory(path);
        }

        // ���� �ּ� ���� ��Ƽ� üũ
        for(int i= 0; i < Scenes.Length; i++)
        {
            Scenes[i] = new FileInfo(cPath+ "/" + scene[i]);

            // �ش� ������ ������ 
            if(Scenes[i].Exists == false)
            {
                // ���� ����
                Debug.LogError("Not Found Scene");
                // ���� ����
                return;
            }
        }

        // �������� ����
        BuildPipeline.BuildPlayer(scene, path + "build.exe", BuildTarget.StandaloneWindows, BuildOptions.None);
    }
}
