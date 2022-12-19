using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class BuildSetting : MonoBehaviour
{
    [UnityEditor.MenuItem("MyMenu/MyBuild", false, 1)]
    public static void MyBuild()
    {
        string cPath = System.IO.Directory.GetCurrentDirectory();
        string path = cPath + "/Build/";

        // 해당 path의 정보
        System.IO.FileInfo pathInfo = new System.IO.FileInfo("C:/ProgramData/Jenkins.jenkins/workspace/congMessi_Build/Build");
        // Build 할 씬들
        string[] scene = { "Assets/Scenes/SampleScene.unity" };
        // 그 씬들의 path 정보
        System.IO.FileInfo[] Scenes = new System.IO.FileInfo[scene.Length];

        // 해당 주소에 파일이 존재하는지
        if(pathInfo.Exists == false)
        {
            // 해당 주소에 새로 폴더 생성
            System.IO.Directory.CreateDirectory("C:/ProgramData/Jenkins.jenkins/workspace/congMessi_Build/Build");
        }

        // 실질적인 빌드
        UnityEditor.BuildPipeline.BuildPlayer(scene, "C:/ProgramData/Jenkins.jenkins/workspace/congMessi_Build/Build/build.exe", BuildTarget.StandaloneWindows, BuildOptions.None);
    }
}
