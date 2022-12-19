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
        // 해당 path의 정보
        FileInfo pathInfo = new FileInfo(path);
        // Build 할 씬들
        string[] scene = { "Assets/Scenes/SampleScene.unity" };
        // 그 씬들의 path 정보
        FileInfo[] Scenes = new FileInfo[scene.Length];

        // 해당 주소에 파일이 존재하는지
        if(pathInfo.Exists == false)
        {
            // 해당 주소에 새로 폴더 생성
            Directory.CreateDirectory(path);
        }

        // 씬들 주소 정보 담아서 체크
        for(int i= 0; i < Scenes.Length; i++)
        {
            Scenes[i] = new FileInfo(cPath+ "/" + scene[i]);

            // 해당 파일이 없으면 
            if(Scenes[i].Exists == false)
            {
                // 에러 뱉어내고
                Debug.LogError("Not Found Scene");
                // 빌드 안함
                return;
            }
        }

        // 실질적인 빌드
        BuildPipeline.BuildPlayer(scene, path + "build.exe", BuildTarget.StandaloneWindows, BuildOptions.None);
    }
}
