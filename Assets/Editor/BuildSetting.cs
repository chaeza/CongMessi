using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class BuildSetting : MonoBehaviour
{
    public static void MyBuild()
    {
        string cPath = System.IO.Directory.GetCurrentDirectory();
        string path = cPath + "Build";

        // �ش� path�� ����
        System.IO.FileInfo pathInfo = new System.IO.FileInfo(path);
        // Build �� ����
        string[] scene = { "Assets/Scenes/SampleScene.unity" };
        // �� ������ path ����
        System.IO.FileInfo[] Scenes = new System.IO.FileInfo[scene.Length];

        // �ش� �ּҿ� ������ �����ϴ���
        if(pathInfo.Exists == false)
        {
            // �ش� �ּҿ� ���� ���� ����
            System.IO.Directory.CreateDirectory(path);
        }

        // ���� �ּ� ���� ��Ƽ� üũ
        for(int i= 0; i < Scenes.Length; i++)
        {
            Scenes[i] = new System.IO.FileInfo(cPath+ "/" + scene[i]);

            // �ش� ������ ������ 
            if(Scenes[i].Exists == false)
            {
                // ���� ����
                return;
            }
        }

        // �������� ����
        UnityEditor.BuildPipeline.BuildPlayer(scene, path + "build.exe", BuildTarget.StandaloneWindows, BuildOptions.None);
    }
}
